using book_store.context;
using book_store.database.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.database.repository
{
    internal class OrderRepository: Repository<Order>
    {
        public OrderRepository(AppDbContext context) : base(context) { }

        public async Task<Order> CreateOrderFromCartAsync(int userId, int totalCost, List<int> bookIds)
        {
            if (bookIds == null || bookIds.Count == 0)
                throw new ArgumentException("Список книг пуст.");

            using var transaction = await context.Database.BeginTransactionAsync();
            try
            {
                // Загружаем CartItems пользователя
                var cartItems = await context.CartItems
                    .Where(ci => ci.UserId == userId && bookIds.Contains(ci.BookId))
                    .ToListAsync();

                if (cartItems.Count == 0)
                    throw new InvalidOperationException("Корзина пуста или книги не найдены.");

                var order = new Order
                {
                    UserId = userId,
                    PaymentMethod = "Unspecified",
                    PaymentStatusId = 1, // Например, "Pending"
                    OrderStatusId = 1, // Например, "Processing",
                    Cost = totalCost,
                    PaidIn = DateTime.UtcNow,
                    OrderItems = new List<OrderItem>()
                };

                // Обрабатываем каждый товар из корзины
                foreach (var cartItem in cartItems)
                {
                    int remainingQuantity = cartItem.Quantity; // Сколько осталось распределить

                    // Загружаем все склады, где есть эта книга, сортируя по убыванию количества
                    var bookWarehouses = await context.BookWarehouses
                        .Where(bw => bw.BookId == cartItem.BookId && bw.Quantity > 0)
                        .OrderByDescending(bw => bw.Quantity)
                        .ToListAsync();

                    if (bookWarehouses.Count == 0)
                        throw new InvalidOperationException($"Нет доступных складов для книги (ID: {cartItem.BookId})");

                    // Распределяем книги по складам
                    foreach (var bookWarehouse in bookWarehouses)
                    {
                        if (remainingQuantity <= 0)
                            break;

                        int booksToTake = Math.Min(bookWarehouse.Quantity, remainingQuantity);

                        // Добавляем OrderItem в список
                        order.OrderItems.Add(new OrderItem
                        {
                            BookId = cartItem.BookId,
                            Quantity = booksToTake
                        });

                        // Обновляем количество книг на складе
                        bookWarehouse.Quantity -= booksToTake;
                        remainingQuantity -= booksToTake;
                    }

                    // Если после распределения книг не хватило — ошибка
                    if (remainingQuantity > 0)
                        throw new InvalidOperationException($"Недостаточно книг (ID: {cartItem.BookId}) на всех складах.");
                }

                // Группируем OrderItems перед сохранением
                order.OrderItems = order.OrderItems
                    .GroupBy(oi => oi.BookId)
                    .Select(g => new OrderItem
                    {
                        BookId = g.Key,
                        Quantity = g.Sum(oi => oi.Quantity) // Суммируем количество книг
                    })
                    .ToList();

                // Сохраняем заказ
                context.Orders.Add(order);
                await context.SaveChangesAsync();

                // Удаляем использованные CartItems
                context.CartItems.RemoveRange(cartItems);
                await context.SaveChangesAsync();

                await transaction.CommitAsync();
                return order;
            } catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }



        public List<Order> FindAllByUser(int userId)
        {
            return context.Orders
                .Where(o => o.UserId == userId)
                .Include(o => o.OrderStatus)
                .Include(o => o.PaymentStatus)
                .ToList();
        }
    }
}

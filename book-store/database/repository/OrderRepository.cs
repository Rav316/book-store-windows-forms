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

        public async Task<Order> CreateOrderFromCartAsync(int userId, List<int> bookIds)
        {
            if (bookIds == null || bookIds.Count == 0)
                throw new ArgumentException("Список книг пуст.");

            using var transaction = await context.Database.BeginTransactionAsync();
            try
            {
                // Загружаем CartItems из БД
                var cartItems = await context.CartItems
                    .Where(ci => ci.UserId == userId && bookIds.Contains(ci.BookId))
                    .ToListAsync();

                if (cartItems.Count == 0)
                    throw new InvalidOperationException("Корзина пуста или книги не найдены.");

                var order = new Order
                {
                    PaymentMethod = "Unspecified",
                    PaymentStatusId = 1, // Например, "Pending"
                    OrderStatusId = 1, // Например, "Processing"
                    PaidIn = DateTime.UtcNow,
                    OrderItems = new List<OrderItem>(),
                    UserId = userId
                };

                foreach (var cartItem in cartItems)
                {
                    // Найти склад с наибольшим количеством данной книги
                    var bookWarehouse = await context.BookWarehouses
                        .Where(bw => bw.BookId == cartItem.BookId)
                        .OrderByDescending(bw => bw.Quantity)
                        .FirstOrDefaultAsync();

                    if (bookWarehouse == null || bookWarehouse.Quantity < cartItem.Quantity)
                        throw new InvalidOperationException($"Недостаточно книг (ID: {cartItem.BookId}) на складах.");

                    // Создать OrderItem
                    var orderItem = new OrderItem
                    {
                        BookId = cartItem.BookId,
                        Quantity = cartItem.Quantity
                    };

                    order.OrderItems.Add(orderItem);

                    // Уменьшить количество книг на складе
                    bookWarehouse.Quantity -= cartItem.Quantity;
                }

                // Добавляем заказ в базу
                context.Orders.Add(order);
                await context.SaveChangesAsync();

                // Удаляем использованные cartItems
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
    }
}

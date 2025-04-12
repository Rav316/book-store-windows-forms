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
                var cartItems = await context.CartItems
                    .Where(ci => ci.UserId == userId && bookIds.Contains(ci.BookId))
                    .ToListAsync();

                if (cartItems.Count == 0)
                    throw new InvalidOperationException("Корзина пуста или книги не найдены.");

                var order = new Order
                {
                    UserId = userId,
                    PaymentMethod = "Банковская карта",
                    PaymentStatusId = 1,
                    OrderStatusId = 1,
                    Cost = totalCost
                };

                var orderItemWarehouses = new List<OrderItem>();

                foreach (var cartItem in cartItems)
                {
                    int remainingQuantity = cartItem.Quantity;

                    var bookWarehouses = await context.BookWarehouses
                        .Where(bw => bw.BookId == cartItem.BookId && bw.Quantity > 0)
                        .OrderByDescending(bw => bw.Quantity)
                        .ToListAsync();

                    if (bookWarehouses.Count == 0)
                        throw new InvalidOperationException($"Нет доступных складов для книги (ID: {cartItem.BookId})");

                    foreach (var bookWarehouse in bookWarehouses)
                    {
                        if (remainingQuantity <= 0)
                            break;

                        int booksToTake = Math.Min(bookWarehouse.Quantity, remainingQuantity);

                        orderItemWarehouses.Add(new OrderItem
                        {
                            Order = order,
                            BookId = cartItem.BookId,
                            WarehouseId = bookWarehouse.WarehouseId,
                            Quantity = booksToTake
                        });

                        bookWarehouse.Quantity -= booksToTake;
                        remainingQuantity -= booksToTake;
                    }

                    if (remainingQuantity > 0)
                        throw new InvalidOperationException($"Недостаточно книг (ID: {cartItem.BookId}) на всех складах.");
                }

                context.Orders.Add(order);
                await context.SaveChangesAsync();

                await context.OrderItems.AddRangeAsync(orderItemWarehouses);
                await context.SaveChangesAsync();

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

        public async Task CancelOrderAsync(int orderId)
        {
            using var transaction = await context.Database.BeginTransactionAsync();
            try
            {
                var order = await context.Orders
                    .Include(o => o.OrderItems)
                    .FirstOrDefaultAsync(o => o.Id == orderId);

                if (order == null)
                    throw new InvalidOperationException("Заказ не найден.");

                var orderItems = await context.OrderItems
                    .Where(o => o.OrderId == orderId)
                    .ToListAsync();

                foreach (var item in orderItems)
                {
                    var bookWarehouse = await context.BookWarehouses
                        .FirstOrDefaultAsync(bw => bw.BookId == item.BookId && bw.WarehouseId == item.WarehouseId);

                    if (bookWarehouse != null)
                    {
                        bookWarehouse.Quantity += item.Quantity;
                    }
                }


                order.OrderStatus = (await context.OrderStatuses.FindAsync(3))!;
                context.Orders.Update(order);
                await context.SaveChangesAsync();

                await transaction.CommitAsync();
            } catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public List<Order> FindAllByUser(int userId)
        {
            return context.Orders
                .AsNoTracking()
                .Where(o => o.UserId == userId)
                .Include(o => o.OrderStatus)
                .Include(o => o.PaymentStatus)
                .ToList();
        }

        public async Task FinishOrderAsync(int orderId)
        {
            var order = await context.Orders.FindAsync(orderId);
            if(order != null)
            {
                order.OrderStatusId = 4;
                context.Orders.Update(order);
                await context.SaveChangesAsync();
            }
        }
    }
}

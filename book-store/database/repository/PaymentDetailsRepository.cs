using book_store.context;
using book_store.database.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.database.repository
{
    public class PaymentDetailRepository: Repository<PaymentDetail>
    {
        public PaymentDetailRepository(AppDbContext context) : base(context) { }

        public async Task PayForTheOrder(PaymentDetail paymentDetail)
        {
            using var transaction = await context.Database.BeginTransactionAsync();
            try
            {
                await CreateAsync(paymentDetail);

                var order = await context.Orders.FindAsync(paymentDetail.OrderId);

                if (order != null)
                {
                    order.PaymentStatus = (await context.PaymentStatuses.FindAsync(2))!;
                    order.OrderStatus = (await context.OrderStatuses.FindAsync(4))!;
                    context.Orders.Update(order);
                    await context.SaveChangesAsync();
                }

                await transaction.CommitAsync();
            } catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }
}

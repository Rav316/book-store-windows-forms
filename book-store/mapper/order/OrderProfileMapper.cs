using book_store.database.entity;
using book_store.dto.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.mapper.order
{
    internal class OrderProfileMapper : Mapper<Order, OrderProfileDto>
    {
        public override OrderProfileDto ToDto(Order entity)
        {
            return new OrderProfileDto
            (
                entity.Id,
                entity.PaymentMethod,
                entity.PaymentStatus.Name,
                entity.OrderStatus.Name,
                entity.Cost,
                entity.PaidIn
            );
        }
    }
}

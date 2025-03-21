using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.dto.order
{
    public class OrderProfileDto
    {
        public int Id { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string OrderStatus {  get; set; }
        public int Cost { get; set; }
        public DateTime? PaidIn { get; set; }

        public OrderProfileDto(int id, string paymentMethod, string paymentStatus, string orderStatus, int cost, DateTime? paidIn)
        {
            Id = id;
            PaymentMethod = paymentMethod;
            PaymentStatus = paymentStatus;
            OrderStatus = orderStatus;
            Cost = cost;
            PaidIn = paidIn;
        }
    }
}

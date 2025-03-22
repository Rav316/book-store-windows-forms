using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.database.entity
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(127)]
        public string PaymentMethod { get; set; } = string.Empty;

        [Required]
        public int PaymentStatusId { get; set; }

        [ForeignKey("PaymentStatusId")]
        public virtual PaymentStatus PaymentStatus { get; set; }

        [Required]
        public int OrderStatusId { get; set; }

        [ForeignKey("OrderStatusId")]
        public virtual OrderStatus OrderStatus { get; set; }

        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public int Cost { get; set; }

        public DateTime? PaidIn { get; set; }

        public virtual List<OrderItem> OrderItems { get; set; } = new();

        public virtual PaymentDetail PaymentDetail { get; set; }
    }
}

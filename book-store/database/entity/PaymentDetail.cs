using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.database.entity
{
    public class PaymentDetail
    {
        [Key]
        [ForeignKey("Order")]
        public int OrderId { get; set; }

        [Required]
        [StringLength(16)]
        public string CardNumber { get; set; } = string.Empty;

        [Required]
        public DateTime ExpirationDate { get; set; }

        [Required]
        public short Code { get; set; }

        public virtual Order Order { get; set; }
    }

}

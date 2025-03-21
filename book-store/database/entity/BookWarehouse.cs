using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.database.entity
{
    public class BookWarehouse
    {
        [Key, Column(Order = 1)]
        public int BookId { get; set; }

        [Key, Column(Order = 2)]
        public int WarehouseId { get; set; }

        public int Quantity { get; set; } = 1;

        public virtual Book Book { get; set; } = null!;
        public virtual Warehouse Warehouse { get; set; } = null!;
    }
}

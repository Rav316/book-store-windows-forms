using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.dto.bookWarehouse
{
    public class BookWarehouseManagementDto
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public int Quantity { get; set; }

        public BookWarehouseManagementDto(int bookId, string bookName, int warehouseId, string warehouseName, int quantity)
        {
            BookId = bookId;
            BookName = bookName;
            WarehouseId = warehouseId;
            WarehouseName = warehouseName;
            Quantity = quantity;
        }
    }
}

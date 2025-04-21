using book_store.database.entity;
using book_store.dto.bookWarehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.mapper.bookWarehouse
{
    public class BookWarehouseManagementMapper : Mapper<BookWarehouse, BookWarehouseManagementDto>
    {
        public override BookWarehouseManagementDto ToDto(BookWarehouse entity)
        {
            return new BookWarehouseManagementDto
            (
                entity.BookId,
                entity.Book.Title,
                entity.WarehouseId,
                entity.Warehouse.Name,
                entity.Quantity
            );
        }
    }
}

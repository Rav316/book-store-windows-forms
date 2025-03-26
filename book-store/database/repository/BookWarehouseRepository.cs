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
    class BookWarehouseRepository: Repository<BookWarehouse>
    {
        public BookWarehouseRepository(AppDbContext context) : base(context) { }

        public bool IsBookAvailable(int bookId)
        {
            return context.BookWarehouses.Any(bw => bw.BookId == bookId && bw.Quantity > 0);
        }

        public async Task<BookWarehouse?> FindByBookAndWarehouse(int bookId, int warehouseId)
        {
            return await context.BookWarehouses.FirstOrDefaultAsync(bw => bw.BookId == bookId && bw.WarehouseId == warehouseId);
        }

        public async Task DeleteByBookAndWarehouse(int bookId, int warehouseId)
        {
            var bookWarehouse = await context.BookWarehouses
                .FirstOrDefaultAsync(bw => bw.BookId == bookId && bw.WarehouseId == warehouseId);
            if(bookWarehouse != null)
            {
                context.BookWarehouses.Remove(bookWarehouse);
                context.SaveChanges();
            }
        }
    }
}

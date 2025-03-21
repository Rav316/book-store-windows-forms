using book_store.context;
using book_store.database.entity;
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
    }
}

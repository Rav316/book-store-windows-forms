using book_store.context;
using book_store.database.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.database.repository
{
    internal class BookRepository : Repository<Book>
    {
        public BookRepository(AppDbContext context) : base(context) { }
    }
}

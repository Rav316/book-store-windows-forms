using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.database.entity
{
    internal class Warehouse
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int Count { get; set; }

        public Warehouse(int id, int bookId, int count)
        {
            Id = id;
            BookId = bookId;
            Count = count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.entity
{
    internal class Favorites
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }

        public Favorites(int id, int userId, int bookId)
        {
            Id = id;
            UserId = userId;
            BookId = bookId;
        }
    }
}

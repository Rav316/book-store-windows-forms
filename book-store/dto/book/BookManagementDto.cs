using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.dto.book
{
    public class BookManagementDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public BookManagementDto(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }
    }
}

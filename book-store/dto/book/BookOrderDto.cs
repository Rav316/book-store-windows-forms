using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.dto.book
{
    public class BookOrderDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorFullName { get; set; }
        public Image Image { get; set; }

        public int Price { get; set; }

        public BookOrderDto(int id, string title, string authorFullName, Image image, int price)
        {
            Id = id;
            Title = title;
            AuthorFullName = authorFullName;
            Image = image;
            Price = price;
        }
    }
}

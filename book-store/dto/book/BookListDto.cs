using Npgsql.TypeMapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.dto.book
{
    public class BookListDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorFullName { get; set; }
        public string? ImagePath { get; set; }
        public int Publisher { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsInCart { get; set; }
        public int? Quantity { get; set; }
        public int Category { get; set; }
        public int CoverType { get; set; }
        public int Language { get; set; }
        public int Price { get; set; }
        public bool? IsAvailable { get; set; }

        [NotMapped]
        public Image? image { get; set; }
    }
}

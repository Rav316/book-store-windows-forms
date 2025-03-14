using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.entity
{
    public class Book
    {
        public int Id { get; set; }
        public double Rating { get; set; }
        public int Price { get; set; }
        public string ImagePath { get; set; }
        public string Series { get; set; }
        public int YearOfPublishing { get; set; }
        public string Size { get; set; }
        public int Circulation { get; set; }
        public int Weight { get; set; }
        public int AgeRestrictions { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public int PublisherId { get; set; }
        public int AuthorId { get; set; }
        public int CoverTypeId { get; set; }
        public int LanguageId { get; set; }

        
    }
}

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
        public Image Image { get; set; }
        public string Series { get; set; }
        public int YearOfPublishing { get; set; }
        public string Isbn { get; set; }
        public int NumberOfPages { get; set; }
        public string Size { get; set; }
        public int Circulation { get; set; }
        public int Weight { get; set; }
        public int AgeRestrictions { get; set; }
        public string BookName { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public int PublisherId { get; set; }
        public int AuthorId { get; set; }
        public int CoverTypeId { get; set; }
        public int LanguageId { get; set; }

        public bool IsInFavorites { get; set; }
        public bool IsInCart { get; set; }
        public string AuthorName { get; set; }

        public Book(
        int id,
        double rating,
        int price,
        string imagePath,
        string series,
        int yearOfPublishing,
        string isbn,
        int numberOfPages,
        string size,
        int circulation,
        int weight,
        int ageRestrictions,
        string name,
        int categoryId,
        string description,
        int publisherId,
        int authorId,
        int coverTypeId,
        int languageId)
        {
            Id = id;
            Rating = rating;
            Price = price;
            //ImagePath = imagePath;
            if(imagePath != null && !imagePath.Equals(""))
            {
                Image = Image.FromFile(imagePath);
            }
            else
            {
                Image = Image.FromFile(@"..\..\..\Resources\Books\book.png");
            }
            Series = series;
            YearOfPublishing = yearOfPublishing;
            Isbn = isbn;
            NumberOfPages = numberOfPages;
            Size = size;
            Circulation = circulation;
            Weight = weight;
            AgeRestrictions = ageRestrictions;
            BookName = name;
            CategoryId = categoryId;
            Description = description;
            PublisherId = publisherId;
            AuthorId = authorId;
            CoverTypeId = coverTypeId;
            LanguageId = languageId;
        }
    }
}

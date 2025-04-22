using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.database.entity
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        public int Price { get; set; }

        public string? ImagePath { get; set; }
        [Column("series")]

        public string? Series { get; set; }

        public int? NumberOfPages { get; set; }

        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Length { get; set; }
        public long? Circulation { get; set; }
        public int? Weight { get; set; }

        public int? AgeRestrictions { get; set; }
        public string Title { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        public string? Description { get; set; }
        public int? YearOfPublishing { get; set; }
        public string? Isbn { get; set; }

        [ForeignKey("PublisherId")]
        public int PublisherId { get; set; }
        public virtual Publisher? Publisher { get; set; }

        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public virtual Author? Author { get; set; }

        [ForeignKey("CoverTypeId")]
        public int CoverTypeId { get; set; }
        public virtual CoverType? CoverType { get; set; }

        [ForeignKey("LanguageId")]
        public int LanguageId { get; set; }
        public virtual Language? Language { get; set; }

        public virtual List<User> FavoritedByUsers { get; set; } = new List<User>();
        public virtual List<BookReview> BookReviews { get; set; }

    }
}

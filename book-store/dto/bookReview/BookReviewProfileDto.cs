using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.dto.bookReview
{
    internal class BookReviewProfileDto
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int BookId { get; set; }
        public string Author { get; set; }
        public Image BookImage { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }

        public BookReviewProfileDto(int id, string bookName, int bookId, string author, Image bookImage, string content, int rating, DateTime createdAt)
        {
            Id = id;
            BookName = bookName;
            BookId = bookId;
            Author = author;
            BookImage = bookImage;
            Content = content;
            Rating = rating;
            CreatedAt = createdAt;
        }
    }
}

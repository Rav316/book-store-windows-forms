using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.dto.bookReview
{
    public class BookReviewManagementDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public string Username { get; set; }
        public Image UserAvatar { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }


        public BookReviewManagementDto(int id, int userId, int bookId, string username, Image userAvatar, string content, int rating, DateTime createdAt)
        {
            Id = id;
            UserId = userId;
            BookId = bookId;
            Username = username;
            UserAvatar = userAvatar;
            Content = content;
            Rating = rating;
            CreatedAt = createdAt;
        }
    }
}

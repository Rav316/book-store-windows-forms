using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.dto.bookReview
{
    internal class BookReviewListDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public Image UserAvatar { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }

        public BookReviewListDto(int id, string username, Image userAvatar, string content, int rating, DateTime createdAt)
        {
            Id = id;
            Username = username;
            UserAvatar = userAvatar;
            Content = content;
            Rating = rating;
            CreatedAt = createdAt;
        }
    }
}

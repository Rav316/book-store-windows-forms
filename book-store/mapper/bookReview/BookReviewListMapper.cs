using book_store.database.entity;
using book_store.dto.bookReview;
using book_store.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.mapper.bookReview
{
    internal class BookReviewListMapper
    {
        public BookReviewListDto ToDto(BookReview bookReview)
        {
            User user = bookReview.User;
            return new BookReviewListDto
            (
                bookReview.Id,
                user.Username,
                ImageUtils.GetUserAvatarByPath(user.ImagePath),
                bookReview.Content,
                bookReview.Rating,
                bookReview.CreatedAt
            );
        }
    }
}

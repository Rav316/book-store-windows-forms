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
    internal class BookReviewManagementMapper : Mapper<BookReview, BookReviewManagementDto>
    {
        public override BookReviewManagementDto ToDto(BookReview entity)
        {
            User user = entity.User;
            return new BookReviewManagementDto
            (
                entity.Id,
                user.Id,
                entity.Book.Id,
                user.Username,
                ImageUtils.GetUserAvatarByPath(user.ImagePath),
                entity.Content,
                entity.Rating,
                entity.CreatedAt
            );
        }
    }
}

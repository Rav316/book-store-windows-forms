using book_store.database.entity;
using book_store.dto.bookReview;
using book_store.util;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.mapper.bookReview
{
    internal class BookReviewProfileMapper : Mapper<BookReview, BookReviewProfileDto>
    {
        public override BookReviewProfileDto ToDto(BookReview entity)
        {
            Book book = entity.Book;
            Author author = book.Author;
            return new BookReviewProfileDto
            (
                entity.Id,
                book.Title,
                book.Id,
                $"{author.FirstName} {author.LastName}",
                ImageUtils.GetBookImageByPath(book.ImagePath),
                entity.Content,
                entity.Rating,
                entity.CreatedAt
            );
        }
    }
}

using book_store.database.entity;
using book_store.dto.book;
using book_store.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.mapper.book
{
    internal class BookOrderMapper : Mapper<Book, BookOrderDto>
    {
        public override BookOrderDto ToDto(Book entity)
        {
            var author = entity.Author;
            return new BookOrderDto
            (
                entity.Id,
                entity.Title,
                $"{author?.FirstName} {author?.MidName} {author?.LastName}",
                ImageUtils.GetBookImageByPath(entity.ImagePath),
                entity.Price
            );
        }
    }
}

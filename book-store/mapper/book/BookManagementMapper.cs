using book_store.database.entity;
using book_store.dto.book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.mapper.book
{
    public class BookManagementMapper : Mapper<Book, BookManagementDto>
    {
        public override BookManagementDto ToDto(Book entity)
        {
            var author = entity.Author;
            return new BookManagementDto
            (
                entity.Id,
                entity.Title,
                $"{author?.FirstName} {author?.MidName} {author?.LastName}"
            );
        }
    }
}

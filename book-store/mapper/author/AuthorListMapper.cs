using book_store.database.entity;
using book_store.dto.author;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.mapper.author
{
    public class AuthorListMapper : Mapper<Author, AuthorListDto>
    {
        public override AuthorListDto ToDto(Author entity)
        {
            return new AuthorListDto
            (
                entity.Id,
                $"{entity.FirstName} {entity.MidName} {entity.LastName}"
            );
        }
    }
}

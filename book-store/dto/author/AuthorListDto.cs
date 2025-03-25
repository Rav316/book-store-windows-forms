using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.dto.author
{
    public class AuthorListDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public AuthorListDto(int id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }
    }
}

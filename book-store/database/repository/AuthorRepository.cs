using book_store.context;
using book_store.database.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.database.repository
{
    public class AuthorRepository: Repository<Author>
    {
        public AuthorRepository(AppDbContext context) : base(context) { }
    }
}

using book_store.context;
using book_store.database.entity;
using book_store.database.repository;
using book_store.dto.author;
using book_store.mapper.author;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    public class AuthorService
    {
        private readonly AuthorRepository authorRepository = new AuthorRepository(AppDbContext.INSTANCE);
        private readonly AuthorListMapper authorListMapper = new AuthorListMapper();

        public async Task<List<AuthorListDto>> FindAll()
        {
            var authors = await authorRepository.FindAllAsync();
            return [.. authors
                .Select(authorListMapper.ToDto)
                .OrderBy(a => a.Id)
            ];
        }
    }
}

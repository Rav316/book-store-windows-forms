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

        public async Task<List<AuthorListDto>> FindAllListDto()
        {
            var authors = await authorRepository.FindAllAsync();
            return [.. authors
                .Select(authorListMapper.ToDto)
                .OrderBy(a => a.FullName)
            ];
        }

        public async Task<List<Author>> FindAll()
        {
            List<Author> authors = await authorRepository.FindAllAsync();
            return authors.OrderBy(a => a.Id).ToList();
        }

        public async Task<Author?> FindById(int id)
        {
            return await authorRepository.FindByIdAsync(id);
        }

        public async Task Update(Author author)
        {
            await authorRepository.UpdateAsync(author);
        }

        public async Task Delete(int id)
        {
            await authorRepository.DeleteByIdAsync(id);
        }
    }
}

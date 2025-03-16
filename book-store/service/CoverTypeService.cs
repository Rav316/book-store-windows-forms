using book_store.context;
using book_store.database.entity;
using book_store.database.repository;
using book_store.dto.book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    internal class CoverTypeService
    {
        private readonly CoverTypeRepository bookRepository = new CoverTypeRepository(AppDbContext.INSTANCE);

        public Task<List<CoverType>> FindAll()
        {
            return bookRepository.FindAllAsync();
        }
    }
}

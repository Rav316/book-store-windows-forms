using book_store.context;
using book_store.database.repository;
using book_store.dto.book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    internal class BookService
    {
        private readonly BookRepository bookRepository = new BookRepository(AppDbContext.INSTANCE);
        
        public Task<List<BookListDto>> FindAllWithUserInfo()
        {
            return bookRepository.FindAllWithUserInfo(SecurityContext.Authentication.Id);
        }

        public (int, int) GetMinAndMaxPrice()
        {
            return bookRepository.GetMinAndMaxPrice();
        }
    }
}

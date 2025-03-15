using book_store.context;
using book_store.dao;
using book_store.entity;
using book_store.exception;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    internal class BookService
    {
        private readonly BookDao bookDao = new BookDao();

        public List<Book> FindAllWithUserInfo()
        {
            return bookDao.FindAllWithUserInfo(SecurityContext.Authentication.Id);
        }

        public Book FindById(int id)
        {
            Book book = bookDao.FindByIdForUser(id, SecurityContext.Authentication.Id);
            if(book != null)
            {
                return book;
            }
            else
            {
                throw new EntityNotFoundException($"Книга с id {id} не найдена");
            }
        }

        public (int, int) GetMinAndMaxPrice()
        {
            return bookDao.GetMinAndMaxPrice();
        }
    }
}

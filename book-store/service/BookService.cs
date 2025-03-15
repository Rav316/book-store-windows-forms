using book_store.context;
using book_store.dao;
using book_store.entity;
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

        public (int, int) GetMinAndMaxPrice()
        {
            return bookDao.GetMinAndMaxPrice();
        }
    }
}

using book_store.dao;
using book_store.entity;
using book_store.exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    internal class AuthorService
    {
        private readonly AuthorDao authorDao = new AuthorDao();

        public Author FindById(int id)
        {
            Author author = authorDao.FindById(id);
            if(author != null)
            {
                return author;
            }
            else
            {
                throw new EntityNotFoundException($"Автор с id {id} не найден");
            }
        }
    }
}

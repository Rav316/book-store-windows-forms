using book_store.dao;
using book_store.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    internal class CategoryService
    {
        private readonly CategoryDao categoryDao = new CategoryDao();

        public List<Category> FindAll()
        {
            return categoryDao.FindAll();
        }
    }
}

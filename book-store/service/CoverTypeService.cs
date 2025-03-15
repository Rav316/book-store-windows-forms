using book_store.dao;
using book_store.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    internal class CoverTypeService
    {
        private readonly CoverTypeDao coverTypeDao = new CoverTypeDao();
        public List<CoverType> FindAll()
        {
            return coverTypeDao.FindAll();
        }
    }
}

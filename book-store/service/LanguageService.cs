using book_store.dao;
using book_store.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    internal class LanguageService
    {
        private readonly LanguageDao languageDao = new LanguageDao();

        public List<Language> FindAll()
        {
            return languageDao.FindAll();
        }
    }
}

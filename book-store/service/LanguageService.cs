using book_store.context;
using book_store.database.entity;
using book_store.database.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    internal class LanguageService
    {
        private readonly LanguageRepository languageRepository = new LanguageRepository(AppDbContext.INSTANCE);

        public Task<List<Language>> FindAll()
        {
            return languageRepository.FindAllAsync();
        }
    }
}

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

        public async Task<List<Language>> FindAll()
        {
            List<Language> languages = await languageRepository.FindAllAsync();
            return languages
                .OrderBy(l => l.Name)
                .ToList();
        }
    }
}

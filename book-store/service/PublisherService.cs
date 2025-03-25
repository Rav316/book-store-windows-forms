using book_store.context;
using book_store.database.entity;
using book_store.database.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    internal class PublisherService
    {
        private readonly PublisherRepository publisherRepository = new PublisherRepository(AppDbContext.INSTANCE);

        public async Task<List<Publisher>> FindAll()
        {
            return await publisherRepository.FindAllAsync();
        }
    }
}

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
            List<Publisher> publishers = await publisherRepository.FindAllAsync();
            return publishers
                .OrderBy(p => p.Name)
                .ToList();
        }

        public async Task<Publisher?> FindById(int id)
        {
            return await publisherRepository.FindByIdAsync(id);
        }

        public Publisher? FindByName(string name)
        {
            return publisherRepository.FindByName(name);
        }

        public async Task Create(Publisher publisher)
        {
            await publisherRepository.CreateAsync(publisher);
        }

        public async Task Update(Publisher publisher)
        {
            await publisherRepository.UpdateAsync(publisher);
        }

        public async Task Delete(int id)
        {
            await publisherRepository.DeleteByIdAsync(id);
        }
    }
}

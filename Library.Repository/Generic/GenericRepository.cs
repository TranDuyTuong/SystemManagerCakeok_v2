using Library.DomainData.DataEF;
using Library.InterfaceRepository.IGeneric;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository.Generic
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ContextDBCakeOk context;
        public GenericRepository(ContextDBCakeOk _context)
        {
            context = _context;
        }

        public void Add(T entity)
        {
             context.Add(entity);
        }
        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public async Task<T> Get(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public async void SaveChangeAsync()
        {
            await context.SaveChangesAsync();
        }

        public async void Insert(IEnumerable<T> entity)
        {
            foreach (var entitys in entity)
            {
                await context.Set<T>().AddAsync(entitys);
            }

        }

        public async Task<T> GetGuild(Guid id)
        {
            return await context.Set<T>().FindAsync(id);
        }

    }
}

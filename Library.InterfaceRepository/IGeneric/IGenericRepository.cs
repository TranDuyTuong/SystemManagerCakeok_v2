using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.InterfaceRepository.IGeneric
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<T> GetGuild(Guid id);
        List<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Save();
        void SaveChangeAsync();
        void Insert(IEnumerable<T> entity);

    }
}

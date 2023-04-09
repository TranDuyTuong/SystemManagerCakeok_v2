using Library.DataTable.TableCake;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Cake_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class CakeImageRepository : GenericRepository<T_CakeImage>, ICakeImageRepository
    {
        public CakeImageRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

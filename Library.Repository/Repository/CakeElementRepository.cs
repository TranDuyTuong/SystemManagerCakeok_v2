using Library.DataTable.TableCake;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Cake_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class CakeElementRepository : GenericRepository<T_CakeElement>, ICakeElementRepository
    {
        public CakeElementRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

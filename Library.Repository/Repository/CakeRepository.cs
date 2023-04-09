using Library.DataTable.TableCake;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Cake_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class CakeRepository : GenericRepository<T_Cake>, ICakeRepository
    {
        public CakeRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

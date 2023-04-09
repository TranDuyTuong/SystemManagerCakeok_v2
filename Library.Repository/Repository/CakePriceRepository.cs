using Library.DataTable.TableCake;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Cake_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class CakePriceRepository : GenericRepository<T_CakePrice>, ICakePriceRepository
    {
        public CakePriceRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

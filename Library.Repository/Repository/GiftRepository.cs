using Library.DataTable.TableCake;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Cake_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class GiftRepository : GenericRepository<T_Gift>, IGiftRepository
    {
        public GiftRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

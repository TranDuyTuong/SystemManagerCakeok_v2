using Library.DataTable.TableOrder;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Order_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class CancelOrderRepository : GenericRepository<T_CancelOrder>, ICancelOrderRepository
    {
        public CancelOrderRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

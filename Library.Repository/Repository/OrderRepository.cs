using Library.DataTable.TableOrder;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Order_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class OrderRepository : GenericRepository<T_Order>, IOrderRepository
    {
        public OrderRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

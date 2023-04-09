using Library.DataTable.TableOrder;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Order_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class OrderDetailRepository : GenericRepository<T_OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

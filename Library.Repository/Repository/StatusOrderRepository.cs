using Library.DataTable.TableOrder;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Order_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class StatusOrderRepository : GenericRepository<T_StatusOrder>, IStatusOrderRepository
    {
        public StatusOrderRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

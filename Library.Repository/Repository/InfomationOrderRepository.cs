using Library.DataTable.TableOrder;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Order_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class InfomationOrderRepository : GenericRepository<T_InfomationOrder>, IinfomationOrderRepository
    {
        public InfomationOrderRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

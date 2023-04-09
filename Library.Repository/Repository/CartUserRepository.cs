using Library.DataTable.TableOrder;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Order_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class CartUserRepository : GenericRepository<T_CartUser>, ICartUserRepository
    {
        public CartUserRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

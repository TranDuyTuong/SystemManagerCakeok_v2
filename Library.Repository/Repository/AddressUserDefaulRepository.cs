using Library.DataTable.TableOrder;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Order_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class AddressUserDefaulRepository : GenericRepository<T_AddressUserDefaul>, IAddressUserDefaulRepository
    {
        public AddressUserDefaulRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

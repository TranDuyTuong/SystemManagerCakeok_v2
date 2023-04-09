using Library.DataTable.TableOrder;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Order_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class TypeAddressRepository : GenericRepository<T_TypeAddress>, ITypeAddressRepository
    {
        public TypeAddressRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

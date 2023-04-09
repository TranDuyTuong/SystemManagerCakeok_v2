using Library.DataTable.TableOrder;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Order_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class TypePayRepository : GenericRepository<T_TypePay>, ITypePayRepository
    {
        public TypePayRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

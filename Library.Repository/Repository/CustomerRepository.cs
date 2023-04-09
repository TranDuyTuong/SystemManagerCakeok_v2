using Library.DataTable.TableUser;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.User_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class CustomerRepository : GenericRepository<T_Customer>, ICustomerRepository
    {
        public CustomerRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

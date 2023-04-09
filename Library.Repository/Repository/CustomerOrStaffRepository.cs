using Library.DataTable.TableUser;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.User_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class CustomerOrStaffRepository : GenericRepository<T_CustomerOrStaff>, ICustomerOrStaffRepository
    {
        public CustomerOrStaffRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

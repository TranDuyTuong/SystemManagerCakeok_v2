using Library.DataTable.TableRole;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Role_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class UserRoleRepository : GenericRepository<T_UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

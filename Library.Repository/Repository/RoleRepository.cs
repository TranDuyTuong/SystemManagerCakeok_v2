using Library.DataTable.TableRole;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Role_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class RoleRepository : GenericRepository<T_Role>, IRoleRepository
    {
        public RoleRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

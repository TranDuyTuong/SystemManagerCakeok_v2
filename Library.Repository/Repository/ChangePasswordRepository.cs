using Library.DataTable.TableUser;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.User_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class ChangePasswordRepository : GenericRepository<T_ChangePassword>, IChangePasswordRepository
    {
        public ChangePasswordRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

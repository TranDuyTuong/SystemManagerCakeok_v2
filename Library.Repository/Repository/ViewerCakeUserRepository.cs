using Library.DataTable.TableUser;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.User_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class ViewerCakeUserRepository : GenericRepository<T_ViewerCakeUser>, IViewerCakeUserRepository
    {
        public ViewerCakeUserRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

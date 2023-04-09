using Library.DataTable.TableUser;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.User_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class HistorySeachUserRepository : GenericRepository<T_HistorySeachUser>, IHistorySeachUserRepository
    {
        public HistorySeachUserRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

using Library.DataTable.TableUser;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.User_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class MarriageRepository : GenericRepository<T_Marriage>, IMarriageRepository
    {
        public MarriageRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

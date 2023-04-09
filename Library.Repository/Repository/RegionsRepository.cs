using Library.DataTable.TableBranch;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Branch_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class RegionsRepository : GenericRepository<T_Regions>, IRegionsRepository
    {
        public RegionsRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

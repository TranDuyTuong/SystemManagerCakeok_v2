using Library.DataTable.TableBranch;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Branch_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class BranchRepository : GenericRepository<T_Branch>, IBranchRepository
    {
        public BranchRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

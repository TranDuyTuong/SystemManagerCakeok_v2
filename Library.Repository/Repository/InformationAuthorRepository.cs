using Library.DataTable.TableInformationAuthor;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.InformationAuthor_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class InformationAuthorRepository : GenericRepository<T_InformationAuthor>, IinformationAuthorRepository
    {
        public InformationAuthorRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

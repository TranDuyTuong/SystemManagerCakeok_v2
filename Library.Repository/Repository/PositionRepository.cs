using Library.DataTable.TableInformationAuthor;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.InformationAuthor_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class PositionRepository : GenericRepository<T_Position>, IPositionRepository
    {
        public PositionRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

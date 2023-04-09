using Library.DataTable.TableCakeCustom;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.CakeCustom_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class StatusIdeaRepository : GenericRepository<T_StatusIdea>, IStatusIdeaRepository
    {
        public StatusIdeaRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

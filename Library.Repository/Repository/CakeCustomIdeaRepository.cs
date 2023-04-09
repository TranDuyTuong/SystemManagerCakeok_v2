using Library.DataTable.TableCakeCustom;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.CakeCustom_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class CakeCustomIdeaRepository : GenericRepository<T_CakeCustomIdea>, ICakeCustomIdeaRepository
    {
        public CakeCustomIdeaRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

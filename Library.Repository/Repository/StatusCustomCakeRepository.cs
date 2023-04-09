using Library.DataTable.TableCakeCustom;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.CakeCustom_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class StatusCustomCakeRepository : GenericRepository<T_StatusCustomCake>, IStatusCustomCakeRepository
    {
        public StatusCustomCakeRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

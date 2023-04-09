using Library.DataTable.TableCakeCustom;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.CakeCustom_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class BillCakeCustomRepository : GenericRepository<T_BillCakeCustom>, IBillCakeCustomRepository
    {
        public BillCakeCustomRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

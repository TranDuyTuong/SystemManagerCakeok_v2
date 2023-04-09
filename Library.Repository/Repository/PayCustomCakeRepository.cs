using Library.DataTable.TableCakeCustom;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.CakeCustom_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class PayCustomCakeRepository : GenericRepository<T_PayCustomCake>, IPayCustomCakeRepository
    {
        public PayCustomCakeRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

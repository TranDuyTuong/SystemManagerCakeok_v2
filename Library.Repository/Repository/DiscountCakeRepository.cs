using Library.DataTable.TableCake;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Cake_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class DiscountCakeRepository : GenericRepository<T_DiscountCake>, IDiscountCakeRepository
    {
        public DiscountCakeRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

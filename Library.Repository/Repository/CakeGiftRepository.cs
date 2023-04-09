using Library.DataTable.TableCake;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Cake_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class CakeGiftRepository : GenericRepository<T_CakeGift>, ICakeGiftRepository
    {
        public CakeGiftRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

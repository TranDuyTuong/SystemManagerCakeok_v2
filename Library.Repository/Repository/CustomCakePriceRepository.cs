using Library.DataTable.TableCakeCustom;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.CakeCustom_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class CustomCakePriceRepository : GenericRepository<T_CustomCakePrice>, ICustomCakePriceRepository
    {
        public CustomCakePriceRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

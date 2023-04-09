using Library.DataTable.TableCakeCustom;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.CakeCustom_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class UrlManagerCustomCakeRepository : GenericRepository<T_UrlManagerCustomCake>, IUrlManagerCustomCakeRepository
    {
        public UrlManagerCustomCakeRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

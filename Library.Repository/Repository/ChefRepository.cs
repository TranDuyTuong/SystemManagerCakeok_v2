using Library.DataTable.TableChef;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Chef_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class ChefRepository : GenericRepository<T_Chef>, IChefRepository
    {
        public ChefRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

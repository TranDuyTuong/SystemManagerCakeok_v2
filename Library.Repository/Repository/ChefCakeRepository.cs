using Library.DataTable.TableChef;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Chef_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class ChefCakeRepository : GenericRepository<T_ChefCake>, IChefCakeRepository
    {
        public ChefCakeRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

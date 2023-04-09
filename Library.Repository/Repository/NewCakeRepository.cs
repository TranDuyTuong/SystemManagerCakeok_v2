using Library.DataTable.TableCake;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Cake_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class NewCakeRepository : GenericRepository<T_NewCake>, INewCakeRepository
    {
        public NewCakeRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

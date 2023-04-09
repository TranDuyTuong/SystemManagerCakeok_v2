using Library.DataTable.TableCake;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Cake_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class SmellCakeRepository : GenericRepository<T_SmellCake>, ISmellCakeRepository
    {
        public SmellCakeRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

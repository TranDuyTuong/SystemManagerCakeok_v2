using Library.DataTable.TableCake;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Cake_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class KindCakeRepository : GenericRepository<T_KindCake>, IKindCakeRepository
    {
        public KindCakeRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

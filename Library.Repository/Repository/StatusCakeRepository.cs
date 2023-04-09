using Library.DataTable.TableCake;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Cake_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class StatusCakeRepository : GenericRepository<T_StatusCake>, IStatusCakeRepository
    {
        public StatusCakeRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

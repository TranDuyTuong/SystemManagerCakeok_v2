using Library.DataTable.TableCake;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Cake_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class TypeCakeRepository : GenericRepository<T_TypeCake>, ITypeCakeRepository
    {
        public TypeCakeRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

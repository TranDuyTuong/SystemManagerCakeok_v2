using Library.DataTable.TableCakeCustom;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.CakeCustom_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class TypePayCustomCakeRepository : GenericRepository<T_TypePayCustomCake>, ITypePayCustomCakeRepository
    {
        public TypePayCustomCakeRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

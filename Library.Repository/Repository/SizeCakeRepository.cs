using Library.DataTable.TableCakeCustom;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.CakeCustom_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class SizeCakeRepository : GenericRepository<T_SizeCake>, ISizeCakeRepository
    {
        public SizeCakeRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

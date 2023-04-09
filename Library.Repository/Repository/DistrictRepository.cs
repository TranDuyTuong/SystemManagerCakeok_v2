using Library.DataTable.TableUser;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.User_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class DistrictRepository : GenericRepository<T_District>, IDistrictRepository
    {
        public DistrictRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

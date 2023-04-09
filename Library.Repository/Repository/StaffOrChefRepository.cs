using Library.DataTable.TableStaff;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Staff_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class StaffOrChefRepository : GenericRepository<T_StaffOrChef>, IStaffOrChefRepository
    {
        public StaffOrChefRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

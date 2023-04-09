using Library.DataTable.TableStaff;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Staff_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class StaffRepository : GenericRepository<T_Staff>, IStaffRepository
    {
        public StaffRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

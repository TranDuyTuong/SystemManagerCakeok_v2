using Library.ViewModel.Admin.V_Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ServiceAdmin.ServiceAdminInjection.Role
{
    public interface Iroles
    {
        //get all role 
        List<GetAllRole> GetAllRoles();

        //create role
        NotificationRole CreateRole(CreateRole request);

        //Detail Role
        Task<DetailRole> DetailRole(Guid IdRole);
    }
}

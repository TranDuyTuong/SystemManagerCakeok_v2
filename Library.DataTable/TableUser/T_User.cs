using Library.DataTable.TableStaff;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableUser
{
    public class T_User: IdentityUser<Guid>
    {
        public Guid IDAccount { get; set; }
        public string PassWord { get; set; }
        public DateTime CreateDate { get; set; }

        public int IDCustomerOrStaff { get; set; }
        public T_CustomerOrStaff t_CustomerOrStaff { get; set; }


        public List<T_Staff> t_Staffs { get; set; }
        public List<T_Customer> t_Customers { get; set; }
    }
}

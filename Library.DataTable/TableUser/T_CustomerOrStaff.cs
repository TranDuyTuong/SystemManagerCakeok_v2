using Library.DataTable.TableStaff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableUser
{
    public class T_CustomerOrStaff
    {
        public int IDCustomerOrStaff { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }

        public List<T_Staff> t_Staffs { get; set; }
        public List<T_Customer> t_Customers { get; set; }
        public List<T_User> t_Users { get; set; }
    }
}

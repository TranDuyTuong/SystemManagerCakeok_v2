using Library.DataTable.TableStaff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableUser
{
    public class T_Gender
    {
        public int IDGender { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public List<T_Staff> t_Staffs { get; set; }
        public List<T_Customer> t_Customers { get; set; }
    }
}

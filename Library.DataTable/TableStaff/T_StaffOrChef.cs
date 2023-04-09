using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableStaff
{
    public class T_StaffOrChef
    {
        public Guid IDStaffOrChef { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }

        public List<T_Staff> t_Staffs { get; set; }
    }
}

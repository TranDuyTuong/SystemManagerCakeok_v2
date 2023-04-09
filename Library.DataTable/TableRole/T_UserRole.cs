using Library.DataTable.TableStaff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableRole
{
    public class T_UserRole
    {
        public int IDUserRole { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }

        public Guid IDRole { get; set; }
        public T_Role t_Role { get; set; }
        public Guid IDStaff { get; set; }
        public T_Staff t_Staff { get; set; }
    }
}

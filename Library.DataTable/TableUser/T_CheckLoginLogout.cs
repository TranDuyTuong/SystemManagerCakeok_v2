using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableUser
{
    public class T_CheckLoginLogout
    {
        public DateTime WorkingStart { get; set; }
        public Guid IDStaff { get; set; }
        public string DateStart { get; set; }
        public string TimeStart { get; set; }
        public DateTime? WorkingEnd { get; set; }
        public string DateEnd { get; set; }
        public string TimeEnd { get; set; }
        public int HourWoking { get; set; }

    }
}

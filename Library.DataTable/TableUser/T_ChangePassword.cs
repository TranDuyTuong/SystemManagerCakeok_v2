using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableUser
{
    public class T_ChangePassword
    {
        public Guid IDChange { get; set; }
        public string EmailRequest { get; set; }
        public DateTime DateRequest { get; set; }
    }
}

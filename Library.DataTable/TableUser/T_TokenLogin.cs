using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableUser
{
    public class T_TokenLogin
    {
        public int IDToken { get; set; }
        public DateTime CreateDate { get; set; }
        public string TokenString { get; set; }
        public string EmailLogin { get; set; }
    }
}

using Library.DataTable.TableCake;
using Library.DataTable.TableUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableOrder
{
    public class T_CartUser
    {
        public Guid IDCart { get; set; }
        public DateTime CreateDate { get; set; }
        public int Amount { get; set; }

        public Guid IDUser { get; set; }
        public T_Customer t_Customer { get; set; }

        public Guid IDCake { get; set; }
        public T_Cake t_Cake { get; set; }
    }
}

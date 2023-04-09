using Library.DataTable.TableCake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableUser
{
    public class T_ViewerCakeUser
    {
        public int ID { get; set; }
        public Guid IDUser { get; set; }
        public T_Customer t_Customer { get; set; }

        public Guid IDCake { get; set; }
        public T_Cake t_Cake { get; set; }

        public int Amount { get; set; }
    }
}

using Library.DataTable.TableCake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableChef
{
    public class T_ChefCake
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }

        public Guid IDChef { get; set; }
        public T_Chef t_Chef { get; set; }

        public Guid IDCake { get; set; }
        public T_Cake t_Cake { get; set; }
    }
}

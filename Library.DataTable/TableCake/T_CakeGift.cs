using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableCake
{
    public class T_CakeGift
    {
        public Guid ID { get; set; }
        public Guid IDCake { get; set; }
        public T_Cake t_Cake { get; set; }

        public Guid IDGift { get; set; }
        public T_Gift t_Gift { get; set; }

        public DateTime CreateDate { get; set; }
    }
}

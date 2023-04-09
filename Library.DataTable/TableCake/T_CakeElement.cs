using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableCake
{
    public class T_CakeElement
    {
        public int IDElement { get; set; }
        public string Flour { get; set; }
        public string Sugar { get; set; }
        public string Egg { get; set; }
        public string Salt { get; set; }
        public string Fruit { get; set; }
        public string ElementOther { get; set; }
        public DateTime CreateDate { get; set; }

        public List<T_Cake> t_Cakes { get; set; }
    }
}

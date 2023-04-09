using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableCake
{
    public class T_DiscountCake
    {
        public int IDDiscount { get; set; }
        public int PercentReduction { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
        public string NameDiscount { get; set; }

        public List<T_Cake> t_Cakes { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableCake
{
    public class T_CakePrice
    {
        public Guid IDPrice { get; set; }
        public double Price { get; set; }
        public double? PriceDiscount { get; set; }

        public List<T_Cake> t_Cakes { get; set; }
    }
}

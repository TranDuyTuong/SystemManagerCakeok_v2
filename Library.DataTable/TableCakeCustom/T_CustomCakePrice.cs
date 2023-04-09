using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableCakeCustom
{
    public class T_CustomCakePrice
    {
        public Guid IDPriceCustom { get; set; }
        public double Price { get; set; }
        public DateTime CreateDate { get; set; }


        public Guid IDCustom { get; set; }
        public T_CustomCake t_CustomCake { get; set; }

        //
        public List<T_BillCakeCustom> t_BillCakeCustoms { get; set; }
    }
}

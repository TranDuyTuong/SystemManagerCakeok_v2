using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableCakeCustom
{
    public class T_PayCustomCake
    {
        public int IDPay { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }

        public List<T_BillCakeCustom> t_BillCakeCustom { get; set; }
        public List<T_CustomCake> t_CustomCakes { get; set; }
    }
}

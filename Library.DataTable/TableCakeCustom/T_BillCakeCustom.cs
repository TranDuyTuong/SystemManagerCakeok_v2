using Library.DataTable.TableStaff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableCakeCustom
{
    public class T_BillCakeCustom
    {
        public Guid IDBill { get; set; }
        public DateTime CreateDate { get; set; }
        public int AmountCake { get; set; }
        public double TotalPrice { get; set; }

        public Guid IDPriceCustom { get; set; }
        public T_CustomCakePrice t_CustomCakePrice { get; set; }

        public int IDPay { get; set; }
        public T_PayCustomCake t_PayCustomCake { get; set; }

        public int IDTypePay { get; set; }
        public T_TypePayCustomCake t_TypePayCustomCake { get; set; }

        public Guid IDCustom { get; set; }
        public T_CustomCake t_CustomCake { get; set; }

        public Guid IDStaff { get; set; }
        public T_Staff t_Staff { get; set; }
    }
}

using Library.DataTable.TableCake;
using Library.DataTable.TableStaff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableOrder
{
    public class T_OrderDetail
    {
        public Guid ID { get; set; }
        public int Quatity { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }

        public Guid IDStaff { get; set; }
        public T_Staff t_Staff { get; set; }

        public Guid IDOrder { get; set; }
        public T_Order t_Order { get; set; }

        public Guid IDCake { get; set; }
        public T_Cake t_Cake { get; set; }

        public Guid IDGift { get; set; }
        public T_Gift t_Gift { get; set; }

        public int IDSmell { get; set; }
        public T_SmellCake t_SmellCake { get; set; }
    }
}

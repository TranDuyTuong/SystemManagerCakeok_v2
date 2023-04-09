using Library.DataTable.TableChef;
using Library.DataTable.TableUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableCakeCustom
{
    public class T_CustomCake
    {
        public Guid IDCustom { get; set; }
        public string NoCustom { get; set; }
        public string NameCustom { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public int Amount { get; set; }

        public Guid IDUser { get; set; }
        public T_Customer t_Customer { get; set; }

        public int IDStatus { get; set; }
        public T_StatusCustomCake t_StatusCustomCake { get; set; }

        public int IDPay { get; set; }
        public T_PayCustomCake t_PayCustomCake { get; set; }

        public int IDIdea { get; set; }
        public T_CakeCustomIdea t_CakeCustomIdea { get; set; }

        public Guid IDChef { get; set; }
        public T_Chef t_Chef { get; set; }


        public List<T_BillCakeCustom> t_BillCakeCustom { get; set; }
        public List<T_CustomCakePrice> t_CustomCakePrices { get; set; }
    }
}

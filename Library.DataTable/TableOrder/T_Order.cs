using Library.DataTable.TableUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableOrder
{
    public class T_Order
    {
        public Guid IDOrder { get; set; }
        public DateTime CreateDate { get; set; }
        public bool UseVocher { get; set; }
        public bool CancelOrder { get; set; }
        public int? PercentReduction { get; set; }

        public Guid IDInfomationOrder { get; set; }
        public T_InfomationOrder t_InfomationOrder { get; set; }

        public Guid IDUser { get; set; }
        public T_Customer t_Customer { get; set; }

        public Guid IDPay { get; set; }
        public T_TypePay t_TypePay { get; set; }

        public int IDStatusOrder { get; set; }
        public T_StatusOrder t_StatusOrder { get; set; }


        public List<T_OrderDetail> t_OrderDetails { get; set; }

    }
}

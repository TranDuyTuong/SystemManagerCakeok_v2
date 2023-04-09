using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableOrder
{
    public class T_StatusOrder
    {
        public int IDStatusOrder { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public int PesentProgess { get; set; }
        public bool Status { get; set; }

        public List<T_Order> t_Orders { get; set; }
    }
}

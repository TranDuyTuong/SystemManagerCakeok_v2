using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableOrder
{
    public class T_CancelOrder
    {
        public Guid IDCancel { get; set; }
        public string Note { get; set; }
        public DateTime CreateDate { get; set; }

        public Guid IDOrder { get; set; }
        public T_Order t_Order { get; set; }
    }
}

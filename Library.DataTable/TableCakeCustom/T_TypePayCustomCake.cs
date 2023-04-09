using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableCakeCustom
{
    public class T_TypePayCustomCake
    {
        public int IDTypePay { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }

        public List<T_BillCakeCustom> t_BillCakeCustoms { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableCakeCustom
{
    public class T_SizeCake
    {
        public int IDSize { get; set; }
        public string NameSize { get; set; }

        public List<T_CakeCustomIdea> t_CakeCustomIdea { get; set; }
    }
}

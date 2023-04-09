using Library.DataTable.TableCakeCustom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableCake
{
    public class T_TypeCake
    {
        public Guid IDTypeCake { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }

        public List<T_Cake> t_Cakes { get; set; }
        public List<T_CakeCustomIdea> t_CakeCustomIdeas { get; set; }
    }
}

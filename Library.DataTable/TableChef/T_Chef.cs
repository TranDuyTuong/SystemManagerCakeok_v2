using Library.DataTable.TableCakeCustom;
using Library.DataTable.TableStaff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableChef
{
    public class T_Chef
    {
        public Guid IDChef { get; set; }
        public string NoChef { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }

        public Guid IDStaff { get; set; }
        public T_Staff t_Staff { get; set; }

        //
        public List<T_CustomCake> t_CustomCakes { get; set; }
        public List<T_ChefCake> t_ChefCakes { get; set; }
    }
}

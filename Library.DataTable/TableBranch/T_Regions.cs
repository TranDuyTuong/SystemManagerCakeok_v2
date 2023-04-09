using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableBranch
{
    public class T_Regions
    {
        public int IDRegion { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }

        public List<T_Branch> t_Branch { get; set; }
    }
}

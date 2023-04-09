using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableInformationAuthor
{
    public class T_Position
    {
        public int IDPosition { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }

        public List<T_InformationAuthor> t_InformationAuthors { get; set; }
    }
}

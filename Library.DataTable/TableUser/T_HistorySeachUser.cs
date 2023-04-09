using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableUser
{
    public class T_HistorySeachUser
    {
        public Guid IdSeach { get; set; }
        public string SeachName { get; set; }
        public DateTime CreateDate { get; set; }

        //key
        public Guid IDUser { get; set; }
        public T_Customer t_Customer { get; set; }
    }
}

using Library.DataTable.TableUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableCakeCustom
{
    public class T_NotificationCustomCake
    {
        public int IDNotification { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        //key
        public int IDIdea { get; set; }
        public T_CakeCustomIdea t_CakeCustomIdea { get; set; }

        public Guid IDUser { get; set; }
        public T_Customer t_Customer { get; set; }
    }
}

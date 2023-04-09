using Library.DataTable.TableUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableVocher
{
    public class T_HistoryUserGetVocher
    {
        public Guid ID { get; set; }
        public DateTime CreateDate { get; set; }
        public string Note { get; set; }
        public bool StatusUseVocher { get; set; }


        public Guid IDUser { get; set; }
        public T_Customer t_Customer { get; set; }

        public Guid IDVocher { get; set; }
        public T_Vocher t_Vocher { get; set; }
    }
}

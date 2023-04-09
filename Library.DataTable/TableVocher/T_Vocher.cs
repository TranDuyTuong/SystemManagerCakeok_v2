using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableVocher
{
    public class T_Vocher
    {
        public Guid IDVocher { get; set; }
        public string NameVocher { get; set; }
        public string Code { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int PercenReduction { get; set; }

        public List<T_HistoryUserGetVocher> t_HistoryUserGetVocher { get; set; }
        public List<T_HistoryUseVocher> t_HistoryUseVochers { get; set; }
    }
}

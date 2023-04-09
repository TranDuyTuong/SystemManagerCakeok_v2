using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableRotationLuck
{
    public class T_GiftLuck
    {
        public Guid IDLuck { get; set; }
        public string NameGift { get; set; }
        public DateTime CreateDate { get; set; }
        public byte[] ContentImage { get; set; }
        public string MimeType { get; set; }
        public string NameImage { get; set; }
        public string TypeFile { get; set; }
        public bool Status { get; set; }

        public List<T_HistoryGetGiftUserRotaionLuck> t_HistoryGetGiftUserRotaionLucks { get; set; }
        public List<T_RotationLuck> t_RotationLucks { get; set; }
    }
}

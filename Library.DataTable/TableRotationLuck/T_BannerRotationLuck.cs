using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableRotationLuck
{
    public class T_BannerRotationLuck
    {
        public int IDBackRound { get; set; }
        public string NameImage { get; set; }
        public byte[] ContentFile { get; set; }
        public string MimeType { get; set; }
        public string TypeFile { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
    }
}

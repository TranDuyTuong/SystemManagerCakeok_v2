using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableBanner
{
    public class T_ImageBannerWeb
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public byte[] ContentFile { get; set; }
        public string MimeType { get; set; }
        public string TypeImage { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
    }
}

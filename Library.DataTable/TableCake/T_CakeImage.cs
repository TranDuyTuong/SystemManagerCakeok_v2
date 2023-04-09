using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableCake
{
    public class T_CakeImage
    {
        public Guid IDImage { get; set; }
        public string NameImage { get; set; }
        public string TypeImage { get; set; }
        public string MimeType { get; set; }
        public byte[] Image { get; set; }
        public DateTime CreateDate { get; set; }
        public bool MainImage { get; set; }

        public Guid IDCake { get; set; }
        public T_Cake t_Cake { get; set; }
    }
}

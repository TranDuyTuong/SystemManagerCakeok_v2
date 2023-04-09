using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableCakeCustom
{
    public class T_ImageCustomIdea
    {
        public Guid IDImageCustom { get; set; }
        public string Name { get; set; }
        public string TypeImage { get; set; }
        public string MimeType { get; set; }
        public byte[] FileContent { get; set; }
        public DateTime CreateDate { get; set; }

        //key
        public int IDIdea { get; set; }
        public T_CakeCustomIdea t_CakeCustomIdea { get; set; }
    }
}

using Library.DataTable.TableOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableCake
{
    public class T_Gift
    {
        public Guid IDGift { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public byte[] Image { get; set; }
        public string NameImage { get; set; }
        public string MimeType { get; set; }
        public string TypeFile { get; set; }

        //
        public List<T_CakeGift> t_CakeGifts { get; set; }
        public List<T_OrderDetail> t_OrderDetails { get; set; }
    }
}

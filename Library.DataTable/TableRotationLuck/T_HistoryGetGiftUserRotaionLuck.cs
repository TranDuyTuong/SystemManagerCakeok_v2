using Library.DataTable.TableUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableRotationLuck
{
    public class T_HistoryGetGiftUserRotaionLuck
    {
        public Guid ID { get; set; }
        public DateTime CreateDate { get; set; }

        public Guid IDLuck { get; set; }
        public T_GiftLuck t_GiftLuck { get; set; }

        public Guid IDUser { get; set; }
        public T_Customer t_Customer { get; set; }

    }
}

using Library.DataTable.TableCake;
using Library.DataTable.TableUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableRating
{
    public class T_Rating
    {
        public int ID { get; set; }
        public int Rating { get; set; }
        public DateTime CreateDate { get; set; }

        public Guid IDUser { get; set; }
        public T_Customer t_Customer { get; set; }

        public Guid IDCake { get; set; }
        public T_Cake t_Cake { get; set; }

    }
}

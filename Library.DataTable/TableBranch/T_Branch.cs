using Library.DataTable.TableOrder;
using Library.DataTable.TableUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableBranch
{
    public class T_Branch
    {
        public Guid IDBrach { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string TimeWorking { get; set; }

        public int IDRegion { get; set; }
        public T_Regions t_Regions { get; set; }

        public int IDCity { get; set; }
        public T_City t_City { get; set; }

        public int IDDistrict { get; set; }
        public T_District t_District { get; set; }


        public List<T_InfomationOrder> t_InfomationOrders { get; set; }
    }
}

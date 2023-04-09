using Library.DataTable.TableBranch;
using Library.DataTable.TableOrder;
using Library.DataTable.TableStaff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableUser
{
    public class T_City
    {
        public int IDCity { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public List<T_Branch> t_Branches { get; set; }
        public List<T_District> t_Districts { get; set; }
        public List<T_AddressUserDefaul> t_AddressUserDefauls { get; set; }
        public List<T_InfomationOrder> t_InfomationOrders { get; set; }
        public List<T_Staff> t_Staffs { get; set; }
        public List<T_Customer> t_Customers { get; set; }
    }
}

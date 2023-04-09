using Library.DataTable.TableBranch;
using Library.DataTable.TableUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableOrder
{
    public class T_InfomationOrder
    {
        public Guid IDInfomationOrder { get; set; }
        public string NameCustomer { get; set; }
        public string EmailCustomer { get; set; }
        public string PhoneCustomer { get; set; }
        public string Address { get; set; }
        public DateTime ExpecteDate { get; set; }
        public string NoteCustomer { get; set; }

        public int IDCity { get; set; }
        public T_City t_City { get; set; }

        public int IDDistrict { get; set; }
        public T_District t_District { get; set; }

        public Guid IDBrach { get; set; }
        public T_Branch t_Branch { get; set; }


        public List<T_Order> t_Orders { get; set; }
    }
}

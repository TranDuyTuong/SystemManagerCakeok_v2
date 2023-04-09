using Library.DataTable.TableUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableOrder
{
    public class T_AddressUserDefaul
    {
        public Guid ID { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }

        public int IDTypeAddress { get; set; }
        public T_TypeAddress t_TypeAddress { get; set; }

        public int IDCity { get; set; }
        public T_City t_City { get; set; }

        public int IDDistrict { get; set; }
        public T_District t_District { get; set; }

        public Guid IDUser { get; set; }
        public T_Customer t_Customer { get; set; }
    }
}

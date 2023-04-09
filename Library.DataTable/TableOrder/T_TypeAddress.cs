using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableOrder
{
    public class T_TypeAddress
    {
        public int IDTypeAddress { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }

        public List<T_AddressUserDefaul> t_AddressUserDefaul { get; set; }
    }
}

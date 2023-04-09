using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModel.Admin.V_District
{
    public class GetAllDistrict
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public int IdCity { get; set; }
        public string NameCity { get; set; }
    }
}

using Library.ViewModel.Admin.V_District;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModel.Admin.V_City
{
    public class DetailCity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public List<GetAllDistrict> L_District { get; set; } = new List<GetAllDistrict>();
        public int TotalDistrict { get; set; }
    }
}

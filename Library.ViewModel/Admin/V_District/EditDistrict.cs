using Library.ViewModel.Admin.V_City;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModel.Admin.V_District
{
    public class EditDistrict
    {
        public int IdDitrict { get; set; }
        public string NameDistrict { get; set; }
        public int IdCity { get; set; }
        public string NameCity { get; set; }
        public List<GetAllCitys> L_City { get; set; }
    }
}

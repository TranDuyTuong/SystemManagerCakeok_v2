using Library.ViewModel.Admin.V_City;
using Library.ViewModel.Admin.V_Gender;
using Library.ViewModel.Admin.V_Marriage;
using Library.ViewModel.Admin.V_Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModel.Admin.V_Account
{
    public class GetInfoCreate
    {
        public List<GetAllCitys> L_City { get; set; } = new List<GetAllCitys>();
        public List<GetAllGender> L_Gender { get; set; } = new List<GetAllGender>();
        public List<GetAllMarriage> L_Marriage { get; set; } = new List<GetAllMarriage>();
        public List<GetAllRole> L_Role { get; set; } = new List<GetAllRole>();
        public List<GetAllStaffOrChef> L_StaffChef { get; set; } = new List<GetAllStaffOrChef>();
    }
}

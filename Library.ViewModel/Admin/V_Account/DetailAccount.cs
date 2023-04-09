using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModel.Admin.V_Account
{
    public class DetailAccount
    {
        public Guid IdAccount { get; set; }
        public string CreateDate { get; set; }
        public string CreateTime { get; set; }
        public string Password { get; set; }
        public int IDCustomerOrStaff { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Guid IdStaffOrChef { get; set; }
        public Guid IdStaff { get; set; }
        public string NameStaffOrChef { get; set; }
        public string NameCustomerOfStaff { get; set; }
    }
}

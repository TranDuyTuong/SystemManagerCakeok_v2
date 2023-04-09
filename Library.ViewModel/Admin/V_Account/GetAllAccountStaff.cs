using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModel.Admin.V_Account
{
    public class GetAllAccountStaff
    {
        public Guid IdAccount { get; set; }
        public string CreateDate { get; set; }
        public string TimeCreate { get; set; }
        public int IDCustomerOrStaff { get; set; }
        public Guid IdStaff { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
    }
}

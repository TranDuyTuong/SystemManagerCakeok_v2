using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModel.Admin.V_Account
{
    public class CreateAccount
    {
        public DateTime CreateDate { get; set; } //
        public string Password { get; set; }
        public int IDCustomerOrStaff { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string EmailConfirmed { get; set; }
        public string PhoneNumber { get; set; }

        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public byte[] ContentFile { get; set; }
        public string FileName { get; set; }
        public string TypeImage { get; set; }
        public string MimeType { get; set; }
        public int IdMarriage { get; set; }
        public int IdAccount { get; set; } //
        public int IdCity { get; set; }
        public int IdDistrict { get; set; }
        public int IdGender { get; set; }
        public Guid IdStaffOrChef { get; set; }
        public Guid IdRole { get; set; }
    }
}

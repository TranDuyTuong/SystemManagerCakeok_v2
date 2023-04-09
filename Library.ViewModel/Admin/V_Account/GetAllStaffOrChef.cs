using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModel.Admin.V_Account
{
    public class GetAllStaffOrChef
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
    }
}

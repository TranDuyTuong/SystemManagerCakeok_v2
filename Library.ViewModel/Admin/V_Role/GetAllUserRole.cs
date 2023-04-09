using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModel.Admin.V_Role
{
    public class GetAllUserRole
    {
        public int IdUserRole { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
        public Guid IdRole { get; set; }
        public Guid IdStaff { get; set; }
        public string NameStaff { get; set; }
        public byte[] ContentFile { get; set; }
        public string FileName { get; set; }
        public string TypeImage { get; set; }
    }
}

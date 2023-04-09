using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModel.Admin.V_Role
{
    public class DetailRole
    {
        public Guid IdRole { get; set; }
        public string NameRole { get; set; }
        public string Symbol { get; set; }
        public DateTime CreateDate { get; set; }
        public List<GetAllUserRole> L_UserRole { get; set; } = new List<GetAllUserRole>();
    }
}

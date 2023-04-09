using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModel.Admin.V_Role
{
    public class GetAllRole
    {
        public Guid IDRole { get; set; }
        public string NameRole { get; set; }
        public string Symbol { get; set; }
        public DateTime CreateDate { get; set; }
        public string Discription { get; set; }

    }
}

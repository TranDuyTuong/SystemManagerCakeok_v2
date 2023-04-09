using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableRole
{
    public class T_Role: IdentityRole<Guid>
    {
        public Guid IDRole { get; set; }
        public string NameRole { get; set; }
        public string Symbol { get; set; }
        public DateTime CreateDate { get; set; }
        public string Discripttion { get; set; }
        public List<T_UserRole> t_UserRoles { get; set; }
    }
}

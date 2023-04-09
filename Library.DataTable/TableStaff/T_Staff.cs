using Library.DataTable.TableCakeCustom;
using Library.DataTable.TableChef;
using Library.DataTable.TableOrder;
using Library.DataTable.TableRole;
using Library.DataTable.TableUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableStaff
{
    public class T_Staff
    {
        public Guid IDStaff { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string IDCode { get; set; }
        public byte[] ContentFile { get; set; }
        public string FileName { get; set; }
        public string TypeImage { get; set; }
        public string MimeType { get; set; }
        public DateTime CreateDate { get; set; }


        public int IDMarriage { get; set; }
        public T_Marriage t_Marriage { get; set; }

        public Guid IDAccount { get; set; }
        public T_User t_User { get; set; }

        public int IDCustomerOrStaff { get; set; }
        public T_CustomerOrStaff t_CustomerOrStaff { get; set; }

        public int IDCity { get; set; }
        public T_City t_City { get; set; }

        public int IDDistrict { get; set; }
        public T_District t_District { get; set; }

        public int IDGender { get; set; }
        public T_Gender t_Gender { get; set; }

        public Guid IDStaffOrChef { get; set; }
        public T_StaffOrChef t_StaffOrChef { get; set; }

        //
        public List<T_BillCakeCustom> t_BillCakeCustoms { get; set; }
        public List<T_Chef> t_Chefs { get; set; }
        public List<T_OrderDetail> t_OrderDetails { get; set; }
        public List<T_UserRole> t_UserRoles { get; set; }
    }
}

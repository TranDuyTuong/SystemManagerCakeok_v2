using Library.ViewModel.Admin.V_Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ServiceAdmin.ServiceAdminInjection.Account
{
    public interface IAccount
    {
        //get all staff or chef
        List<GetAllStaffOrChef> GetAllStaffOrChef();

        //create staff or chef
        NotificationAccount CreateStaffOrChef(string Name, bool Status);

        //Get All Account
        List<GetAllAccountStaff> GetAllAccount();

        //Get Info Create Account
        GetInfoCreate GetInfoCreateAccount();

        //create account
        Task<NotificationAccount> CreateAccount(CreateAccount request);

        //Detail Account
        Task<DetailAccount> DetailAccount(Guid IdAccount);
    }
}

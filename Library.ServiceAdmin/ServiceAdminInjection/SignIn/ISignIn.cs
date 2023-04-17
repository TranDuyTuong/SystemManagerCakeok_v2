using Library.ViewModel.Admin.V_SignIn;
using Library.ViewModel.Admin.V_Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ServiceAdmin.ServiceAdminInjection.SignIn
{
    public interface ISignIn
    {
        // login admin
        Task<TokenUser> loginAdmin(V_Login request);
    }
}

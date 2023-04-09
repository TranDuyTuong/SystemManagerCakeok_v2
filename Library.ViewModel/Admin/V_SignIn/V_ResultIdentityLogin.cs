using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModel.Admin.V_SignIn
{
    public class V_ResultIdentityLogin
    {
        public string CookieName { get; set; }
        public string UserName { get; set; }
        public string RequestPath { get; set; }
        public string Token { get; set; }
    }
}

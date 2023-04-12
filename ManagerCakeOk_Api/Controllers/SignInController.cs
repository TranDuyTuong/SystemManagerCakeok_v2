using Library.ViewModel.Admin.V_SignIn;
using Library.ViewModel.Admin.V_Token;
using Microsoft.AspNetCore.Mvc;

namespace ManagerCakeOk_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SignInController : Controller
    {
        // TODO: LOGIN SYSTEM ADMIN
        [HttpPost(Name = "LoginSystemAdmin")]
        public IActionResult Login([FromForm] V_Login request)
        {
            return Ok();
        }

        // TODO: LOGOUT SYSTEM ADMIN
        [HttpPost(Name = "LogOutSystemAdmin")]
        public IActionResult Logout([FromForm] TokenUser tokenRequest)
        {
            return Ok();
        }
    }
}

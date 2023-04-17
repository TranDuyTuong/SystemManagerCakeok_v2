using Library.DataTable.TableUser;
using Library.InterfaceRepository.IUnitOfWork;
using Library.ViewModel.Admin.V_SignIn;
using Library.ViewModel.Admin.V_Token;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Library.ServiceAdmin.ServiceAdminInjection.SignIn
{
    public class SignIn : ISignIn
    {
        private readonly UserManager<T_User> _userManager;
        private readonly SignInManager<T_User> _signInManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _config;

        public SignIn(UserManager<T_User> userManager, SignInManager<T_User> signInManager, IConfiguration config, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _config = config;
            _unitOfWork = unitOfWork;
        }


        /// <summary>
        /// Login Admin
        /// </summary>
        public async Task<TokenUser> loginAdmin(V_Login request)
        {
            var result = new TokenUser();
            var user = await _userManager.FindByEmailAsync(request.gmail);
            if(user == null)
            {
                // Login Fail
                result.IdLogin = 1;
                result.status = false;
            }
            else
            {
                var loginResult = await _signInManager.PasswordSignInAsync(user, request.passWord, true, true);
                if(loginResult.Succeeded == false) {
                    // Login Fail
                    result.IdLogin = 1;
                    result.status = false;
                }
                else
                {
                    // Find Infomation of user
                    // Find Infomation Staff
                    var queryStaff = this._unitOfWork.staffRepo.GetAll();
                    var queryUserRole = this._unitOfWork.userRoleRepo.GetAll();
                    var queryRole = this._unitOfWork.roleRepo.GetAll();
                    var queryStaffOrChef = this._unitOfWork.staffOrChefRepo.GetAll();


                    var queryStaffInfo = queryStaff.FirstOrDefault( x => x.IDAccount == user.IDAccount);
                    var queryUserRoleInfo = queryUserRole.FirstOrDefault(x => x.IDStaff == queryStaffInfo.IDStaff);
                    var queryRoleInfo = queryRole.FirstOrDefault(x => x.IDRole == queryUserRoleInfo.IDRole);
                    var queryCustomerOfStaff = this._unitOfWork.customerOrStaffRepo.Get(2);

                    // Create Claim
                    var claims = new[]
                    {
                        new Claim(ClaimTypes.Email, user.Email)
                    };
                    

                }
            }
        }



    }
}

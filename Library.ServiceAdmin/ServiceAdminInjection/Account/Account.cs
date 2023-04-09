using Library.DataTable.TableRole;
using Library.DataTable.TableStaff;
using Library.DataTable.TableUser;
using Library.InterfaceRepository.IUnitOfWork;
using Library.ViewModel.Admin.V_Account;
using Library.ViewModel.Admin.V_City;
using Library.ViewModel.Admin.V_Gender;
using Library.ViewModel.Admin.V_Marriage;
using Library.ViewModel.Admin.V_Role;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ServiceAdmin.ServiceAdminInjection.Account
{
    public class Account : IAccount
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly UserManager<T_User> userManager;
        public Account(IUnitOfWork _unitOfWork, UserManager<T_User> _userManager)
        {
            unitOfWork = _unitOfWork;
            userManager = _userManager;
        }

        //create staff or chef
        public NotificationAccount CreateStaffOrChef(string Name, bool Status)
        {
            var result = new NotificationAccount();
            var FormData = new T_StaffOrChef()
            {
                IDStaffOrChef = Guid.NewGuid(),
                Name = Name,
                CreateDate = DateTime.UtcNow.AddHours(7),
                Status = Status
            };
            this.unitOfWork.staffOrChefRepo.Add(FormData);
            this.unitOfWork.Commit();
            result.Id = 1; //create success
            return result;
        }

        //get all staff or chef
        public List<GetAllStaffOrChef> GetAllStaffOrChef()
        {
            var L_StaffOrChef = new List<GetAllStaffOrChef>();
            var Query = this.unitOfWork.staffOrChefRepo.GetAll();
            foreach(var item in Query)
            {
                var data = new GetAllStaffOrChef()
                {
                    Id = item.IDStaffOrChef,
                    Name = item.Name,
                    CreateDate = item.CreateDate,
                    Status = item.Status
                };
                L_StaffOrChef.Add(data);
            }
            return L_StaffOrChef;
        }

        //Get All Account
        public List<GetAllAccountStaff> GetAllAccount()
        {
            var L_Account = new List<GetAllAccountStaff>();
            var QueryAccount = this.unitOfWork.userRepo.GetAll().Where(x=>x.IDCustomerOrStaff == 1);
            var QueryUser = this.unitOfWork.staffRepo.GetAll();
            foreach(var item in QueryAccount)
            {
                var CheckValue = QueryUser.FirstOrDefault(x => x.IDAccount == item.IDAccount);
                if(CheckValue != null)
                {
                    var Data = new GetAllAccountStaff()
                    {
                        IdAccount = item.IDAccount,
                        CreateDate = item.CreateDate.ToShortDateString(),
                        TimeCreate = item.CreateDate.ToShortTimeString(),
                        IDCustomerOrStaff = item.IDCustomerOrStaff,
                        IdStaff = CheckValue.IDStaff,
                        Fullname = CheckValue.FullName,
                        Email = item.Email
                    };
                    L_Account.Add(Data);
                }
            }
            return L_Account;
        }

        //Get Info create account
        public GetInfoCreate GetInfoCreateAccount()
        {
            var resultData = new GetInfoCreate();
            var Query_City = this.unitOfWork.cityRepo.GetAll().Where(x => x.Status == true);
            var Query_Gender = this.unitOfWork.genderRepo.GetAll().Where(x => x.Status == true);
            var Query_Marriage = this.unitOfWork.marriageRepo.GetAll().Where(x => x.Status == true);
            var Query_Role = this.unitOfWork.roleRepo.GetAll();
            var Query_StaffChef = this.unitOfWork.staffOrChefRepo.GetAll().Where(x => x.Status == true);

            //city
            foreach(var item in Query_City)
            {
                var Pull_City = new GetAllCitys()
                {
                    Id = item.IDCity,
                    NameCity = item.Name,
                    Status = item.Status
                };
                resultData.L_City.Add(Pull_City);
            }

            //gender
            foreach (var item in Query_Gender)
            {
                var Pull_Gender = new GetAllGender()
                {
                    Id = item.IDGender,
                    Name = item.Name,
                    Status = item.Status
                };
                resultData.L_Gender.Add(Pull_Gender);
            }

            //Marriage
            foreach (var item in Query_Marriage)
            {
                var Pull_Marriage = new GetAllMarriage()
                {
                    Id = item.IDMarriage,
                    Name = item.Name,
                    Status = item.Status
                };
                resultData.L_Marriage.Add(Pull_Marriage);
            }

            //Marriage
            foreach (var item in Query_Role)
            {
                var Pull_Role = new GetAllRole()
                {
                    IDRole = item.IDRole,
                    NameRole = item.NameRole,
                    Symbol = item.Symbol,
                    CreateDate = item.CreateDate,
                    Discription = item.Discripttion
                };
                resultData.L_Role.Add(Pull_Role);
            }

            //Staff Or Chef
            foreach (var item in Query_StaffChef)
            {
                var Pull_StaffChef = new GetAllStaffOrChef()
                {
                    Id = item.IDStaffOrChef,
                    Name = item.Name,
                    CreateDate = item.CreateDate,
                    Status = item.Status
                };
                resultData.L_StaffChef.Add(Pull_StaffChef);
            }
            return resultData;
        }

        //create account
        public async Task<NotificationAccount> CreateAccount(CreateAccount request)
        {
            var result = new NotificationAccount();
            var Query = this.unitOfWork.userRepo.GetAll();
            var QueryStaff = this.unitOfWork.staffRepo.GetAll();
            var QueryRole = await this.unitOfWork.roleRepo.GetGuild(request.IdRole);

            var CheckEmailUser = Query.Find(x => x.Email == request.Email);
            if(CheckEmailUser != null)
            {
                result.Id = 1; //Email already exist
            }
            else
            {
                var CheckPhoneStaff = QueryStaff.Find(x => x.Phone == request.PhoneNumber);
                if(CheckPhoneStaff != null)
                {
                    result.Id = 2; //Phone already exist
                }
                else
                {
                    if(QueryRole == null)
                    {
                        result.Id = 4; // Not Find Id Role
                    }
                    else
                    {
                        Guid Id = Guid.NewGuid();
                        //Create Account
                        var AccountForm = new T_User();
                        AccountForm.IDAccount = Id;
                        AccountForm.PassWord = "Ivali";
                        AccountForm.CreateDate = request.CreateDate;
                        AccountForm.IDCustomerOrStaff = request.IDCustomerOrStaff;
                        AccountForm.UserName = request.UserName;
                        AccountForm.Email = request.Email;
                        var InsertAccount = await userManager.CreateAsync(AccountForm, request.Password);
                        if(InsertAccount.Succeeded == false)
                        {
                            result.Id = 5; // Create Account Fail;
                        }
                        else
                        {
                            Guid G_IDStaff = Guid.NewGuid();
                            //create infomation staff
                            var StaffForm = new T_Staff();
                            StaffForm.IDStaff = G_IDStaff;
                            StaffForm.FullName = request.FullName;
                            StaffForm.Birthday = request.Birthday;
                            StaffForm.Address = request.Address;
                            StaffForm.Phone = request.PhoneNumber;
                            StaffForm.IDCode = Convert.ToString(request.Birthday + request.PhoneNumber);
                            StaffForm.ContentFile = request.ContentFile;
                            StaffForm.FileName = request.FileName;
                            StaffForm.TypeImage = request.TypeImage;
                            StaffForm.MimeType = request.MimeType;
                            StaffForm.CreateDate = request.CreateDate;
                            StaffForm.IDMarriage = request.IdMarriage;
                            StaffForm.IDAccount = AccountForm.IDAccount;
                            StaffForm.IDCustomerOrStaff = request.IDCustomerOrStaff;
                            StaffForm.IDCity = request.IdCity;
                            StaffForm.IDDistrict = request.IdDistrict;
                            StaffForm.IDGender = request.IdGender;
                            StaffForm.IDStaffOrChef = request.IdStaffOrChef;
                            this.unitOfWork.staffRepo.Add(StaffForm);

                            //Create User Role
                            var UserRole = new T_UserRole();
                            UserRole.CreateDate = request.CreateDate;
                            UserRole.Status = true;
                            UserRole.IDRole = request.IdRole;
                            UserRole.IDStaff = G_IDStaff;
                            this.unitOfWork.userRoleRepo.Add(UserRole);

                            //save in database
                            this.unitOfWork.Commit();
                            result.Id = 3; //create account and staff success
                        }
                    }
                }
            }
            return result;
        }

        //Detail Acount
        public async Task<DetailAccount> DetailAccount(Guid IdAccount)
        {
            var FormModel = new DetailAccount();
            var QueryData = await this.unitOfWork.userRepo.GetGuild(IdAccount);
            var QueryCustomerStaff = this.unitOfWork.customerOrStaffRepo.GetAll();
            var QueryStaffOrChef = this.unitOfWork.staffOrChefRepo.GetAll();
            var QueryStaff = this.unitOfWork.staffRepo.GetAll();
            if(QueryData.IDAccount != new Guid())
            {
                FormModel.IdAccount = QueryData.IDAccount;
                FormModel.CreateDate = QueryData.CreateDate.ToShortDateString();
                FormModel.CreateTime = QueryData.CreateDate.ToShortTimeString();
                FormModel.NameCustomerOfStaff = QueryCustomerStaff
                    .FirstOrDefault(x => x.IDCustomerOrStaff == QueryData.IDCustomerOrStaff).Name;
                FormModel.IdStaff = QueryStaff.FirstOrDefault(x => x.IDAccount == QueryData.IDAccount).IDStaff;
                FormModel.Email = QueryData.Email;
                FormModel.PhoneNumber = QueryStaff.FirstOrDefault(x => x.IDAccount == QueryData.IDAccount).Phone; ;
                FormModel.NameStaffOrChef = QueryStaffOrChef
                   .FirstOrDefault(x => x.IDStaffOrChef == QueryStaff
                        .FirstOrDefault(x => x.IDAccount == QueryData.IDAccount).IDStaffOrChef).Name;
            }
            return FormModel;
        }
    }

}

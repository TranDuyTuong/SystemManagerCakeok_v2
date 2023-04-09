using Library.DataTable.TableRole;
using Library.InterfaceRepository.IUnitOfWork;
using Library.ViewModel.Admin.V_Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ServiceAdmin.ServiceAdminInjection.Role
{
    public class Roles : Iroles
    {
        private readonly IUnitOfWork unitOfWork;
        public Roles(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        //create role
        public NotificationRole CreateRole(CreateRole request)
        {
            var result = new NotificationRole();
            var FormData = new T_Role()
            {
                IDRole = Guid.NewGuid(),
                NameRole = request.NameRole,
                Symbol = request.Symbol,
                CreateDate = request.CreateDate,
                Discripttion = request.Discription,
                Name = request.NameRole
            };
            this.unitOfWork.roleRepo.Add(FormData);
            this.unitOfWork.Commit();
            result.Id = 1; //create role success
            return result;
        }

        //Detail Role
        public async Task<DetailRole> DetailRole(Guid IdRole)
        {
            var result = new DetailRole();
            var Query = await this.unitOfWork.roleRepo.GetGuild(IdRole);
            var QueryUserRole = this.unitOfWork.userRoleRepo.GetAll();
            var QueryStaff = this.unitOfWork.staffRepo.GetAll();

            result.IdRole = Query.IDRole;
            result.NameRole = Query.NameRole;
            result.Symbol = Query.Symbol;
            result.CreateDate = Query.CreateDate;

            foreach(var item in QueryUserRole)
            {
                if(item.IDRole == Query.IDRole)
                {
                    var data = new GetAllUserRole()
                    {
                        IdUserRole = item.IDUserRole,
                        Status = item.Status,
                        IdRole = item.IDRole,
                        IdStaff = item.IDStaff,
                        NameStaff = QueryStaff.FirstOrDefault(x=>x.IDStaff == item.IDStaff).FullName,
                        ContentFile = QueryStaff.FirstOrDefault(x => x.IDStaff == item.IDStaff).ContentFile,
                        FileName = QueryStaff.FirstOrDefault(x => x.IDStaff == item.IDStaff).FileName,
                        TypeImage = QueryStaff.FirstOrDefault(x => x.IDStaff == item.IDStaff).TypeImage
                    };
                    result.L_UserRole.Add(data);
                }
            }
            return result;
        }

        //get all role
        public List<GetAllRole> GetAllRoles()
        {
            var L_Role = new List<GetAllRole>();
            var Query = this.unitOfWork.roleRepo.GetAll();
            foreach(var item in Query)
            {
                var data = new GetAllRole()
                {
                  IDRole = item.IDRole,
                  NameRole = item.NameRole,
                  Symbol = item.Symbol,
                  CreateDate = item.CreateDate,
                  Discription = item.Discripttion
                };
                L_Role.Add(data);
            }
            return L_Role;
        }
    }
}

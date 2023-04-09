using Library.DataTable.TableUser;
using Library.InterfaceRepository.IUnitOfWork;
using Library.ViewModel.Admin.V_Gender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ServiceAdmin.ServiceAdminInjection.Gender
{
    public class Gender: IGender
    {
        private readonly IUnitOfWork unitOfWork;
        public Gender(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        //get all gender
        public List<GetAllGender> GetAllGender()
        {
            var L_Gender = new List<GetAllGender>();
            var result = this.unitOfWork.genderRepo.GetAll();
            foreach(var item  in result)
            {
                var data = new GetAllGender()
                {
                    Id = item.IDGender,
                    Name = item.Name,
                    Status = item.Status
                };
                L_Gender.Add(data);
            }
            return L_Gender;
        }
        
        //create gender
        public NotificationGender CreateGender(CreateGender request)
        {
            var result = new NotificationGender();
            var FormData = new T_Gender()
            {
                Name = request.Name,
                Status = request.Status
            };
            this.unitOfWork.genderRepo.Add(FormData);
            this.unitOfWork.Commit();
            result.Id = 1; //create success gender
            return result;
        }
    }
}

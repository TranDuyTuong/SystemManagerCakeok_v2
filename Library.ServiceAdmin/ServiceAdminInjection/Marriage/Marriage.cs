using Library.DataTable.TableUser;
using Library.InterfaceRepository.IUnitOfWork;
using Library.ViewModel.Admin.V_Marriage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ServiceAdmin.ServiceAdminInjection.Marriage
{
    public class Marriage: Imarriage
    {
        private readonly IUnitOfWork unitOfWork;
        public Marriage(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        //create marriage
        public NotificationMarriage CreateMarriage(CreateMarriage request)
        {
            var result = new NotificationMarriage();
            var DataSet = new T_Marriage()
            {
                Name = request.Name,
                Status = request.Status
            };
            this.unitOfWork.marriageRepo.Add(DataSet);
            this.unitOfWork.Commit();
            result.Id = 1; // create success
            return result;
        }

        //get all marriage
        public List<GetAllMarriage> GetAllMarriages()
        {
            var L_Marriage = new List<GetAllMarriage>();
            var result = this.unitOfWork.marriageRepo.GetAll();
            foreach(var item in result)
            {
                var data = new GetAllMarriage()
                {
                    Id = item.IDMarriage,
                    Name = item.Name,
                    Status = item.Status
                };
                L_Marriage.Add(data);
            }
            return L_Marriage;
        }
    }
}

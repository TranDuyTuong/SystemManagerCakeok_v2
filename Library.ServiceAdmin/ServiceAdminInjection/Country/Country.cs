using Library.DataTable.TableUser;
using Library.InterfaceRepository.IUnitOfWork;
using Library.ViewModel.Admin.V_Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ServiceAdmin.ServiceAdminInjection.Country
{
    public class Country: ICountry
    {
        private readonly IUnitOfWork unitOfWork;
        public Country(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        //create country
        public NotificationCountry CreateCountry(CreateCountry request)
        {
            var Result = new NotificationCountry();
            var FormCreate = new T_Country()
            {
                Name = request.Name,
                CreateDate = request.CreateDate,
                Status = request.Status
            };
            this.unitOfWork.countryRepo.Add(FormCreate);
            this.unitOfWork.Commit();
            Result.Id = 1;
            return Result;
        }

        //create country muplite 
        public NotificationCountry CreateMupliteCountry(List<CreateCountry> request)
        {
            var result = new NotificationCountry();
            if(request.Count() == 0)
            {
                result.Id = 2; //not find dat in excel file
            }
            else
            {
                var L_Country = new List<T_Country>();
                foreach(var item in request)
                {
                    var data = new T_Country()
                    {
                        Name = item.Name,
                        CreateDate = item.CreateDate,
                        Status = item.Status
                    };
                    L_Country.Add(data);
                }
                IEnumerable<T_Country> L_CoutryCover = L_Country;
                this.unitOfWork.countryRepo.Insert(L_CoutryCover);
                this.unitOfWork.Commit();
                result.Id = 3; //insert success
            }
            return result;
        }

        //get all countrys
        public List<GetAllCountry> GetAllCountry()
        {
            var L_Country = new List<GetAllCountry>();
            var Query = this.unitOfWork.countryRepo.GetAll();
            foreach(var item in Query)
            {
                var data = new GetAllCountry()
                {
                    Id = item.IDCountry,
                    Name = item.Name,
                    CreateDate = item.CreateDate,
                    Status = item.Status
                };
                L_Country.Add(data);
            }
            return L_Country.OrderBy(x=>x.Name).ToList();
        }

        //get ten country
        public List<GetAllCountry> GetTenCountry()
        {
            var L_Country = new List<GetAllCountry>();
            var result = this.unitOfWork.countryRepo.GetAll().OrderByDescending(x => x.IDCountry).Take(10);
            foreach (var item in result)
            {
                var data = new GetAllCountry()
                {
                    Id = item.IDCountry,
                    Name = item.Name,
                    CreateDate = item.CreateDate,
                    Status = item.Status
                };
                L_Country.Add(data);
            }
            return L_Country;
        }
    }
}

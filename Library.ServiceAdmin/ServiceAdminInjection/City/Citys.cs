using Library.DataTable.TableUser;
using Library.InterfaceRepository.IUnitOfWork;
using Library.ViewModel.Admin.V_City;
using Library.ViewModel.Admin.V_District;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace Library.ServiceAdmin.ServiceAdminInjection.City
{
    public class Citys: ICitys
    {
        private readonly IUnitOfWork unitOfWork;
        public Citys(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        //Change Status City
        public async Task<EditCity> ChnageStatusCityGet(int Id)
        {
            var ModelData = new EditCity();
            var Result = await this.unitOfWork.cityRepo.Get(Id);
            ModelData.Id = Result.IDCity;
            ModelData.Name = Result.Name;
            ModelData.Status = Result.Status;
            return ModelData;
        }

        public async Task<NotificationCity> ChangeStatusPost(int Id, bool Status)
        {
            var Modal = new NotificationCity();
            var Result = await this.unitOfWork.cityRepo.Get(Id);
            if(Result.IDCity == 0)
            {
                Modal.Id = 1; //Not find Id City
            }
            else
            {
                Result.Status = Status;
                this.unitOfWork.cityRepo.Update(Result);
                this.unitOfWork.Commit();
                Modal.Id = 2; //Update Status Success
            }
            return Modal;
        }

        //create a city
        public bool CreateCity(CreateCity request)
        {
            var CreateData = new T_City();
            CreateData.Name = request.NameCity;
            CreateData.Status = request.Status;
            unitOfWork.cityRepo.Add(CreateData);
            unitOfWork.Commit();
            return true;
        }

        //create Muplite city
        public NotificationCity CreateMupliteCity(List<CreateCity> request)
        {
            var ResultData = new NotificationCity();
            if(request.Count() == 0)
            {
                ResultData.Id = 2; //Data in file Excel is null
            }
            else
            {
                List<T_City> L_City = new List<T_City>();
                foreach(var item in request)
                {
                    L_City.Add(new T_City
                    {
                        Name = item.NameCity,
                        Status = item.Status
                    });
                }
                IEnumerable<T_City> L_CityCover = L_City;
                unitOfWork.cityRepo.Insert(L_CityCover);
                unitOfWork.Commit();
                ResultData.Id = 3; // Insert Data Excel Muplite Success
            }
            return ResultData;
        }

        //Edit City
        public async Task<EditCity> EditCityGet(int Id)
        {
            var City = new EditCity();
            var Result = await this.unitOfWork.cityRepo.Get(Id);
            City.Id = Result.IDCity;
            City.Name = Result.Name;
            return City;
        }

        public async Task<NotificationCity> EditCityPost(int Id, string Name)
        {
            var ResultData = new NotificationCity();
            var FindData = await this.unitOfWork.cityRepo.Get(Id);
            if(FindData.IDCity == 0)
            {
                ResultData.Id = 2; //not find id city
            }
            else
            {
                FindData.Name = Name;
                this.unitOfWork.cityRepo.Update(FindData);
                this.unitOfWork.Commit();
                ResultData.Id = 1; // update city success
            }
            return ResultData;
        }

        //Get All citys
        public List<GetAllCitys> GetAllCitys()
        {
            List<GetAllCitys> L_City = new List<GetAllCitys>();
            var Result = this.unitOfWork.cityRepo.GetAll().OrderByDescending(x => x.IDCity);
            foreach(var item in Result)
            {
                L_City.Add(new GetAllCitys
                {
                    Id = item.IDCity,
                    NameCity = item.Name,
                    Status = item.Status
                });
            }
            return L_City;
        }


        //Get 10 city new for create city
        public List<GetAllCitys> GetTenCityNew()
        {
            List<GetAllCitys> L_City = new List<GetAllCitys>();
            var Result = this.unitOfWork.cityRepo.GetAll().OrderByDescending(x => x.IDCity).Take(10);
            foreach(var item in Result)
            {
                L_City.Add(new GetAllCitys
                {
                    Id = item.IDCity,
                    NameCity = item.Name,
                    Status = item.Status
                });
            }
            return L_City;
        }

        //Detail City
        public async Task<DetailCity> DetailCity(int Id)
        {
            var Result = new DetailCity();
            var Request = await this.unitOfWork.cityRepo.Get(Id);
            var QueryDistrict = await this.unitOfWork.cityRepo.GetAllDistrictByCityID(Request.IDCity);
            Result.Id = Request.IDCity;
            Result.Name = Request.Name;
            Result.Status = Request.Status;
            if(QueryDistrict.Count() != 0)
            {
                foreach (var item in QueryDistrict)
                {
                    var Datas = new GetAllDistrict()
                    {
                        Id = item.IDDistrict,
                        Name = item.Name,
                        Status = item.Status
                    };
                    Result.L_District.Add(Datas);
                }
            }
            else
            {
                Result.L_District = new List<GetAllDistrict>();
            }
            return Result;
        }

    }
}

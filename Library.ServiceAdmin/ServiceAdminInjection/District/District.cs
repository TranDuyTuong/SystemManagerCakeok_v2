using Library.DataTable.TableUser;
using Library.InterfaceRepository.IUnitOfWork;
using Library.ViewModel.Admin.V_City;
using Library.ViewModel.Admin.V_District;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ServiceAdmin.ServiceAdminInjection.District
{
    public class District: IDistrict
    {
        private readonly IUnitOfWork unitOfWork;
        public District(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        //create district
        public async Task<NotificationDistirct> CreateDitrist(CreateDistrict request)
        {
            var result = new NotificationDistirct();
            var CheckIdCity = await this.unitOfWork.cityRepo.Get(request.IdCity);
            if(CheckIdCity.IDCity == 0)
            {
                result.Id = 1; //Not find Id City
            }
            else
            {
                var Request = new T_District()
                {
                    IDCity = request.IdCity,
                    Name = request.Name,
                    Status = request.Status
                };
                this.unitOfWork.districtRepo.Add(Request);
                this.unitOfWork.Commit();
                result.Id = 2; // Create Success
            }
            return result;

        }

        //get all districts
        public List<GetAllDistrict> GetAllDistrict()
        {
            var result = new List<GetAllDistrict>();
            var Query =  this.unitOfWork.districtRepo.GetAll();
            var QueryCity = this.unitOfWork.cityRepo.GetAll();
            foreach(var item in Query)
            {
                var DataSet = new GetAllDistrict()
                {
                    Id = item.IDDistrict,
                    Name = item.Name,
                    Status = item.Status,
                    IdCity = item.IDCity,
                    NameCity = QueryCity.FirstOrDefault(x=>x.IDCity == item.IDCity).Name
                };
                result.Add(DataSet);
            }
            return result;
        }

        //get ten district
        public List<GetAllDistrict> GetTenDistrict()
        {
            List<GetAllDistrict> L_District = new List<GetAllDistrict>();
            var Result = this.unitOfWork.districtRepo.GetAll().OrderByDescending(x => x.IDDistrict).Take(10);
            var QueryCity = this.unitOfWork.cityRepo.GetAll();
            foreach (var item in Result)
            {
                L_District.Add(new GetAllDistrict
                {
                    Id = item.IDDistrict,
                    Name = item.Name,
                    Status = item.Status,
                    IdCity = item.IDCity,
                    NameCity = QueryCity.FirstOrDefault(x => x.IDCity == item.IDCity).Name
                });
            }
            return L_District;
        }

        //get edit district
        public async Task<EditDistrict> GetEditDitrict(int Id)
        {
            var GetData = await this.unitOfWork.districtRepo.Get(Id);
            var GetCity = this.unitOfWork.cityRepo.GetAll().Where(x => x.Status == true);
            var Result = new EditDistrict();
            var L_City = new List<GetAllCitys>();
            foreach(var item in GetCity)
            {
                var data = new GetAllCitys()
                {
                    Id = item.IDCity,
                    NameCity = item.Name,
                    Status = item.Status
                };
                L_City.Add(data);
            }
            Result.IdDitrict = GetData.IDDistrict;
            Result.NameDistrict = GetData.Name;
            if(GetCity.FirstOrDefault(x=>x.IDCity == GetData.IDCity) == null)
            {
                Result.IdCity = 0;               
            }
            else
            {
                Result.IdCity = GetData.IDCity;
                Result.NameCity = GetCity.FirstOrDefault(x => x.IDCity == GetData.IDCity).Name;
            }
            Result.L_City = L_City;
            return Result;
        }

        public async Task<NotificationDistirct> PostEditDistrict(EditDistrict request)
        {
            var Result = new NotificationDistirct();
            var Query = await this.unitOfWork.districtRepo.Get(request.IdDitrict);
            if(Query == null)
            {
                Result.Id = 1; // not find id district
            }
            else
            {
                Query.IDCity = request.IdCity;
                Query.Name = request.NameDistrict;
                this.unitOfWork.districtRepo.Update(Query);
                this.unitOfWork.Commit();
                Result.Id = 2; //update success
            }
            return Result;
        }


        //Edit Status District
        public async Task<GetAllDistrict> EditStatusDistrict(int Id)
        {
            var result = new GetAllDistrict();
            var Query = await this.unitOfWork.districtRepo.Get(Id);
            result.Id = Query.IDDistrict;
            result.Name = Query.Name;
            result.Status = Query.Status;
            return result;
        }

        public async Task<NotificationDistirct> PostEditStatusDistrict(int Id, bool Status)
        {
            var result = new NotificationDistirct();
            var Query = await this.unitOfWork.districtRepo.Get(Id);
            if(Query.IDDistrict == 0)
            {
                result.Id = 1; // not find id district
            }
            else
            {
                Query.Status = Status;
                this.unitOfWork.districtRepo.Update(Query);
                this.unitOfWork.Commit();
                result.Id = 2; // update status success
            }
            return result;
        }

        //get all district by id city
        public List<GetAllDistrict> GetAllDistrictByIdCity(int IdCity)
        {
            var Query = this.unitOfWork.districtRepo.GetAll().Where(x => x.IDCity == IdCity);
            var result = new List<GetAllDistrict>();
            foreach(var item in Query)
            {
                var data = new GetAllDistrict()
                {
                    Id = item.IDDistrict,
                    IdCity = item.IDCity,
                    Name = item.Name
                };
                result.Add(data);
            }
            return result;
        }


    }
}

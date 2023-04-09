using Library.ViewModel.Admin.V_City;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ServiceAdmin.ServiceAdminInjection.City
{
    public interface ICitys
    {
        //Create a City
        bool CreateCity(CreateCity request);

        //Create Muplite Citys
        NotificationCity CreateMupliteCity(List<CreateCity> request);

        //Get 10 city new for create City
        List<GetAllCitys> GetTenCityNew();

        //Get All Citys
        List<GetAllCitys> GetAllCitys();

        //Edit City
        Task<EditCity> EditCityGet(int Id);

        Task<NotificationCity> EditCityPost(int Id, string Name);

        //Change Status City
        Task<EditCity> ChnageStatusCityGet(int Id);

        Task<NotificationCity> ChangeStatusPost(int Id, bool Status);

        //Detail City
        Task<DetailCity> DetailCity(int Id);

    }
}

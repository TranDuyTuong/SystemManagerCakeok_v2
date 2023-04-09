using Library.ViewModel.Admin.V_District;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ServiceAdmin.ServiceAdminInjection.District
{
    public interface IDistrict
    {
        //get all district
        List<GetAllDistrict> GetAllDistrict();

        //create distirct
        Task<NotificationDistirct> CreateDitrist(CreateDistrict request);

        //get all district
        List<GetAllDistrict> GetTenDistrict();

        //Edit District
        Task<EditDistrict> GetEditDitrict(int Id);

        Task<NotificationDistirct> PostEditDistrict(EditDistrict request);

        //Edit District Status
        Task<GetAllDistrict> EditStatusDistrict(int Id);

        Task<NotificationDistirct> PostEditStatusDistrict(int Id, bool Status);

        //Get All Distric by Id City
        List<GetAllDistrict> GetAllDistrictByIdCity(int IdCity);
    }
}

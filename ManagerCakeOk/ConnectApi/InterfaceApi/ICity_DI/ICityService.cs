using Library.ViewModel.Admin.V_City;
using ManagerCakeOk.Models.M_Citys;

namespace ManagerCakeOk.ConnectApi.InterfaceApi.ICity_DI
{
    public interface ICityService
    {
        // TODO: GET ALL CITY PADING
        Task<GetAllCity_M> getAllCitys(int pageIndex, int pageSize, string seach);

        // TODO: DETAIL CITY BY ID
        Task<DetailCity> detailCity(int id, int pageSize, int pageIndex);

        // TODO: SHOW INFOMATION EDIT CITY BY ID
        Task<EditCity> getEditCitys(int idCity);

        Task<NotificationCity> postEditCity(int idCity, string name);

        // TODO: CHANGE UPDATE STATUS CITY
        Task<EditCity> getUpdateStatusCity(int idCity);

        Task<NotificationCity> postUpdateStatusCity(int idCity,  bool status);

        // TODO: CRETAE CITY
        Task<NotificationCity> postCreateCity(CreateCity request);

        // TODO: GET 10 NEW CITYS
        Task<List<GetAllCitys>> getTennNewCity();

        // TODO: CREATE MUPLILINE CITYS
        Task<NotificationCity> postCreateCityByExcelFile(CreateFileCityEX request);
    }
}

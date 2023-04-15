using Library.ViewModel.Admin.V_City;
using ManagerCakeOk.Models.M_Districts;

namespace ManagerCakeOk.ConnectApi.InterfaceApi.IDistrict_DI
{
    public interface IDistrictService
    {
        // TODO: API GET ALL DISITRCT
        Task<GetAllDistrict_M> getAllDistrict(int pageIndex, int pageSize, string Seach);

        // TODO: API GET ALL CITY FOR CREATE DISTRICT
        Task<List<GetAllCitys>> getAllCitysForCreateDistrict();
    }
}

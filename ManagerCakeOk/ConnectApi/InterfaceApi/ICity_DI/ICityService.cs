using Library.ViewModel.Admin.V_City;
using ManagerCakeOk.Models.M_Citys;

namespace ManagerCakeOk.ConnectApi.InterfaceApi.ICity_DI
{
    public interface ICityService
    {
        // TODO: GET ALL CITY PADING
        Task<GetAllCity_M> getAllCitys(int pageIndex, int pageSize);
    }
}

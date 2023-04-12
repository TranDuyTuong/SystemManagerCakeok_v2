using Library.ViewModel.Admin.V_City;

namespace ManagerCakeOk_Api.Model.City_Model
{
    public class GetAllCity_M
    {
        public List<GetAllCitys> l_City { get; set; }
        public int TotalCity { get; set; }
        public int TotalSeachCity { get; set; }
    }
}

using Library.ViewModel.Admin.V_City;
using ManagerCakeOk.ConnectApi.InterfaceApi.IDistrict_DI;
using ManagerCakeOk.Models.M_Districts;
using Newtonsoft.Json;
using System.Drawing.Printing;

namespace ManagerCakeOk.ConnectApi.ServiceApi.District_DI
{
    public class DistrictService: IDistrictService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public DistrictService(IHttpClientFactory httpClientFactory,
                    IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        // TODO: GET ALL CITY FOR CREATE DISTRICT
        public async Task<List<GetAllCitys>> getAllCitysForCreateDistrict()
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync($"/api/City/GetAllCityForSelection");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode == false)
            {
                List<GetAllCitys> myDeserializedObjList = (List<GetAllCitys>)JsonConvert.DeserializeObject(body, typeof(List<GetAllCitys>));

                return myDeserializedObjList;
            }
            return JsonConvert.DeserializeObject<List<GetAllCitys>>(body);
        }

        // TODO: GET ALL DISTRICT API
        public async Task<GetAllDistrict_M> getAllDistrict(int pageIndex, int pageSize, string Seach)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync($"/api/District/GetAllDistrict?pageSize={pageSize}&pageIndex={pageIndex}&seach={Seach}");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode == false)
            {
                GetAllDistrict_M myDeserializedObjList = (GetAllDistrict_M)JsonConvert.DeserializeObject(body, typeof(GetAllDistrict_M));

                return myDeserializedObjList;
            }
            return JsonConvert.DeserializeObject<GetAllDistrict_M>(body);
        }
    }
}

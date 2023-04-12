using Library.ViewModel.Admin.V_City;
using ManagerCakeOk.ConnectApi.InterfaceApi.ICity_DI;
using ManagerCakeOk.Models.M_Citys;
using Newtonsoft.Json;
using System.Security.Policy;

namespace ManagerCakeOk.ConnectApi.ServiceApi.City_DI
{
    public class CityService : ICityService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public CityService(IHttpClientFactory httpClientFactory,
                    IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        // TODO: CALL API GET ALL CITY
        public async Task<GetAllCity_M> getAllCitys(int pageIndex, int pageSize)
        {
            //var getToken = "tuong";
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync($"/api/City/GetAllCity?PageSize={pageSize}&PageIndex={pageIndex}");
            var body =  await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode == false)
            {
                GetAllCity_M myDeserializedObjList = (GetAllCity_M)JsonConvert.DeserializeObject(body,typeof(GetAllCity_M));

                return myDeserializedObjList;
            }
            return JsonConvert.DeserializeObject<GetAllCity_M>(body);
        }


    }
}

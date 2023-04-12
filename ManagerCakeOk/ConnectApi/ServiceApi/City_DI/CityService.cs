using Library.ViewModel.Admin.V_City;
using ManagerCakeOk.ConnectApi.InterfaceApi.ICity_DI;
using ManagerCakeOk.Models.M_Citys;
using Newtonsoft.Json;
using System.Drawing.Printing;
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

        // TODO: DETAIL CITY API 
        public async Task<DetailCity> detailCity(int id, int pageSize, int pageIndex)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync($"/api/City/DetailCity?idCity={id}&pageIndex={pageIndex}&pageSize={pageSize}");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode == false)
            {
                DetailCity myDeserializedObjList = (DetailCity)JsonConvert.DeserializeObject(body, typeof(DetailCity));

                return myDeserializedObjList;
            }
            return JsonConvert.DeserializeObject<DetailCity>(body);
        }

        // TODO: CALL API GET ALL CITY
        public async Task<GetAllCity_M> getAllCitys(int pageIndex, int pageSize, string seach)
        {
            //var getToken = "tuong";
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync($"/api/City/GetAllCity?PageSize={pageSize}&PageIndex={pageIndex}&Seach={seach}");
            var body =  await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode == false)
            {
                GetAllCity_M myDeserializedObjList = (GetAllCity_M)JsonConvert.DeserializeObject(body,typeof(GetAllCity_M));

                return myDeserializedObjList;
            }
            return JsonConvert.DeserializeObject<GetAllCity_M>(body);
        }

        // TODO: GET DATA EDIT CITY
        public async Task<EditCity> getEditCitys(int idCity)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync($"/api/City/GetEditCity?idCity={idCity}");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode == false)
            {
                EditCity myDeserializedObjList = (EditCity)JsonConvert.DeserializeObject(body, typeof(EditCity));

                return myDeserializedObjList;
            }
            return JsonConvert.DeserializeObject<EditCity>(body);
        }

        public async Task<NotificationCity> postEditCity(int idCity, string name)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var requestContent = new MultipartFormDataContent();
            requestContent.Add(new StringContent(string.IsNullOrEmpty(name) ? "" : name.ToString()), "Name");

            var response = await client.PutAsync($"/api/City/" + idCity, requestContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode == false)
            {
                NotificationCity myDeserializedObjList = (NotificationCity)JsonConvert.DeserializeObject(body, typeof(NotificationCity));

                return myDeserializedObjList;
            }
            return JsonConvert.DeserializeObject<NotificationCity>(body);
        }

    }
}

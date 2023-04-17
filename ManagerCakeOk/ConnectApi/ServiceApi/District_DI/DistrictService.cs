using Library.ViewModel.Admin.V_City;
using Library.ViewModel.Admin.V_District;
using ManagerCakeOk.ConnectApi.InterfaceApi.IDistrict_DI;
using ManagerCakeOk.Models.M_Districts;
using Newtonsoft.Json;
using System.Drawing.Printing;
using System.Net.Http.Headers;
using System.Xml.Linq;

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

        // TODO: CREATE A DISTRICT 
        public async Task<NotificationDistirct> createDistrict(CreateDistrict request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var requestContent = new MultipartFormDataContent();
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.IdCity.ToString()) ? "" : request.IdCity.ToString()), "IdCityStr");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.Name) ? "" : request.Name), "Name");

            var response = await client.PostAsync($"/api/District/PostCreateDistrict", requestContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode == false)
            {
                NotificationDistirct myDeserializedObjList = (NotificationDistirct)JsonConvert.DeserializeObject(body, typeof(NotificationDistirct));

                return myDeserializedObjList;
            }
            return JsonConvert.DeserializeObject<NotificationDistirct>(body);
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

        // TODO: GET TEN NEW DISTRICT
        public async Task<List<GetAllDistrict>> getTenDistrict()
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync($"/api/District/GetTenDistrict");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode == false)
            {
                List<GetAllDistrict> myDeserializedObjList = (List<GetAllDistrict>)JsonConvert.DeserializeObject(body, typeof(List<GetAllDistrict>));

                return myDeserializedObjList;
            }
            return JsonConvert.DeserializeObject<List<GetAllDistrict>>(body);
        }

        // TODO: CREATE DISTRICT TO EXCEL FILE
        public async Task<NotificationDistirct> postCreateDistrictByExcelFile(CreateFileDistrictEX request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);

            var fileName = ContentDispositionHeaderValue.Parse(request.fileExcelDistrict.ContentDisposition).FileName.Trim('"');

            using (var content = new MultipartFormDataContent())
            {
                content.Add(new StreamContent(request.fileExcelDistrict.OpenReadStream())
                {
                    Headers =
                    {
                        ContentLength = request.fileExcelDistrict.Length,
                        ContentType = new MediaTypeHeaderValue(request.fileExcelDistrict.ContentType)
                    }
                }, "fileExcelDistrict", fileName);

                var response = await client.PostAsync($"/api/District/CreateDistrictMultiline/", content);
                var body = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode == false)
                {
                    NotificationDistirct myDeserializedObjList = (NotificationDistirct)JsonConvert.DeserializeObject(body, typeof(NotificationDistirct));

                    return myDeserializedObjList;
                }
                return JsonConvert.DeserializeObject<NotificationDistirct>(body);
            }
        }

      
    }
}

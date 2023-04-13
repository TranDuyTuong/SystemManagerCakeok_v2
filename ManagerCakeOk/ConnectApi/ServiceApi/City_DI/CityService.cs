using Library.ViewModel.Admin.V_City;
using ManagerCakeOk.ConnectApi.InterfaceApi.ICity_DI;
using ManagerCakeOk.Models.M_Citys;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Security.Policy;
using System.Xml.Linq;

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

        // TODO: CALL API GET ALL CITY API
        public async Task<GetAllCity_M> getAllCitys(int pageIndex, int pageSize, string seach)
        {
            //var getToken = "tuong";
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync($"/api/City/GetAllCity?PageSize={pageSize}&PageIndex={pageIndex}&Seach={seach}");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode == false)
            {
                GetAllCity_M myDeserializedObjList = (GetAllCity_M)JsonConvert.DeserializeObject(body, typeof(GetAllCity_M));

                return myDeserializedObjList;
            }
            return JsonConvert.DeserializeObject<GetAllCity_M>(body);
        }

        // TODO: GET DATA EDIT CITY API
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

        // TODO: POST EDIT CITY API
        public async Task<NotificationCity> postEditCity(int idCity, string name)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var requestContent = new MultipartFormDataContent();
            requestContent.Add(new StringContent(string.IsNullOrEmpty(idCity.ToString()) ? "" : idCity.ToString()), "IdStr");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(name) ? "" : name.ToString()), "Name");

            var response = await client.PostAsync($"/api/City/PostEditCity", requestContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode == false)
            {
                NotificationCity myDeserializedObjList = (NotificationCity)JsonConvert.DeserializeObject(body, typeof(NotificationCity));

                return myDeserializedObjList;
            }
            return JsonConvert.DeserializeObject<NotificationCity>(body);
        }

        // TODO: GET UPDATE STATUS CITY API
        public async Task<EditCity> getUpdateStatusCity(int idCity)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);

            var response = await client.GetAsync($"/api/City/GetChangeStatusCity?idCity={idCity}");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode == false)
            {
                EditCity myDeserializedObjList = (EditCity)JsonConvert.DeserializeObject(body, typeof(EditCity));

                return myDeserializedObjList;
            }
            return JsonConvert.DeserializeObject<EditCity>(body);
        }

        public async Task<NotificationCity> postUpdateStatusCity(int idCity, bool status)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);

            var response = await client.GetAsync($"/api/City/PostChangeStatusCity?IdCity={idCity}&Status{status}");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode == false)
            {
                NotificationCity myDeserializedObjList = (NotificationCity)JsonConvert.DeserializeObject(body, typeof(NotificationCity));

                return myDeserializedObjList;
            }
            return JsonConvert.DeserializeObject<NotificationCity>(body);
        }

        // TODO: CREATE CITY API
        public async Task<NotificationCity> postCreateCity(CreateCity request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var requestContent = new MultipartFormDataContent();
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.NameCity) ? "" : request.NameCity.ToString()), "NameCity");

            var response = await client.PostAsync($"/api/City/CreateCity", requestContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode == false)
            {
                NotificationCity myDeserializedObjList = (NotificationCity)JsonConvert.DeserializeObject(body, typeof(NotificationCity));

                return myDeserializedObjList;
            }
            return JsonConvert.DeserializeObject<NotificationCity>(body);
        }

        // TODO: GET 10 NEW CITYS
        public async Task<List<GetAllCitys>> getTennNewCity()
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);

            var response = await client.GetAsync($"/api/City/GetTenCityNew");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode == false)
            {
                List<GetAllCitys> myDeserializedObjList = (List<GetAllCitys>)JsonConvert.DeserializeObject(body, typeof(List<GetAllCitys>));

                return myDeserializedObjList;
            }
            return JsonConvert.DeserializeObject<List<GetAllCitys>>(body);
        }

        // TODO: CREATE CITYS TO EXCEL FILE
        public async Task<NotificationCity> postCreateCityByExcelFile(CreateFileCityEX request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);

            //if (request.fileExcelCity.Length > 0)
            //{

            //}

            //var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

            //using (var content = new MultipartFormDataContent())
            //{
            //    content.Add(new StreamContent(file.OpenReadStream())
            //    {
            //        Headers =
            //        {
            //            ContentLength = file.Length,
            //            ContentType = new MediaTypeHeaderValue(file.ContentType)
            //        }
            //    }, "File", fileName);

            //    var response = await client.PostAsync(_options.WebApiPortionOfUrl, content);
            //}

            var response = await client.PostAsync($"/api/City/CreateCityMultiline/");
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

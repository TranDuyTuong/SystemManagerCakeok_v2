using Library.ServiceAdmin.ServiceAdminInjection.City;
using Library.ViewModel.Admin.V_City;
using ManagerCakeOk_Api.Model.City_Model;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.ComponentModel;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace ManagerCakeOk_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CityController : Controller
    {
        private readonly ICitys _context;

        public CityController(ICitys context)
        {
            _context = context;
        }

        // TODO: API GET ALL CITY
        [HttpGet(Name ="GetAllCity")]
        public IActionResult GetAllCity(int PageSize, int PageIndex)
        {
            // TODO: GET DATA FROM DI
            var result = _context.GetAllCitys(); 

            // TODO: PADING CITY
            var listCity_GetAll = new GetAllCity_M();
            listCity_GetAll.TotalCity = result.Count();
            listCity_GetAll.l_City = result.Skip((PageIndex - 1)*PageSize).Take(PageSize).OrderBy(x => x.NameCity).ToList();

            return Ok(listCity_GetAll);
        }

        // TODO: API CREATE CITY
        [HttpPost(Name = "CreateCity")]
        public IActionResult CreateCity(string nameCity)
        {
            var request = new CreateCity()
            {
                NameCity = nameCity,
                Status = true
            };
            // TODO: CREATE CITY
            var result = _context.CreateCity(request);

            return Ok(result);
        }

        // TODO: API CREATE MULTILINE
        [HttpPost(Name = "CreateCityMultiline")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> CreateCityMultiline([FromForm] CreateFileCityEX request)
        {
            var resultModel = new NotificationCity();
            var L_City = new List<CreateCity>();
            IFormFile ExcelFile = request.fileExcelCity;
            string[] SplitFile = ExcelFile.FileName.Split('.');
            switch (SplitFile[1])
            {
                case "xlsx":
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    using (var stream = new MemoryStream())
                    {
                        await ExcelFile.CopyToAsync(stream);
                        using (var package = new ExcelPackage(stream))
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                            var rowcount = worksheet.Dimension.Rows;
                            for (int row = 2; row <= rowcount; row++)
                            {
                                L_City.Add(new CreateCity
                                {
                                    NameCity = worksheet.Cells[row, 1].Value.ToString().Trim(),
                                    Status = true
                                });
                            }
                        }

                    }
                    resultModel = _context.CreateMupliteCity(L_City);
                    break;
                default:
                    resultModel.Id = 1; // File Request is not File Excel
                    break;
            }
            return Ok(resultModel);
        }

        // TODO: API GET 10 CITY NEW
        [HttpGet(Name ="GetTenCityNew")]
        public IActionResult GetTenCityNew()
        {
            var result = _context.GetTenCityNew();
            return Ok(result);
        }

        // TODO: API SHOW INFOMATION EDIT CITY
        [HttpGet(Name ="GetEditCity")]
        public IActionResult GetEditCity(int idCity)
        {
            var result = _context.EditCityGet(idCity);
            return Ok(result);
        }

        // TODO: API POST EDIT CITY
        [HttpPost(Name = "PostEditCity")]
        public async Task<IActionResult> PostEditCity(int idCity, string nameCity)
        {
            var result = await _context.EditCityPost(idCity, nameCity);
            return Ok(result);
        }

        // TODO: API CHANGE STATUS CITY GET
        [HttpGet(Name = "GetChangeStatusCity")]
        public async Task<IActionResult> GetChangeStatusCity(int idCity)
        {
            var result = await _context.ChangeStatusCityGet(idCity);
            return Ok(result);
        }

        // TODO: API CHANGE STATUS CITY POST
        [HttpGet(Name = "PostChangeStatusCity")]
        public async Task<IActionResult> PostChangeStatusCity(int idCity, bool status)
        {
            var result = await _context.ChangeStatusPost(idCity, status);
            return Ok(result);
        }

        // TODO: API DETAIL CITY
        [HttpGet(Name = "DetailCity")]
        public async Task<IActionResult> DetailCity(int idCity)
        {
            var result = await _context.DetailCity(idCity);
            return Ok(result);
        }
    }
}

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
        [HttpGet(Name = "GetAllCity")]
        public IActionResult GetAllCity(int PageSize, int PageIndex, string Seach)
        {
            // TODO: GET DATA FROM DI
            var result = _context.GetAllCitys();

            // TODO: CHECK SEACH
            var listCity_GetAll = new GetAllCity_M();
            if (Seach == "ErrorNotSeach")
            {
                // TODO: PADING CITY
                listCity_GetAll.TotalCity = result.Count();
                listCity_GetAll.l_City = result.Skip((PageIndex - 1) * PageSize).Take(PageSize).OrderBy(x => x.NameCity).ToList();
            }
            else
            {
                var cityWasSeach = result.Where(x => x.NameCity.Contains(Seach));
                // TODO: PADING CITY
                listCity_GetAll.TotalCity = result.Count();
                listCity_GetAll.TotalSeachCity = cityWasSeach.Count();
                listCity_GetAll.l_City = cityWasSeach.Skip((PageIndex - 1) * PageSize).Take(PageSize).OrderBy(x => x.NameCity).ToList();
            }

            return Ok(listCity_GetAll);
        }

        // TODO: API CREATE CITY
        [HttpPost(Name = "CreateCity")]
        public IActionResult CreateCity([FromForm] CreateCity request)
        {
            request.Status = true;
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
                            for (int row = 3; row <= rowcount; row++)
                            {
                                L_City.Add(new CreateCity
                                {
                                    NameCity = worksheet.Cells[row, 2].Value.ToString().Trim(),
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
        [HttpGet(Name = "GetTenCityNew")]
        public IActionResult GetTenCityNew()
        {
            var result = _context.GetTenCityNew();
            return Ok(result);
        }

        // TODO: API SHOW INFOMATION EDIT CITY
        [HttpGet(Name = "GetEditCity")]
        public async Task<IActionResult> GetEditCity(int idCity)
        {
            var result = await _context.EditCityGet(idCity);
            return Ok(result);
        }

        // TODO: API POST EDIT CITY
        [HttpPost(Name = "PostEditCity")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> PostEditCity([FromForm] EditCity request)
        {
            // TODO: CONVER IDstr string to ID int
            request.Id = Convert.ToInt32(request.IdStr);
            request.Status = true;

            // TODO: SAVE IN TO DB
            var result = await _context.EditCityPost(request);
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
        public async Task<IActionResult> PostChangeStatusCity(int IdCity, bool Status)
        {
            var request = new EditCity()
            {
                Id = IdCity,
                Status = Status
            };
            var result = await _context.ChangeStatusPost(request);
            return Ok(result);
        }

        // TODO: API DETAIL CITY
        [HttpGet(Name = "DetailCity")]
        public async Task<IActionResult> DetailCity(int idCity, int pageIndex, int pageSize)
        {
            var result = await _context.DetailCity(idCity);

            // TODO: PADING DISTRICT BY ID CITY
            var modelResult = new DetailCity();
            modelResult.TotalDistrict = result.TotalDistrict;
            modelResult.L_District = result.L_District.Skip((pageIndex - 1)*pageSize).Take(pageSize).ToList();
            modelResult.Name = result.Name;
            modelResult.Status = result.Status;
            modelResult.Id = result.Id;

            return Ok(modelResult);
        }

        // TODO: API GET ALL CITY FOR SELECTION CREATE DISTRICT
        [HttpGet(Name = "GetAllCityForSelection")]
        public async Task<IActionResult> GetAllCityForSelection()
        {
            var query = _context.GetAllCitys();
            var result = query.Where(x => x.Status == true).OrderBy(x => x.NameCity).ToList();
            return Ok(result);

        }
    }
}

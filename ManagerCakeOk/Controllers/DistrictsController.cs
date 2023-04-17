using Library.ViewModel.Admin.V_City;
using Library.ViewModel.Admin.V_District;
using ManagerCakeOk.ConnectApi.InterfaceApi.IDistrict_DI;
using ManagerCakeOk.Models.M_Districts;
using Microsoft.AspNetCore.Mvc;

namespace ManagerCakeOk.Controllers
{
    public class DistrictsController : Controller
    {
        private readonly IDistrictService _context;
        public DistrictsController(IDistrictService context)
        {
            _context = context;
        }

        // TODO: GET ALL DISTRICT
        [HttpGet]
        public IActionResult PageDistrict()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDistrict(int pageIndex, int pageSize, string seach)
        {
            if(seach == null)
            {
                seach = "ErrorNotSeach";
            }
            var result = await _context.getAllDistrict(pageIndex, pageSize, seach);
            return new JsonResult(result);
        }

        // TODO: CREATE DISTRICT
        [HttpGet]
        public IActionResult CreateDistrict()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDistrict(int IdCity, string NameDistrict)
        {
            var request = new CreateDistrict()
            {
                IdCity = IdCity,
                Name = NameDistrict,
            };
            var result = await _context.createDistrict(request);
            return new JsonResult(result);
        }

        // TODO: GET ALL CITY HAVE STATUS IS TRUE FOR CREATE DISTRICT
        [HttpGet]
        public async Task<IActionResult> GetAllCityForCreateDistrict()
        {
            var result = await _context.getAllCitysForCreateDistrict();
            return new JsonResult(result);
        }

        // TODO: GET TEN DISTRICT NEW CREATE
        [HttpGet]
        public async Task<IActionResult> TenDistirctCreate()
        {
            var result = await _context.getTenDistrict();
            return new JsonResult(result);
        }

        // TODO: CRETAE DISTRICT WITH EXCEL FILE
        [HttpPost]
        public async Task<IActionResult> CreateDistrictExcelFile(ImportExcelFileDistrict request)
        {
            var formRequest = new CreateFileDistrictEX()
            {
                fileExcelDistrict = request.FileExcel
            };
            var result = await _context.postCreateDistrictByExcelFile(formRequest);
            return new JsonResult(result);
        }


    }
}

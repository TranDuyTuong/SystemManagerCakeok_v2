using Library.ViewModel.Admin.V_District;
using ManagerCakeOk.ConnectApi.InterfaceApi.IDistrict_DI;
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
            //var Request = new CreateDistrict()
            //{
            //    IdCity = IdCity,
            //    Name = NameDistrict,
            //    Status = true
            //};
            //var Result = await _context.CreateDitrist(Request);
            return new JsonResult(0);
        }

        // TODO: GET ALL CITY HAVE STATUS IS TRUE FOR CREATE DISTRICT
        [HttpGet]
        public async Task<IActionResult> GetAllCityForCreateDistrict()
        {
            var result = await _context.getAllCitysForCreateDistrict();
            return new JsonResult(result);
        }


    }
}

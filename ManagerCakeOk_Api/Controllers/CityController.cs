using Library.ServiceAdmin.ServiceAdminInjection.City;
using Library.ViewModel.Admin.V_City;
using ManagerCakeOk_Api.Model.City_Model;
using Microsoft.AspNetCore.Mvc;

namespace ManagerCakeOk_Api.Controllers
{
    [Route("api/[controller]")]
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
        [HttpPost(Name ="CreateCity")]
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

    }
}

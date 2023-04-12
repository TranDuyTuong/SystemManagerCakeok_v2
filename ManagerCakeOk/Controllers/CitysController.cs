using ManagerCakeOk.ConnectApi.InterfaceApi.ICity_DI;
using Microsoft.AspNetCore.Mvc;

namespace ManagerCakeOk.Controllers
{
    public class CitysController : Controller
    {
        private readonly ICityService context;
        public CitysController(ICityService _context)
        {
            context = _context;
        }

        // TODO: PAGE VIEW CITY
        [HttpGet]
        public IActionResult PageCity()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCitys(int Index, int Size)
        {
            var result = await context.getAllCitys(Index, Size);
            return new JsonResult(result);
        }
    }
}

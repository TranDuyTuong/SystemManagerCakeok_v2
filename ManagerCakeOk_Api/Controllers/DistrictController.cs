using Library.ServiceAdmin.ServiceAdminInjection.City;
using Library.ServiceAdmin.ServiceAdminInjection.District;
using ManagerCakeOk_Api.Model.District_Model;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Printing;

namespace ManagerCakeOk_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DistrictController : Controller
    {
        private readonly IDistrict _context;

        public DistrictController(IDistrict context)
        {
            _context = context;
        }

        // TODO: API GET ALL DISTRICT
        [HttpGet(Name = "GetAllDistrict")]
        public IActionResult GetAllDistrict(int pageSize, int pageIndex, string seach)
        {
            var result = _context.GetAllDistrict();
            // TODO: CHECK SEACH
            var listDistrict_GetAll = new GetAllDistrict_M();
            if (seach == "ErrorNotSeach")
            {
                // TODO: PADING CITY
                listDistrict_GetAll.TotalDistric = result.Count();
                listDistrict_GetAll.l_District = result.Skip((pageIndex - 1) * pageSize).Take(pageSize).OrderBy(x => x.Name).ToList();
            }
            else
            {
                var districtWasSeach = result.Where(x => x.Name.Contains(seach));
                // TODO: PADING CITY
                listDistrict_GetAll.TotalDistric = result.Count();
                listDistrict_GetAll.TotalSeachDistrict = districtWasSeach.Count();
                listDistrict_GetAll.l_District = districtWasSeach.Skip((pageIndex - 1) * pageSize).Take(pageSize).OrderBy(x => x.Name).ToList();
            }
            return Ok(listDistrict_GetAll);
        }

    }
}

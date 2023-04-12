using Library.ViewModel.Admin.V_City;
using ManagerCakeOk.ConnectApi.InterfaceApi.ICity_DI;
using ManagerCakeOk.Models.M_Citys;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

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
        public async Task<IActionResult> GetAllCitys(int Index, int Size, string Seach, int Sort)
        {
            // TODO: GET DATA FROM DI API
            var result = new GetAllCity_M();
            if (Seach != null)
            {
                result = await context.getAllCitys(Index, Size, Seach);
            }
            else
            {
                result = await context.getAllCitys(Index, Size, "ErrorNotSeach");
            }           

            // TODO: FUNCTION SORT
            var resultPading = new GetAllCity_M();

            resultPading.TotalCity = result.TotalCity;
            resultPading.TotalSeachCity = result.TotalSeachCity;
            List<GetAllCitys> L_Sort = new List<GetAllCitys>();
            switch (Sort)
            {
                case 1:
                    L_Sort = result.l_City.OrderByDescending(x => x.Id).ToList();
                    resultPading.l_City = L_Sort;
                    break;
                case -1:
                    L_Sort = result.l_City.OrderBy(x => x.Id).ToList();
                    resultPading.l_City = L_Sort;
                    break;
                case 2:
                    L_Sort = result.l_City.OrderByDescending(x => x.NameCity).ToList();
                    resultPading.l_City = L_Sort;
                    break;
                case -2:
                    L_Sort = result.l_City.OrderBy(x => x.NameCity).ToList();
                    resultPading.l_City = L_Sort;
                    break;
                default:
                    resultPading.l_City = result.l_City;
                    break;
            }
            return new JsonResult(resultPading);
        }

        // TODO: DETAIL CITY
        [HttpGet]
        public IActionResult PageDetailCity(int Id)
        {
            ViewBag.IdCity = Id;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> DetailCity(int Id, int PageSize, int PageIndex)
        {
            var result = await context.detailCity(Id, PageSize, PageIndex);
            return new JsonResult(result);
        }

        // TODO: EDIT CITY
        //Edit City
        [HttpGet]
        public async Task<IActionResult> PageEditCity(int Id)
        {
            var Result = await context.getEditCitys(Id);
            return new JsonResult(Result);
        }

        [HttpPost]
        public async Task<IActionResult> EditCity(int Id, string Name)
        {
            var result = await context.postEditCity(Id, Name);
            return new JsonResult(result);
        }

    }
}

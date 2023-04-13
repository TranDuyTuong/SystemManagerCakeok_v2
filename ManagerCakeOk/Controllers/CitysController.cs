using Library.ViewModel.Admin.V_City;
using ManagerCakeOk.ConnectApi.InterfaceApi.ICity_DI;
using ManagerCakeOk.Models.M_Citys;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
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

        // TODO: UPDATE STATUS CITY
        [HttpGet]
        public async Task<IActionResult> ChangeStatusCityGet(int Id)
        {
            var Request = await context.getUpdateStatusCity(Id);
            return new JsonResult(Request);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeStatusCity(int Id, int IdStatus)
        {
            bool Status;
            if (IdStatus == 1)
            {
                Status = true;
            }
            else
            {
                Status = false;
            }
            var Result = await context.postUpdateStatusCity(Id, Status);
            return new JsonResult(Result);
        }

        // TODO: CREATE CITY
        [HttpGet]
        public IActionResult PageCreateCity()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCity(string NameCity)
        {
            var C_City = new CreateCity();
            C_City.NameCity = NameCity;
            var result = await context.postCreateCity(C_City);
            return new JsonResult(result);
        }

        // TODO: CREATE MUPLTINE CITY FILE EXCEL
        [HttpPost]
        public async Task<IActionResult> CreateMupliteCity(ImportExcelFileCity request)
        {
            var formRequest = new CreateFileCityEX()
            {
                fileExcelCity = request.FileExcel
            };
            var result = await context.postCreateCityByExcelFile(formRequest);
            return new JsonResult(result);
        }

        // TODO: GET 10 CITY NEW
        [HttpGet]
        public async Task<IActionResult> GetTenCityNew()
        {
            var result = await context.getTennNewCity();
            return new JsonResult(result);
        }
    }
}

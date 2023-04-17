using Library.ServiceAdmin.ServiceAdminInjection.City;
using Library.ServiceAdmin.ServiceAdminInjection.District;
using Library.ViewModel.Admin.V_City;
using Library.ViewModel.Admin.V_District;
using ManagerCakeOk_Api.Model.District_Model;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
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

        // TODO: API CREATE DISTRICT
        [HttpPost(Name = "PostCreateDistrict")]
        [Consumes("multipart/form-data")]
        public IActionResult PostCreateDistrict([FromForm]CreateDistrict request)
        {
            request.IdCity = Convert.ToInt32(request.IdCityStr);
            request.Status = true;
            var result = _context.CreateDitrist(request);
            return Ok(result);
        }

        // TODO: API GET TEN DISTRICT
        [HttpGet(Name = "GetTenDistrict")]
        public IActionResult GetTenDistrict()
        {
            var result = _context.GetTenDistrict();
            return Ok(result);
        }

        // TODO: API CREATE MULTILINE
        [HttpPost(Name = "CreateDistrictMultiline")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> CreateDistrictMultiline([FromForm] CreateFileDistrictEX request)
        {
            var resultModel = new NotificationDistirct();
            var L_District = new List<CreateDistrict>();
            IFormFile ExcelFile = request.fileExcelDistrict;
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
                                string countId = worksheet.Cells[row, 2].Value.ToString().Trim();
                                L_District.Add(new CreateDistrict
                                {
                                    IdCity = Convert.ToInt32(countId),
                                    IdCityStr = worksheet.Cells[row, 2].Value.ToString().Trim(),
                                    Name = worksheet.Cells[row, 3].Value.ToString().Trim(),
                                    Status = true
                                });
                            }
                        }

                    }
                    resultModel = _context.CreateMupliteDistrict(L_District);
                    break;
                default:
                    resultModel.Id = 1; // File Request is not File Excel
                    break;
            }
            return Ok(resultModel);
        }


    }
}

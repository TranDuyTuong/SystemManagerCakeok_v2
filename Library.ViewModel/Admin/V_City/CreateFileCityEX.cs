using Library.ViewModel.Admin.V_Token;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModel.Admin.V_City
{
    public class CreateFileCityEX: TokenUser
    {
        public IFormFile fileExcelCity {  get; set; }
    }
}

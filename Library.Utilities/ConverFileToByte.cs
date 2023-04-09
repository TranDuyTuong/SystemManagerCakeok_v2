using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utilities
{
    public class ConverFileToByte
    {
        //convert IFromFile -> Bye[]
        public async Task<byte[]> ConverFromFileToByte(IFormFile request)
        {
            byte[] ImageConvert;
            using (var ms = new MemoryStream())
            {
                await request.CopyToAsync(ms);
                var FileByte = ms.ToArray();
                ImageConvert = FileByte;
            }
            return ImageConvert;
        }
    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Files
{
    public static class FileConversion
    {
        public static byte[] IformFileToMemoryStream(IFormFile file)
        {
            if (file.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    return fileBytes;
                }
            }
            else
            {
                return null;
            }
        }


        public static MemoryStream ByteToFileStream( byte[] bytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(bytes, 0, bytes.Length);
            return ms;  
        }

        public static string ConvertToBase64(byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }

    }
}

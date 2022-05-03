using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDTOs.LongFileDTOs
{
    public class LongFileInput_DTO
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        
        public IFormFile File { get; set; }
    }
}

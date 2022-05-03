using EntitiesDTOs.LongFileDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.LongFile
{
    public interface ILongFileService
    {
        public List<LongFileToReturn_DTO> GetAll();
        public bool PostLongFile(LongFileInput_DTO input_DTO);
    }
}

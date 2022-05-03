using Entities.LongFile;
using EntitiesDTOs.LongFileDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.LongFileRepo
{
    public interface ILongFileRepository
    {
        public LongFile PostLongFile(LongFileInput_DTO longFile);
        public List<LongFileToReturn_DTO> GetAll();
    }
}

using DataAccess.Repositories.LongFileRepo;
using EntitiesDTOs.LongFileDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.LongFile
{
    public class LongFileService : ILongFileService
    {
        private ILongFileRepository repo;
        public LongFileService(ILongFileRepository _repo)
        {
            repo = _repo;
        }

        public List<LongFileToReturn_DTO> GetAll()
        {
            return repo.GetAll();
            
        }

        public bool PostLongFile(LongFileInput_DTO input_DTO)
        {
            repo.PostLongFile(input_DTO);
            return true;
        }

    }
}

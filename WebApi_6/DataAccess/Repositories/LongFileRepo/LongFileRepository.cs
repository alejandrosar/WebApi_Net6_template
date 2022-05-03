using AutoMapper;
using DataAccess.Repositories.LongFileRepo.LongFileDBRepo;
using Entities.LongFile;
using EntitiesDTOs.LongFileDTOs;

namespace DataAccess.Repositories.LongFileRepo
{
    public class LongFileRepository : ILongFileRepository
    {
        private MariaDB_Context Context;
        private ILongFileMariaDBRepository repository;
        public readonly IMapper mapper;
        public LongFileRepository(MariaDB_Context _Context, ILongFileMariaDBRepository _repository, IMapper _mapper)
        {
            Context = _Context;
            repository = _repository;
            mapper = _mapper;
        }
        public LongFile PostLongFile(LongFileInput_DTO longFileDto)
        {
            var LongFile = mapper.Map<LongFile>(longFileDto);
            var a = repository.PostLongFile(Context, LongFile);
            Context.SaveChanges();
            return LongFile;
        }

        public List<LongFileToReturn_DTO> GetAll()
        {
            var result = repository.GetAll(Context);
            var toReturn = new List<LongFileToReturn_DTO>();
            foreach (var r in result)
            {
                toReturn.Add(mapper.Map<LongFileToReturn_DTO>(r));
            }
            return toReturn;
        }
    }
}

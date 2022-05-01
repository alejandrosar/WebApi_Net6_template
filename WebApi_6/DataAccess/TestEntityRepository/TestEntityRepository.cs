using AutoMapper;
using DataAccess.TestEntityRepository.TestEntityDbReposity;
using Entities.TestEntity;
using EntitiesDTOs.TestEntityDTOs;

namespace DataAccess.TestEntityRepository
{
    public class TestEntityRepository : ITestEntityRepository
    {
        public readonly IMapper mapper;
        private ITestEntityMariaDBRepository mariaDBRepository;
        MariaDB_Context context;
        public TestEntityRepository(MariaDB_Context _context, ITestEntityMariaDBRepository _mariaDBRepository, IMapper _mapper)
        {
            context = _context;
            mariaDBRepository = _mariaDBRepository;
            mapper = _mapper;
        }

        public List<TestEntityToReturn_DTO> GetAll()
        {
            var toReturn = mariaDBRepository.GetAll(context).Result;            
            return mapper.Map<List<TestEntityToReturn_DTO>>(toReturn);
        }

        public async Task<TestEntityToReturn_DTO> PostOne(TestEntityFullInput_DTO testEntityInput)
        {
            try
            {
                var testEntityMapped = mapper.Map<TestEntity>(testEntityInput);
                List<Task> tasks = new List<Task>();
                tasks.Add(mariaDBRepository.PostOne(context, testEntityMapped));

                Task.WaitAll(tasks.ToArray());

                await context.SaveChangesAsync();

                return mapper.Map<TestEntityToReturn_DTO>(testEntityMapped);
            }
            catch(Exception ex)
            {
                var stop = ex.Message;
                var a = stop;
                throw new Exception("sadfasdfa");
            }
            //User Tasks List in case you need more operations to add your entity
            

        }
    }
}

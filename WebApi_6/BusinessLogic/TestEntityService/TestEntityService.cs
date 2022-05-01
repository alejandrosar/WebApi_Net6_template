using DataAccess.TestEntityRepository;
using Entities.TestEntity;
using EntitiesDTOs.TestEntityDTOs;

namespace BusinessLogic.TestEntityService
{
    public class TestEntityService : ITestEntityService
    {
        private ITestEntityRepository repository;
        public TestEntityService(ITestEntityRepository _repository)
        {
            repository = _repository;
        }
        public List<TestEntityToReturn_DTO> GetAll()
        {
            return repository.GetAll();
        }

        public TestEntityToReturn_DTO PostOne(TestEntityFullInput_DTO testEntityInput)
        {
            var result = repository.PostOne(testEntityInput).Result;
            return result; 
        }
    }
}

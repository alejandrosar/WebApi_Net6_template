
using Entities.TestEntity;
using EntitiesDTOs.TestEntityDTOs;

namespace BusinessLogic.TestEntityService
{
    public interface ITestEntityService
    {
        public List<TestEntityToReturn_DTO> GetAll();
        public TestEntityToReturn_DTO PostOne(TestEntityFullInput_DTO testEntityInput);
    }
}

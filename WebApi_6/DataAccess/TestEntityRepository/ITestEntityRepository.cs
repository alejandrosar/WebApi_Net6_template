using Entities.TestEntity;
using EntitiesDTOs.TestEntityDTOs;

namespace DataAccess.TestEntityRepository
{
    public interface ITestEntityRepository
    {
        List<TestEntityToReturn_DTO> GetAll();
        Task<TestEntityToReturn_DTO> PostOne(TestEntityFullInput_DTO testEntityInput);
    }
}

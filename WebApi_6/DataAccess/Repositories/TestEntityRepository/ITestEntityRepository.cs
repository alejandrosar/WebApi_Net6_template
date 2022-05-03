using Entities.TestEntity;
using EntitiesDTOs.TestEntityDTOs;

namespace DataAccess.Repositories.TestEntityRepository
{
    public interface ITestEntityRepository
    {
        List<TestEntityToReturn_DTO> GetAll();
        Task<TestEntityToReturn_DTO> PostOne(TestEntityFullInput_DTO testEntityInput);
    }
}

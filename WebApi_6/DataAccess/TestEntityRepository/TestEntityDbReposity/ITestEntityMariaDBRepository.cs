using Entities.TestEntity;
using EntitiesDTOs.TestEntityDTOs;

namespace DataAccess.TestEntityRepository.TestEntityDbReposity
{
    public interface ITestEntityMariaDBRepository
    {
        Task<List<TestEntity>> GetAll(MariaDB_Context context);
        Task PostOne(MariaDB_Context context, TestEntity testEntityMapped);
    }
}

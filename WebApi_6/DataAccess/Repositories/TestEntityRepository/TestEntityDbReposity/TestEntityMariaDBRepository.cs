using Entities.TestEntity;
using EntitiesDTOs.TestEntityDTOs;
using Helpers.Exceptions.ContextExceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.TestEntityRepository.TestEntityDbReposity
{
    

    public class TestEntityMariaDBRepository : ITestEntityMariaDBRepository
    {
        
        
        public Task<List<TestEntity>> GetAll(MariaDB_Context context)
        {
            return Task.Run(() =>
            {
                try
                {
                    return context.TestEntities.ToListAsync();
                }catch (Exception ex)
                {
                    throw new TestEntityContext_Exception($"Error getting TestEntities in TestEntityMariaDBRepository.GetAll. Exception: {ex.Message}");
                }
            });
        }

        public Task PostOne(MariaDB_Context context, TestEntity toPost)
        {
            return Task.Run(async () =>
            {
                if (context.TestEntities.Any(x => x.Name + x.Surname == toPost.Name + toPost.Surname))
                    throw new TestEntityContext_Exception($"The register with {toPost.Name} and {toPost.Surname} already exists");

                await context.TestEntities.AddAsync(toPost);                
            });
        }
    }
}

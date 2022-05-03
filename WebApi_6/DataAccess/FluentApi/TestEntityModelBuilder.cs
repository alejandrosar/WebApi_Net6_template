using Entities.TestEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.FluentApi
{
    internal class TestEntityModelBuilder
    {
        internal static void TestEntityFluentApi(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestEntity>()
                    .HasKey(e => e.Id);
        }
    }
}

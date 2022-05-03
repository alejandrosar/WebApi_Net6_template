using DataAccess.FluentApi;
using Entities.LongFile;
using Entities.TestEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class MariaDB_Context : DbContext
    {
        protected readonly IConfiguration Configuration;
        public MariaDB_Context(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
            var connectionString = Configuration.GetConnectionString("WebApiDatabase");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            TestEntityModelBuilder.TestEntityFluentApi(modelBuilder);
            LongFileModelBuilder.LongFileFluentApi(modelBuilder);
        }

        

        public DbSet<TestEntity> TestEntities { get; set; }
        public DbSet<LongFile> LongFile { get; set; }
    }
}
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

            //Configure keys and relationships

            modelBuilder.Entity<TestEntity>()
                    .HasKey(e => e.Id);
            
        }


        public DbSet<TestEntity> TestEntities { get; set; }
    }
}
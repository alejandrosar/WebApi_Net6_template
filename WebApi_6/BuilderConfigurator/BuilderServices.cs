using BusinessLogic.TestEntityService;
using DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BuilderConfigurator
{
    public class BuilderServices
    {
        public static WebApplication AddServiceDependencies(WebApplicationBuilder builder)
        {
            var services = builder.Services;
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddDbContext<MariaDB_Context>();
            

            RepositoryServicesInjection.Inject(services);
            
            //TODO: see how to load maps from Helpers project
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return builder.Build();
        }
    }
}

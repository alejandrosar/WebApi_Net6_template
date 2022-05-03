using BusinessLogic.LongFile;
using BusinessLogic.TestEntityService;
using DataAccess.Repositories.LongFileRepo;
using DataAccess.Repositories.LongFileRepo.LongFileDBRepo;
using DataAccess.Repositories.TestEntityRepository;
using DataAccess.Repositories.TestEntityRepository.TestEntityDbReposity;
using Microsoft.Extensions.DependencyInjection;


namespace BuilderConfigurator
{
    internal class RepositoryServicesInjection
    {

        internal static void Inject(IServiceCollection services)
        {
            services.AddScoped<ITestEntityService, TestEntityService>();
            services.AddScoped<ITestEntityRepository, TestEntityRepository>();
            services.AddScoped<ITestEntityMariaDBRepository, TestEntityMariaDBRepository>();

            services.AddScoped<ILongFileService, LongFileService>();
            services.AddScoped<ILongFileRepository, LongFileRepository>();
            services.AddScoped<ILongFileMariaDBRepository, LongFileMariaDBRepository>();
        }

    }
}

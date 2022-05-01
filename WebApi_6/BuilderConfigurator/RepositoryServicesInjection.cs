using DataAccess.TestEntityRepository;
using DataAccess.TestEntityRepository.TestEntityDbReposity;
using Microsoft.Extensions.DependencyInjection;


namespace BuilderConfigurator
{
    internal class RepositoryServicesInjection
    {

        internal static void Inject(IServiceCollection services)
        {
            services.AddScoped<ITestEntityRepository, TestEntityRepository>();
            services.AddScoped<ITestEntityMariaDBRepository, TestEntityMariaDBRepository>();
        }

    }
}

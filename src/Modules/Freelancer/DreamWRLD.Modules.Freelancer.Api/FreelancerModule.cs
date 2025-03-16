using DreamWRLD.Modules.Freelancer.Core;
using DreamWRLD.Modules.Freelancer.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DreamWRLD.Modules.Freelancer.Api;

public static class FreelancerModule
{
    public static IServiceCollection AddFreelancerModule(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddCore()
            .AddInfrastructure();

        return services;
    }
}
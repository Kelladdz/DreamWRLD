using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("DreamWRLD.Modules.Freelancer.Api")]

namespace DreamWRLD.Modules.Freelancer.Infrastructure;

internal static class Registration
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services;
    }
}
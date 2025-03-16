using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("DreamWRLD.Modules.Freelancer.Api")]

namespace DreamWRLD.Modules.Freelancer.Core;

internal static class Registration
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        return services;
    }
}
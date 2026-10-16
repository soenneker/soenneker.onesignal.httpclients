using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.OneSignal.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.OneSignal.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class OneSignalOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="OneSignalOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddOneSignalOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IOneSignalOpenApiHttpClient, OneSignalOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="OneSignalOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddOneSignalOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IOneSignalOpenApiHttpClient, OneSignalOpenApiHttpClient>();

        return services;
    }
}

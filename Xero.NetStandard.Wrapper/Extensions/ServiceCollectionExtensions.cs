using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Config;
using Xero.NetStandard.Wrapper.Models;
using Microsoft.Extensions.Options;
using Xero.NetStandard.Wrapper;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static void AddXeroNetStandardWrapper(this IServiceCollection services, Action<ExtendedXeroConfiguration> extendedXeroConfiguration)
    {
        services.Configure(extendedXeroConfiguration);
        services.AddSingleton(sp => sp.GetRequiredService<IOptions<ExtendedXeroConfiguration>>().Value);
        services.AddSingleton<XeroConfiguration>(sp => sp.GetRequiredService<ExtendedXeroConfiguration>());
        services.AddXeroWrapperDefaults();
    }

    public static void AddXeroNetStandardWrapper<T>(this IServiceCollection services, Action<ExtendedXeroConfiguration<T>> extendedXeroConfiguration)
    {
        services.Configure(extendedXeroConfiguration);
        services.AddSingleton(sp => sp.GetRequiredService<IOptions<ExtendedXeroConfiguration<T>>>().Value);
        services.AddSingleton<XeroConfiguration>(sp => sp.GetRequiredService<ExtendedXeroConfiguration<T>>());
        services.AddXeroWrapperDefaults();
    }

    private static void AddXeroWrapperDefaults(this IServiceCollection services)
    {
        services.AddMemoryCache();
        services.AddHttpClient();
        services.AddScoped<IXeroClient, XeroClient>();
        services.AddScoped<IAccountingApi, AccountingApi>();
        services.AddSingleton<XeroCache>();
        services.AddScoped<XeroService>();
    }
}

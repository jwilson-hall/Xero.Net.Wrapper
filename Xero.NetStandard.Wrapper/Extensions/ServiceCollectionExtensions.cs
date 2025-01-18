using Microsoft.Extensions.DependencyInjection;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Config;

namespace Microsoft.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddXeroNetStandardWrapper(this IServiceCollection services, Action<XeroConfiguration> xeroConfiguration)
    {
        services.AddSingleton(xeroConfiguration);
        services.AddScoped<IXeroClient, XeroClient>();
    }
}

﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Xero.Net.Wrapper.Api;
using Xero.Net.Wrapper.Models;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Config;

namespace Xero.Net.Wrapper.Extensions;

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
        services.AddScoped<IAppStoreApi, AppStoreApi>();
        services.AddScoped<IAssetApi, AssetApi>();
        services.AddScoped<IBankFeedsApi, BankFeedsApi>();
        services.AddScoped<IFilesApi, FilesApi>();
        services.AddScoped<IFinanceApi, FinanceApi>();
        services.AddScoped<IIdentityApi, IdentityApi>();
        services.AddScoped<IPayrollAuApi, PayrollAuApi>();
        services.AddScoped<IPayrollNzApi, PayrollNzApi>();
        services.AddScoped<IPayrollUkApi, PayrollUkApi>();

        services.AddSingleton<XeroCache>();
        services.AddScoped<XeroService>();
    }
}

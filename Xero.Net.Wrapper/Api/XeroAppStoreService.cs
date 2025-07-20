using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Appstore;

namespace Xero.Net.Wrapper.Api;

public partial class XeroService : IAppStoreApi
{
    public async Task<Subscription> GetSubscriptionAsync(CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetSubscriptionAsync(cancellationToken);
    }

    public async Task<Subscription> GetSubscriptionAsync(string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default)
    {
        ApiResponse<Subscription> response = await GetSubscriptionAsyncWithHttpInfo(accessToken, subscriptionId, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Subscription>> GetSubscriptionAsyncWithHttpInfo(string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default)
    {
        ApiResponse<Subscription> response = await appStoreXeroClient.GetSubscriptionAsyncWithHttpInfo(accessToken, subscriptionId, cancellationToken);
        return response;
    }
    public async Task<UsageRecordsList> GetUsageRecordsAsync(CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetUsageRecordsAsync(cancellationToken);
    }

    public async Task<UsageRecordsList> GetUsageRecordsAsync(string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default)
    {
        ApiResponse<UsageRecordsList> response = await GetUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<UsageRecordsList>> GetUsageRecordsAsyncWithHttpInfo(string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default)
    {
        ApiResponse<UsageRecordsList> response = await appStoreXeroClient.GetUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, cancellationToken);
        return response;
    }

    public async Task<UsageRecord> PostUsageRecordsAsync(Guid subscriptionItemId, CreateUsageRecord createUsageRecord, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PostUsageRecordsAsync(subscriptionItemId, createUsageRecord, idempotencyKey, cancellationToken);
    }

    public async Task<UsageRecord> PostUsageRecordsAsync(string accessToken, Guid subscriptionId, Guid subscriptionItemId, CreateUsageRecord createUsageRecord, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<UsageRecord> response = await PostUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, subscriptionItemId, createUsageRecord, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<UsageRecord>> PostUsageRecordsAsyncWithHttpInfo(string accessToken, Guid subscriptionId, Guid subscriptionItemId, CreateUsageRecord createUsageRecord, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<UsageRecord> response = await appStoreXeroClient.PostUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, subscriptionItemId, createUsageRecord, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<UsageRecord> PutUsageRecordsAsync(Guid subscriptionId, Guid subscriptionItemId, Guid usageRecordId, UpdateUsageRecord updateUsageRecord, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PutUsageRecordsAsync(accessToken, subscriptionId, subscriptionItemId, usageRecordId, updateUsageRecord, idempotencyKey, cancellationToken);
    }

    public async Task<UsageRecord> PutUsageRecordsAsync(string accessToken, Guid subscriptionId, Guid subscriptionItemId, Guid usageRecordId, UpdateUsageRecord updateUsageRecord, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<UsageRecord> response = await PutUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, subscriptionItemId, usageRecordId, updateUsageRecord, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<UsageRecord>> PutUsageRecordsAsyncWithHttpInfo(string accessToken, Guid subscriptionId, Guid subscriptionItemId, Guid usageRecordId, UpdateUsageRecord updateUsageRecord, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<UsageRecord> response = await appStoreXeroClient.PutUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, subscriptionItemId, usageRecordId, updateUsageRecord, idempotencyKey, cancellationToken);
        return response;
    }
}
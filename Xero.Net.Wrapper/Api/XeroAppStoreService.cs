using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Appstore;

namespace Xero.Net.Wrapper.Api;

public partial class XeroService : IAppStoreApi
{
    public async Task<Subscription> GetSubscriptionAsync(Guid subscriptionId, CancellationToken cancellationToken = default)
    {
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await GetSubscriptionAsync(accessToken, subscriptionId, cancellationToken);
    }

    public async Task<Subscription> GetSubscriptionAsync(string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default)
    {
        ApiResponse<Subscription> response = await GetSubscriptionAsyncWithHttpInfo(accessToken, subscriptionId, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<Subscription>> GetSubscriptionAsyncWithHttpInfo(Guid subscriptionId, CancellationToken cancellationToken = default)
    {
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await GetSubscriptionAsyncWithHttpInfo(accessToken, subscriptionId, cancellationToken);
    }

    public async Task<ApiResponse<Subscription>> GetSubscriptionAsyncWithHttpInfo(string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default)
    {
        ApiResponse<Subscription> response = await appStoreXeroClient.GetSubscriptionAsyncWithHttpInfo(accessToken, subscriptionId, cancellationToken);
        return response;
    }
    public async Task<UsageRecordsList> GetUsageRecordsAsync(Guid subscriptionId, CancellationToken cancellationToken = default)
    {
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await GetUsageRecordsAsync(accessToken, subscriptionId, cancellationToken);
    }

    public async Task<UsageRecordsList> GetUsageRecordsAsync(string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default)
    {
        ApiResponse<UsageRecordsList> response = await GetUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<UsageRecordsList>> GetUsageRecordsAsyncWithHttpInfo(Guid subscriptionId, CancellationToken cancellationToken = default)
    {
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await GetUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, cancellationToken);
    }

    public async Task<ApiResponse<UsageRecordsList>> GetUsageRecordsAsyncWithHttpInfo(string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default)
    {
        ApiResponse<UsageRecordsList> response = await appStoreXeroClient.GetUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, cancellationToken);
        return response;
    }

    public async Task<UsageRecord> PostUsageRecordsAsync(Guid subscriptionId, Guid subscriptionItemId, CreateUsageRecord createUsageRecord, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PostUsageRecordsAsync(accessToken, subscriptionId, subscriptionItemId, createUsageRecord, idempotencyKey, cancellationToken);
    }

    public async Task<UsageRecord> PostUsageRecordsAsync(string accessToken, Guid subscriptionId, Guid subscriptionItemId, CreateUsageRecord createUsageRecord, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<UsageRecord> response = await PostUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, subscriptionItemId, createUsageRecord, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<UsageRecord>> PostUsageRecordsAsyncWithHttpInfo(Guid subscriptionId, Guid subscriptionItemId, CreateUsageRecord createUsageRecord, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PostUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, subscriptionItemId, createUsageRecord, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<UsageRecord>> PostUsageRecordsAsyncWithHttpInfo(string accessToken, Guid subscriptionId, Guid subscriptionItemId, CreateUsageRecord createUsageRecord, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<UsageRecord> response = await appStoreXeroClient.PostUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, subscriptionItemId, createUsageRecord, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<UsageRecord> PutUsageRecordsAsync(Guid subscriptionId, Guid subscriptionItemId, Guid usageRecordId, UpdateUsageRecord updateUsageRecord, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PutUsageRecordsAsync(accessToken, subscriptionId, subscriptionItemId, usageRecordId, updateUsageRecord, idempotencyKey, cancellationToken);
    }

    public async Task<UsageRecord> PutUsageRecordsAsync(string accessToken, Guid subscriptionId, Guid subscriptionItemId, Guid usageRecordId, UpdateUsageRecord updateUsageRecord, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<UsageRecord> response = await PutUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, subscriptionItemId, usageRecordId, updateUsageRecord, idempotencyKey, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<UsageRecord>> PutUsageRecordsAsyncWithHttpInfo(Guid subscriptionId, Guid subscriptionItemId, Guid usageRecordId, UpdateUsageRecord updateUsageRecord, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PutUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, subscriptionItemId, usageRecordId, updateUsageRecord, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<UsageRecord>> PutUsageRecordsAsyncWithHttpInfo(string accessToken, Guid subscriptionId, Guid subscriptionItemId, Guid usageRecordId, UpdateUsageRecord updateUsageRecord, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<UsageRecord> response = await appStoreXeroClient.PutUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, subscriptionItemId, usageRecordId, updateUsageRecord, idempotencyKey, cancellationToken);
        return response;
    }

    string IApiAccessor.GetBasePath()
    {
        return appStoreXeroClient.GetBasePath();
    }

    IReadableConfiguration IApiAccessor.Configuration 
    { 
        get => ((IApiAccessor)appStoreXeroClient).Configuration;
        set => ((IApiAccessor)appStoreXeroClient).Configuration = value;
    }

    ExceptionFactory IApiAccessor.ExceptionFactory
    {
        get => ((IApiAccessor)appStoreXeroClient).ExceptionFactory;
        set => ((IApiAccessor)appStoreXeroClient).ExceptionFactory = value;
    }

    Task<Subscription> IAppStoreApiAsync.GetSubscriptionAsync(string accessToken, Guid subscriptionId, CancellationToken cancellationToken)
    {
        return GetSubscriptionAsync(accessToken, subscriptionId, cancellationToken);
    }

    Task<ApiResponse<Subscription>> IAppStoreApiAsync.GetSubscriptionAsyncWithHttpInfo(string accessToken, Guid subscriptionId, CancellationToken cancellationToken)
    {
        return GetSubscriptionAsyncWithHttpInfo(accessToken, subscriptionId, cancellationToken);
    }

    Task<UsageRecordsList> IAppStoreApiAsync.GetUsageRecordsAsync(string accessToken, Guid subscriptionId, CancellationToken cancellationToken)
    {
        return GetUsageRecordsAsync(accessToken, subscriptionId, cancellationToken);
    }

    Task<ApiResponse<UsageRecordsList>> IAppStoreApiAsync.GetUsageRecordsAsyncWithHttpInfo(string accessToken, Guid subscriptionId, CancellationToken cancellationToken)
    {
        return GetUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, cancellationToken);
    }

    Task<UsageRecord> IAppStoreApiAsync.PostUsageRecordsAsync(string accessToken, Guid subscriptionId, Guid subscriptionItemId, CreateUsageRecord createUsageRecord, string idempotencyKey, CancellationToken cancellationToken)
    {
        return PostUsageRecordsAsync(accessToken, subscriptionId, subscriptionItemId, createUsageRecord, idempotencyKey, cancellationToken);
    }

    Task<ApiResponse<UsageRecord>> IAppStoreApiAsync.PostUsageRecordsAsyncWithHttpInfo(string accessToken, Guid subscriptionId, Guid subscriptionItemId, CreateUsageRecord createUsageRecord, string idempotencyKey, CancellationToken cancellationToken)
    {
        return PostUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, subscriptionItemId, createUsageRecord, idempotencyKey, cancellationToken);
    }

    Task<UsageRecord> IAppStoreApiAsync.PutUsageRecordsAsync(string accessToken, Guid subscriptionId, Guid subscriptionItemId, Guid usageRecordId, UpdateUsageRecord updateUsageRecord, string idempotencyKey, CancellationToken cancellationToken)
    {
        return PutUsageRecordsAsync(accessToken, subscriptionId, subscriptionItemId, usageRecordId, updateUsageRecord, idempotencyKey, cancellationToken);
    }

    Task<ApiResponse<UsageRecord>> IAppStoreApiAsync.PutUsageRecordsAsyncWithHttpInfo(string accessToken, Guid subscriptionId, Guid subscriptionItemId, Guid usageRecordId, UpdateUsageRecord updateUsageRecord, string idempotencyKey, CancellationToken cancellationToken)
    {
        return PutUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, subscriptionItemId, usageRecordId, updateUsageRecord, idempotencyKey, cancellationToken);
    }
}
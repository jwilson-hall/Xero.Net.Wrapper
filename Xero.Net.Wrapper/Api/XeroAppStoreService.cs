using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Appstore;

public partial class XeroService : IAppStoreApi
{
    public IReadableConfiguration Configuration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public ExceptionFactory ExceptionFactory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public string GetBasePath()
    {
        throw new NotImplementedException();
    }

    public Task<Subscription> GetSubscriptionAsync(string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Subscription>> GetSubscriptionAsyncWithHttpInfo(string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<UsageRecordsList> GetUsageRecordsAsync(string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<UsageRecordsList>> GetUsageRecordsAsyncWithHttpInfo(string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<UsageRecord> PostUsageRecordsAsync(string accessToken, Guid subscriptionId, Guid subscriptionItemId, CreateUsageRecord createUsageRecord, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<UsageRecord>> PostUsageRecordsAsyncWithHttpInfo(string accessToken, Guid subscriptionId, Guid subscriptionItemId, CreateUsageRecord createUsageRecord, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<UsageRecord> PutUsageRecordsAsync(string accessToken, Guid subscriptionId, Guid subscriptionItemId, Guid usageRecordId, UpdateUsageRecord updateUsageRecord, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<UsageRecord>> PutUsageRecordsAsyncWithHttpInfo(string accessToken, Guid subscriptionId, Guid subscriptionItemId, Guid usageRecordId, UpdateUsageRecord updateUsageRecord, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
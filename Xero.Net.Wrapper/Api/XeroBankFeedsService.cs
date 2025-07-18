using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Bankfeeds;

public partial class XeroService : IBankFeedsApi
{
    public Task<FeedConnections> CreateFeedConnectionsAsync(string accessToken, string xeroTenantId, FeedConnections feedConnections, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<FeedConnections>> CreateFeedConnectionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, FeedConnections feedConnections, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Statements> CreateStatementsAsync(string accessToken, string xeroTenantId, Statements statements, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Statements>> CreateStatementsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Statements statements, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<FeedConnections> DeleteFeedConnectionsAsync(string accessToken, string xeroTenantId, FeedConnections feedConnections, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<FeedConnections>> DeleteFeedConnectionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, FeedConnections feedConnections, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<FeedConnection> GetFeedConnectionAsync(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<FeedConnection>> GetFeedConnectionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<FeedConnections> GetFeedConnectionsAsync(string accessToken, string xeroTenantId, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<FeedConnections>> GetFeedConnectionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Statement> GetStatementAsync(string accessToken, string xeroTenantId, Guid statementId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Statement>> GetStatementAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid statementId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Statements> GetStatementsAsync(string accessToken, string xeroTenantId, int? page = null, int? pageSize = null, string xeroApplicationId = null, string xeroUserId = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Statements>> GetStatementsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, int? pageSize = null, string xeroApplicationId = null, string xeroUserId = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}

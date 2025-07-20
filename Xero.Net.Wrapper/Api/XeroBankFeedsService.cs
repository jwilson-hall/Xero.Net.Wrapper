using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Bankfeeds;

namespace Xero.Net.Wrapper.Api;

public partial class XeroService : IBankFeedsApi
{
    public async Task<FeedConnections> CreateFeedConnectionsAsync(FeedConnections feedConnections, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateFeedConnectionsAsync(accessToken, xeroExtendedConfiguration.TenantId, feedConnections, idempotencyKey, cancellationToken);
    }

    public async Task<FeedConnections> CreateFeedConnectionsAsync(string accessToken, string xeroTenantId, FeedConnections feedConnections, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<FeedConnections> response = await CreateFeedConnectionsAsyncWithHttpInfo(accessToken, xeroTenantId, feedConnections, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<FeedConnections>> CreateFeedConnectionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, FeedConnections feedConnections, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<FeedConnections> response = await bankFeedXeroClient.CreateFeedConnectionsAsyncWithHttpInfo(accessToken, xeroTenantId, feedConnections, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<Statements> CreateStatementsAsync(Statements statements, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateStatementsAsync(accessToken, xeroExtendedConfiguration.TenantId, statements, idempotencyKey, cancellationToken);
    }


    public async Task<Statements> CreateStatementsAsync(string accessToken, string xeroTenantId, Statements statements, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Statements> response = await CreateStatementsAsyncWithHttpInfo(accessToken, xeroTenantId, statements, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Statements>> CreateStatementsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Statements statements, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Statements> response = await bankFeedXeroClient.CreateStatementsAsyncWithHttpInfo(accessToken, xeroTenantId, statements, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<FeedConnections> DeleteFeedConnectionsAsync(FeedConnections feedConnections, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteFeedConnectionsAsync(accessToken, xeroExtendedConfiguration.TenantId, feedConnections, idempotencyKey, cancellationToken);
    }

    public async Task<FeedConnections> DeleteFeedConnectionsAsync(string accessToken, string xeroTenantId, FeedConnections feedConnections, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<FeedConnections> response = await DeleteFeedConnectionsAsyncWithHttpInfo(accessToken, xeroTenantId, feedConnections, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<FeedConnections>> DeleteFeedConnectionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, FeedConnections feedConnections, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<FeedConnections> response = await bankFeedXeroClient.DeleteFeedConnectionsAsyncWithHttpInfo(accessToken, xeroTenantId, feedConnections, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<FeedConnection> GetFeedConnectionAsync(Guid id, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFeedConnectionAsync(accessToken, xeroExtendedConfiguration.TenantId, id, cancellationToken);
    }

    public async Task<FeedConnection> GetFeedConnectionAsync(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
    {
        ApiResponse<FeedConnection> response = await GetFeedConnectionAsyncWithHttpInfo(accessToken, xeroTenantId, id, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<FeedConnection>> GetFeedConnectionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
    {
        ApiResponse<FeedConnection> response = await bankFeedXeroClient.GetFeedConnectionAsyncWithHttpInfo(accessToken, xeroTenantId, id, cancellationToken);
        return response;
    }

    public async Task<FeedConnections> GetFeedConnectionsAsync(int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFeedConnectionsAsync(accessToken, xeroExtendedConfiguration.TenantId, page, pageSize, cancellationToken);
    }

    public async Task<FeedConnections> GetFeedConnectionsAsync(string accessToken, string xeroTenantId, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<FeedConnections> response = await GetFeedConnectionsAsyncWithHttpInfo(accessToken, xeroTenantId, page, pageSize, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<FeedConnections>> GetFeedConnectionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<FeedConnections> response = await bankFeedXeroClient.GetFeedConnectionsAsyncWithHttpInfo(accessToken, xeroTenantId, page, pageSize, cancellationToken);
        return response;
    }
    public async Task<Statement> GetStatementAsync(Guid statementId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetStatementAsync(accessToken, xeroExtendedConfiguration.TenantId, statementId, cancellationToken);
    }

    public async Task<Statement> GetStatementAsync(string accessToken, string xeroTenantId, Guid statementId, CancellationToken cancellationToken = default)
    {
        ApiResponse<Statement> response = await GetStatementAsyncWithHttpInfo(accessToken, xeroTenantId, statementId, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Statement>> GetStatementAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid statementId, CancellationToken cancellationToken = default)
    {
        ApiResponse<Statement> response = await bankFeedXeroClient.GetStatementAsyncWithHttpInfo(accessToken, xeroTenantId, statementId, cancellationToken);
        return response;
    }

    public async Task<Statements> GetStatementsAsync(int? page = null, int? pageSize = null, string? xeroApplicationId = null, string? xeroUserId = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetStatementsAsync(accessToken, xeroExtendedConfiguration.TenantId, page, pageSize, xeroApplicationId, xeroUserId, cancellationToken);
    }

    public async Task<Statements> GetStatementsAsync(string accessToken, string xeroTenantId, int? page = null, int? pageSize = null, string? xeroApplicationId = null, string? xeroUserId = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Statements> response = await GetStatementsAsyncWithHttpInfo(accessToken, xeroTenantId, page, pageSize, xeroApplicationId, xeroUserId, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Statements>> GetStatementsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, int? pageSize = null, string? xeroApplicationId = null, string? xeroUserId = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Statements> response = await bankFeedXeroClient.GetStatementsAsyncWithHttpInfo(accessToken, xeroTenantId, page, pageSize, xeroApplicationId, xeroUserId, cancellationToken);
        return response;
    }
}

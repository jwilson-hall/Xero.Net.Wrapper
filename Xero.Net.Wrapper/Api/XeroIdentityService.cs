using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Identity;

namespace Xero.Net.Wrapper.Api;

public partial class XeroService : IIdentityApi
{
    public async Task DeleteConnectionAsync(Guid id, CancellationToken cancellationToken = default)
    {
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        await DeleteConnectionAsync(accessToken, id, cancellationToken);
    }

    public async Task DeleteConnectionAsync(string accessToken, Guid id, CancellationToken cancellationToken = default)
    {
        ApiResponse<object> response = await DeleteConnectionAsyncWithHttpInfo(accessToken, id, cancellationToken);
    }

    public async Task<ApiResponse<object>> DeleteConnectionAsyncWithHttpInfo(Guid id, CancellationToken cancellationToken = default)
    {
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await identityXeroClient.DeleteConnectionAsyncWithHttpInfo(accessToken, id, cancellationToken);
    }

    public Task<ApiResponse<object>> DeleteConnectionAsyncWithHttpInfo(string accessToken, Guid id, CancellationToken cancellationToken = default)
    {
        return identityXeroClient.DeleteConnectionAsyncWithHttpInfo(accessToken, id, cancellationToken);
    }

    public async Task<List<Connection>> GetConnectionsAsync(Guid? authEventId = null, CancellationToken cancellationToken = default)
    {
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetConnectionsAsync(accessToken, authEventId, cancellationToken);
    }

    public async Task<List<Connection>> GetConnectionsAsync(string accessToken, Guid? authEventId = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<List<Connection>> response = await GetConnectionsAsyncWithHttpInfo(accessToken, authEventId, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<List<Connection>>> GetConnectionsAsyncWithHttpInfo(Guid? authEventId = null, CancellationToken cancellationToken = default)
    {
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await identityXeroClient.GetConnectionsAsyncWithHttpInfo(accessToken, authEventId, cancellationToken);
    }

    public Task<ApiResponse<List<Connection>>> GetConnectionsAsyncWithHttpInfo(string accessToken, Guid? authEventId = null, CancellationToken cancellationToken = default)
    {
        return identityXeroClient.GetConnectionsAsyncWithHttpInfo(accessToken, authEventId, cancellationToken);
    }
}

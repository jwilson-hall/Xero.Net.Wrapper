using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Identity;

namespace Xero.Net.Wrapper.Api;

public partial class XeroService : IIdentityApi
{
    public Task DeleteConnectionAsync(string accessToken, Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<object>> DeleteConnectionAsyncWithHttpInfo(string accessToken, Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<List<Connection>> GetConnectionsAsync(string accessToken, Guid? authEventId = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<List<Connection>>> GetConnectionsAsyncWithHttpInfo(string accessToken, Guid? authEventId = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}

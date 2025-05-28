using Xero.Net.Wrapper.Models;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Config;
using Xero.NetStandard.OAuth2.Models;
using Xero.NetStandard.OAuth2.Token;

namespace Xero.Net.Wrapper;
/// <summary>
/// Base api
/// </summary>
/// <param name="config"></param>
/// <param name="_xeroConfiguration"></param>
/// <param name="xeroCache"></param>
/// <param name="baseXeroClient"></param>
/// <param name="accountingXeroClient"></param>
public partial class XeroService(ExtendedXeroConfiguration xeroExtendedConfiguration, XeroConfiguration _xeroConfiguration, XeroCache xeroCache, IXeroClient baseXeroClient, IAccountingApi accountingXeroClient) : IXeroClient
{
    public XeroConfiguration xeroConfiguration { get; set; } = _xeroConfiguration;

    #region NotImplemented
    public string BuildLoginUri()
    {
        throw new NotImplementedException();
    }

    public string BuildLoginUri(string state)
    {
        throw new NotImplementedException();
    }

    public string BuildLoginUri(string state, string scope)
    {
        throw new NotImplementedException();
    }

    public string BuildLoginUriPkce(string codeVerifier)
    {
        throw new NotImplementedException();
    }

    public string BuildLoginUriPkce(string codeVerifier, string state)
    {
        throw new NotImplementedException();
    }

    public string BuildLoginUriPkce(string codeVerifier, string state, string scope)
    {
        throw new NotImplementedException();
    }

    public Task DeleteConnectionAsync(IXeroToken xeroToken, Tenant xeroTenant)
    {
        throw new NotImplementedException();
    }

    public Task<List<Tenant>> GetConnectionsAsync(IXeroToken xeroToken)
    {
        throw new NotImplementedException();
    }

    public Task<IXeroToken> GetCurrentValidTokenAsync(IXeroToken xeroToken)
    {
        throw new NotImplementedException();
    }

    public Task<IXeroToken> RefreshAccessTokenAsync(IXeroToken xeroToken)
    {
        throw new NotImplementedException();
    }

    public Task<IXeroToken> RequestAccessTokenAsync(string code)
    {
        throw new NotImplementedException();
    }

    public Task<IXeroToken> RequestAccessTokenPkceAsync(string code, string codeVerifier)
    {
        throw new NotImplementedException();
    }
    #endregion
    public async Task<IXeroToken> RequestClientCredentialsTokenAsync(bool fetchTenants = false)
    {
        IXeroToken? xeroToken;
        bool tokenNotFound = !(xeroCache.TryGetValue("ClientCredentialsToken", out xeroToken));

        if (tokenNotFound || xeroExtendedConfiguration.DisableTokenCaching)
        {
            xeroToken = await baseXeroClient.RequestClientCredentialsTokenAsync(fetchTenants);
            var timeToExpiry = xeroToken.ExpiresAtUtc - DateTime.UtcNow;

            xeroCache.Set("ClientCredentialsToken", xeroToken, timeToExpiry);
        }

        return xeroToken ?? throw new InvalidOperationException("Failed to retrieve the client credentials token.");
    }
    public async Task RevokeAccessTokenAsync(string key)
    {
        if (xeroCache.TryGetValue(key, out IXeroToken? token))
        {
            await RevokeAccessTokenAsync(token!);
        }
    }

    public async Task RevokeAccessTokenAsync(IXeroToken xeroToken)
    {
        if (xeroToken == null)
        {
            throw new ArgumentNullException(nameof(xeroToken));
        }

        await baseXeroClient.RevokeAccessTokenAsync(xeroToken);
    }
}

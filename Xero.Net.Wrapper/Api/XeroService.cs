using Xero.Net.Wrapper.Models;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Config;
using Xero.NetStandard.OAuth2.Models;
using Xero.NetStandard.OAuth2.Token;

namespace Xero.Net.Wrapper.Api;
/// <summary>
/// Base api
/// </summary>
/// <param name="config"></param>
/// <param name="_xeroConfiguration"></param>
/// <param name="xeroCache"></param>
/// <param name="baseXeroClient"></param>
/// <param name="accountingXeroClient"></param>
public partial class XeroService(ExtendedXeroConfiguration _xeroExtendedConfiguration, XeroConfiguration _xeroConfiguration, XeroCache xeroCache,
IXeroClient baseXeroClient, IAccountingApi accountingXeroClient, IAppStoreApi appStoreXeroClient, IAssetApi assetXeroClient,
IBankFeedsApi bankFeedXeroClient, IFilesApi fileXeroClient, IFinanceApi financeXeroClient, IIdentityApi identityXeroClient,
IPayrollAuApi payrollAuXeroClient, IPayrollNzApi payrollNzXeroClient, IPayrollUkApi payrollUkXeroClient, IProjectApi projectXeroClient) : IXeroClient
{
    public XeroConfiguration xeroConfiguration { get; set; } = _xeroConfiguration;
    public ExtendedXeroConfiguration xeroExtendedConfiguration { get; set; } = _xeroExtendedConfiguration;

    public string BuildLoginUri()
    {
        return baseXeroClient.BuildLoginUri();
    }

    public string BuildLoginUri(string state)
    {
        return baseXeroClient.BuildLoginUri(state);
    }

    public string BuildLoginUri(string state, string scope)
    {
        return baseXeroClient.BuildLoginUri(state, scope);
    }

    public string BuildLoginUriPkce(string codeVerifier)
    {
        return baseXeroClient.BuildLoginUriPkce(codeVerifier);
    }

    public string BuildLoginUriPkce(string codeVerifier, string state)
    {
        return baseXeroClient.BuildLoginUriPkce(codeVerifier, state);
    }

    public string BuildLoginUriPkce(string codeVerifier, string state, string scope)
    {
        return baseXeroClient.BuildLoginUriPkce(codeVerifier, state, scope);
    }

    public Task DeleteConnectionAsync(IXeroToken xeroToken, Tenant xeroTenant)
    {
        return baseXeroClient.DeleteConnectionAsync(xeroToken, xeroTenant);
    }

    public Task<List<Tenant>> GetConnectionsAsync(IXeroToken xeroToken)
    {
        return baseXeroClient.GetConnectionsAsync(xeroToken);
    }

    public Task<IXeroToken> GetCurrentValidTokenAsync(IXeroToken xeroToken)
    {
        return baseXeroClient.GetCurrentValidTokenAsync(xeroToken);
    }

    public async Task<IXeroToken> RefreshAccessTokenAsync(string code)
    {
        IXeroToken? xeroToken;
        bool tokenNotFound = !xeroCache.TryGetValue($"AccessToken_{code}", out xeroToken);

        if (tokenNotFound || xeroExtendedConfiguration.DisableTokenCaching)
        {
            xeroToken = await baseXeroClient.RequestAccessTokenAsync(code);
            TimeSpan timeToExpiry = xeroToken.ExpiresAtUtc - DateTime.UtcNow;

            xeroCache.Set($"AccessToken_{code}", xeroToken, timeToExpiry);
        }

        return xeroToken ?? throw new InvalidOperationException($"Failed to retrieve the access token code: {code}");
    }

    public Task<IXeroToken> RefreshAccessTokenAsync(IXeroToken xeroToken)
    {
        return baseXeroClient.RefreshAccessTokenAsync(xeroToken);
    }

    public async Task<IXeroToken> RequestAccessTokenAsync(string code)
    {
        IXeroToken? xeroToken;
        bool tokenNotFound = !xeroCache.TryGetValue($"AccessToken_{code}", out xeroToken);

        if (tokenNotFound || xeroExtendedConfiguration.DisableTokenCaching)
        {
            xeroToken = await baseXeroClient.RequestAccessTokenAsync(code);
            TimeSpan timeToExpiry = xeroToken.ExpiresAtUtc - DateTime.UtcNow;

            xeroCache.Set($"AccessToken_{code}", xeroToken, timeToExpiry);
        }

        return xeroToken ?? throw new InvalidOperationException($"Failed to retrieve the access token code: {code}");
    }

    public Task<IXeroToken> RequestAccessTokenPkceAsync(string code, string codeVerifier)
    {
        return baseXeroClient.RequestAccessTokenPkceAsync(code, codeVerifier);
    }

    public async Task<IXeroToken> RequestClientCredentialsTokenAsync(bool fetchTenants = false)
    {
        IXeroToken? xeroToken;
        bool tokenNotFound = !xeroCache.TryGetValue("ClientCredentialsToken", out xeroToken);

        if (tokenNotFound || xeroExtendedConfiguration.DisableTokenCaching)
        {
            xeroToken = await baseXeroClient.RequestClientCredentialsTokenAsync(fetchTenants);
            TimeSpan timeToExpiry = xeroToken.ExpiresAtUtc - DateTime.UtcNow;

            xeroCache.Set("ClientCredentialsToken", xeroToken, timeToExpiry);
        }

        return xeroToken ?? throw new InvalidOperationException("Failed to retrieve the client credentials token.");
    }

    public async Task RevokeAccessTokenAsync(string key)
    {
        if (xeroCache.TryGetValue(key, out IXeroToken? token))
            await RevokeAccessTokenAsync(token!);
    }

    public async Task RevokeAccessTokenAsync(IXeroToken xeroToken)
    {
        if (xeroToken == null)
            throw new ArgumentNullException(nameof(xeroToken));

        await baseXeroClient.RevokeAccessTokenAsync(xeroToken);
    }
}

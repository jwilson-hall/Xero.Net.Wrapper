using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Asset;

namespace Xero.Net.Wrapper.Api;

public partial class XeroService : IAssetApi
{
    public async Task<Asset> CreateAssetAsync(Asset asset, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateAssetAsync(accessToken, xeroExtendedConfiguration.TenantId, asset, idempotencyKey, cancellationToken);
    }

    public async Task<Asset> CreateAssetAsync(string accessToken, string xeroTenantId, Asset asset, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<Asset> response = await CreateAssetAsyncWithHttpInfo(accessToken, xeroTenantId, asset, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Asset>> CreateAssetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Asset asset, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<Asset> response = await assetXeroClient.CreateAssetAsyncWithHttpInfo(accessToken, xeroTenantId, asset, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<AssetType> CreateAssetTypeAsync(AssetType assetType, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateAssetTypeAsync(accessToken, xeroExtendedConfiguration.TenantId, assetType, idempotencyKey, cancellationToken);
    }

    public async Task<AssetType> CreateAssetTypeAsync(string accessToken, string xeroTenantId, AssetType assetType, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<AssetType> response = await CreateAssetTypeAsyncWithHttpInfo(accessToken, xeroTenantId, assetType, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<AssetType>> CreateAssetTypeAsyncWithHttpInfo(string accessToken, string xeroTenantId, AssetType assetType, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<AssetType> response = await assetXeroClient.CreateAssetTypeAsyncWithHttpInfo(accessToken, xeroTenantId, assetType, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<Asset> GetAssetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAssetByIdAsync(accessToken, xeroExtendedConfiguration.TenantId, id, cancellationToken);
    }

    public async Task<Asset> GetAssetByIdAsync(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
        {
        ApiResponse<Asset> response = await GetAssetByIdAsyncWithHttpInfo(accessToken, xeroTenantId, id, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Asset>> GetAssetByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
        {
        ApiResponse<Asset> response = await assetXeroClient.GetAssetByIdAsyncWithHttpInfo(accessToken, xeroTenantId, id, cancellationToken);
        return response;
    }

    public async Task<Assets> GetAssetsAsync(AssetStatusQueryParam status, int? page = null, int? pageSize = null, string? orderBy = null, string? sortDirection = null, string? filterBy = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAssetsAsync(accessToken, xeroExtendedConfiguration.TenantId, status, page, pageSize, orderBy, sortDirection, filterBy, cancellationToken);
    }

    public async Task<Assets> GetAssetsAsync(string accessToken, string xeroTenantId, AssetStatusQueryParam status, int? page = null, int? pageSize = null, string? orderBy = null, string? sortDirection = null, string? filterBy = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<Assets> response = await GetAssetsAsyncWithHttpInfo(accessToken, xeroTenantId, status, page, pageSize, orderBy, sortDirection, filterBy, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Assets>> GetAssetsAsyncWithHttpInfo(string accessToken, string xeroTenantId, AssetStatusQueryParam status, int? page = null, int? pageSize = null, string? orderBy = null, string? sortDirection = null, string? filterBy = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<Assets> response = await assetXeroClient.GetAssetsAsyncWithHttpInfo(accessToken, xeroTenantId, status, page, pageSize, orderBy, sortDirection, filterBy, cancellationToken);
        return response;
    }
    public async Task<Setting> GetAssetSettingsAsync(CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAssetSettingsAsync(accessToken, xeroExtendedConfiguration.TenantId, cancellationToken);
    }

    public async Task<Setting> GetAssetSettingsAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
        {
        ApiResponse<Setting> response = await GetAssetSettingsAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Setting>> GetAssetSettingsAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
        {
        ApiResponse<Setting> response = await assetXeroClient.GetAssetSettingsAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response;
    }
    public async Task<List<AssetType>> GetAssetTypesAsync(CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAssetTypesAsync(accessToken, xeroExtendedConfiguration.TenantId, cancellationToken);
    }

    public async Task<List<AssetType>> GetAssetTypesAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
        {
        ApiResponse<List<AssetType>> response = await GetAssetTypesAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<List<AssetType>>> GetAssetTypesAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
        {
        ApiResponse<List<AssetType>> response = await assetXeroClient.GetAssetTypesAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response;
    }
}
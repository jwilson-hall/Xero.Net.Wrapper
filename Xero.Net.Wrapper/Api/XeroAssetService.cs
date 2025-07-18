using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Asset;

public partial class XeroService : IAssetApi
{
    public Task<Asset> CreateAssetAsync(string accessToken, string xeroTenantId, Asset asset, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Asset>> CreateAssetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Asset asset, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<AssetType> CreateAssetTypeAsync(string accessToken, string xeroTenantId, AssetType assetType, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<AssetType>> CreateAssetTypeAsyncWithHttpInfo(string accessToken, string xeroTenantId, AssetType assetType, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Asset> GetAssetByIdAsync(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Asset>> GetAssetByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Assets> GetAssetsAsync(string accessToken, string xeroTenantId, AssetStatusQueryParam status, int? page = null, int? pageSize = null, string orderBy = null, string sortDirection = null, string filterBy = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Assets>> GetAssetsAsyncWithHttpInfo(string accessToken, string xeroTenantId, AssetStatusQueryParam status, int? page = null, int? pageSize = null, string orderBy = null, string sortDirection = null, string filterBy = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Setting> GetAssetSettingsAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Setting>> GetAssetSettingsAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<List<AssetType>> GetAssetTypesAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<List<AssetType>>> GetAssetTypesAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
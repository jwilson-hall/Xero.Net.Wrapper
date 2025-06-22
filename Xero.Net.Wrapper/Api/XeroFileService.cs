using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Files;

namespace Xero.Net.Wrapper.Api;
public partial class XeroService : IFilesApi
{
    public async Task<Association> CreateFileAssociationAsync(Guid fileId, Association association, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateFileAssociationAsync(accessToken, xeroExtendedConfiguration.TenantId, fileId, association, idempotencyKey, cancellationToken);
    }

    public async Task<Association> CreateFileAssociationAsync(string accessToken, string xeroTenantId, Guid fileId, Association association, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Association> response = await CreateFileAssociationAsyncWithHttpInfo(accessToken, xeroTenantId, fileId, association, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Association>> CreateFileAssociationAsyncWithHttpInfo(Guid fileId, Association association, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateFileAssociationAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, fileId, association, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<Association>> CreateFileAssociationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid fileId, Association association, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Association> response = await fileXeroClient.CreateFileAssociationAsyncWithHttpInfo(accessToken, xeroTenantId, fileId, association, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<Folder> CreateFolderAsync(Folder folder, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateFolderAsync(accessToken, xeroExtendedConfiguration.TenantId, folder, idempotencyKey, cancellationToken);
    }

    public async Task<Folder> CreateFolderAsync(string accessToken, string xeroTenantId, Folder folder, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Folder> response = await CreateFolderAsyncWithHttpInfo(accessToken, xeroTenantId, folder, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Folder>> CreateFolderAsyncWithHttpInfo(Folder folder, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateFolderAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, folder, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<Folder>> CreateFolderAsyncWithHttpInfo(string accessToken, string xeroTenantId, Folder folder, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Folder> response = await fileXeroClient.CreateFolderAsyncWithHttpInfo(accessToken, xeroTenantId, folder, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task DeleteFileAssociationAsync(Guid fileId, Guid objectId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        await DeleteFileAssociationAsync(accessToken, xeroExtendedConfiguration.TenantId, fileId, objectId, cancellationToken);
    }

    public Task DeleteFileAssociationAsync(string accessToken, string xeroTenantId, Guid fileId, Guid objectId, CancellationToken cancellationToken = default)
    {
        return fileXeroClient.DeleteFileAssociationAsync(accessToken, xeroTenantId, fileId, objectId, cancellationToken);
    }

    public async Task<ApiResponse<object>> DeleteFileAssociationAsyncWithHttpInfo(Guid fileId, Guid objectId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteFileAssociationAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, fileId, objectId, cancellationToken);
    }

    public async Task<ApiResponse<object>> DeleteFileAssociationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid fileId, Guid objectId, CancellationToken cancellationToken = default)
    {
        ApiResponse<object> response = await fileXeroClient.DeleteFileAssociationAsyncWithHttpInfo(accessToken, xeroTenantId, fileId, objectId, cancellationToken);
        return response;
    }

    public async Task DeleteFileAsync(Guid fileId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        await DeleteFileAsync(accessToken, xeroExtendedConfiguration.TenantId, fileId, cancellationToken);
    }

    public Task DeleteFileAsync(string accessToken, string xeroTenantId, Guid fileId, CancellationToken cancellationToken = default)
    {
        return fileXeroClient.DeleteFileAsync(accessToken, xeroTenantId, fileId, cancellationToken);
    }
    public async Task<ApiResponse<object>> DeleteFileAsyncWithHttpInfo(Guid fileId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteFileAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, fileId, cancellationToken);
    }

    public async Task<ApiResponse<object>> DeleteFileAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid fileId, CancellationToken cancellationToken = default)
    {
        ApiResponse<object> response = await fileXeroClient.DeleteFileAsyncWithHttpInfo(accessToken, xeroTenantId, fileId, cancellationToken);
        return response;
    }

    public async Task DeleteFolderAsync(Guid folderId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        await DeleteFolderAsync(accessToken, xeroExtendedConfiguration.TenantId, folderId, cancellationToken);
    }

    public Task DeleteFolderAsync(string accessToken, string xeroTenantId, Guid folderId, CancellationToken cancellationToken = default)
    {
        return fileXeroClient.DeleteFolderAsync(accessToken, xeroTenantId, folderId, cancellationToken);
    }
    public async Task<ApiResponse<object>> DeleteFolderAsyncWithHttpInfo(Guid folderId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteFolderAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, folderId, cancellationToken);
    }

    public async Task<ApiResponse<object>> DeleteFolderAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid folderId, CancellationToken cancellationToken = default)
    {
        ApiResponse<object> response = await fileXeroClient.DeleteFolderAsyncWithHttpInfo(accessToken, xeroTenantId, folderId, cancellationToken);
        return response;
    }

    public async Task<List<Association>> GetAssociationsByObjectAsync(Guid objectId, int? pagesize = null, int? page = null, string? sort = null, string? direction = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAssociationsByObjectAsync(accessToken, xeroExtendedConfiguration.TenantId, objectId, pagesize, page, sort, direction, cancellationToken);
    }

    public async Task<List<Association>> GetAssociationsByObjectAsync(string accessToken, string xeroTenantId, Guid objectId, int? pagesize = null, int? page = null, string? sort = null, string? direction = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<List<Association>> response = await GetAssociationsByObjectAsyncWithHttpInfo(accessToken, xeroTenantId, objectId, pagesize, page, sort, direction, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<List<Association>>> GetAssociationsByObjectAsyncWithHttpInfo(Guid objectId, int? pagesize = null, int? page = null, string? sort = null, string? direction = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAssociationsByObjectAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, objectId, pagesize, page, sort, direction, cancellationToken);
    }

    public async Task<ApiResponse<List<Association>>> GetAssociationsByObjectAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid objectId, int? pagesize = null, int? page = null, string? sort = null, string? direction = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<List<Association>> response = await fileXeroClient.GetAssociationsByObjectAsyncWithHttpInfo(accessToken, xeroTenantId, objectId, pagesize, page, sort, direction, cancellationToken);
        return response;
    }
    public async Task<object> GetAssociationsCountAsync(List<Guid> objectIds, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAssociationsCountAsync(accessToken, xeroExtendedConfiguration.TenantId, objectIds, cancellationToken);
    }

    public async Task<object> GetAssociationsCountAsync(string accessToken, string xeroTenantId, List<Guid> objectIds, CancellationToken cancellationToken = default)
    {
        ApiResponse<object> response = await GetAssociationsCountAsyncWithHttpInfo(accessToken, xeroTenantId, objectIds, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<object>> GetAssociationsCountAsyncWithHttpInfo(List<Guid> objectIds, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAssociationsCountAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, objectIds, cancellationToken);
    }

    public async Task<ApiResponse<object>> GetAssociationsCountAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<Guid> objectIds, CancellationToken cancellationToken = default)
    {
        ApiResponse<object> response = await fileXeroClient.GetAssociationsCountAsyncWithHttpInfo(accessToken, xeroTenantId, objectIds, cancellationToken);
        return response;
    }

    public async Task<List<Association>> GetFileAssociationsAsync(Guid fileId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFileAssociationsAsync(accessToken, xeroExtendedConfiguration.TenantId, fileId, cancellationToken);
    }

    public async Task<List<Association>> GetFileAssociationsAsync(string accessToken, string xeroTenantId, Guid fileId, CancellationToken cancellationToken = default)
    {
        ApiResponse<List<Association>> response = await GetFileAssociationsAsyncWithHttpInfo(accessToken, xeroTenantId, fileId, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<List<Association>>> GetFileAssociationsAsyncWithHttpInfo(Guid fileId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFileAssociationsAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, fileId, cancellationToken);
    }

    public async Task<ApiResponse<List<Association>>> GetFileAssociationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid fileId, CancellationToken cancellationToken = default)
    {
        ApiResponse<List<Association>> response = await fileXeroClient.GetFileAssociationsAsyncWithHttpInfo(accessToken, xeroTenantId, fileId, cancellationToken);
        return response;
    }
    public async Task<FileObject> GetFileAsync(Guid fileId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFileAsync(accessToken, xeroExtendedConfiguration.TenantId, fileId, cancellationToken);
    }

    public async Task<FileObject> GetFileAsync(string accessToken, string xeroTenantId, Guid fileId, CancellationToken cancellationToken = default)
    {
        ApiResponse<FileObject> response = await GetFileAsyncWithHttpInfo(accessToken, xeroTenantId, fileId, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<FileObject>> GetFileAsyncWithHttpInfo(Guid fileId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFileAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, fileId, cancellationToken);
    }

    public async Task<ApiResponse<FileObject>> GetFileAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid fileId, CancellationToken cancellationToken = default)
    {
        ApiResponse<FileObject> response = await fileXeroClient.GetFileAsyncWithHttpInfo(accessToken, xeroTenantId, fileId, cancellationToken);
        return response;
    }
    public async Task<Stream> GetFileContentAsync(Guid fileId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFileContentAsync(accessToken, xeroExtendedConfiguration.TenantId, fileId, cancellationToken);
    }

    public async Task<Stream> GetFileContentAsync(string accessToken, string xeroTenantId, Guid fileId, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetFileContentAsyncWithHttpInfo(accessToken, xeroTenantId, fileId, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<Stream>> GetFileContentAsyncWithHttpInfo(Guid fileId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFileContentAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, fileId, cancellationToken);
    }

    public async Task<ApiResponse<Stream>> GetFileContentAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid fileId, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await fileXeroClient.GetFileContentAsyncWithHttpInfo(accessToken, xeroTenantId, fileId, cancellationToken);
        return response;
    }
    public async Task<Files> GetFilesAsync(int? pagesize = null, int? page = null, string? sort = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFilesAsync(accessToken, xeroExtendedConfiguration.TenantId, pagesize, page, sort, cancellationToken);
    }

    public async Task<Files> GetFilesAsync(string accessToken, string xeroTenantId, int? pagesize = null, int? page = null, string? sort = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Files> response = await GetFilesAsyncWithHttpInfo(accessToken, xeroTenantId, pagesize, page, sort, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<Files>> GetFilesAsyncWithHttpInfo(int? pagesize = null, int? page = null, string? sort = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFilesAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, pagesize, page, sort, cancellationToken);
    }

    public async Task<ApiResponse<Files>> GetFilesAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? pagesize = null, int? page = null, string? sort = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Files> response = await fileXeroClient.GetFilesAsyncWithHttpInfo(accessToken, xeroTenantId, pagesize, page, sort, cancellationToken);
        return response;
    }
    public async Task<Folder> GetFolderAsync(Guid folderId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFolderAsync(accessToken, xeroExtendedConfiguration.TenantId, folderId, cancellationToken);
    }

    public async Task<Folder> GetFolderAsync(string accessToken, string xeroTenantId, Guid folderId, CancellationToken cancellationToken = default)
    {
        ApiResponse<Folder> response = await GetFolderAsyncWithHttpInfo(accessToken, xeroTenantId, folderId, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<Folder>> GetFolderAsyncWithHttpInfo(Guid folderId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFolderAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, folderId, cancellationToken);
    }

    public async Task<ApiResponse<Folder>> GetFolderAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid folderId, CancellationToken cancellationToken = default)
    {
        ApiResponse<Folder> response = await fileXeroClient.GetFolderAsyncWithHttpInfo(accessToken, xeroTenantId, folderId, cancellationToken);
        return response;
    }
    public async Task<List<Folder>> GetFoldersAsync(string? sort = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFoldersAsync(accessToken, xeroExtendedConfiguration.TenantId, sort, cancellationToken);
    }

    public async Task<List<Folder>> GetFoldersAsync(string accessToken, string xeroTenantId, string? sort = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<List<Folder>> response = await GetFoldersAsyncWithHttpInfo(accessToken, xeroTenantId, sort, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<List<Folder>>> GetFoldersAsyncWithHttpInfo(string? sort = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFoldersAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, sort, cancellationToken);
    }

    public async Task<ApiResponse<List<Folder>>> GetFoldersAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? sort = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<List<Folder>> response = await fileXeroClient.GetFoldersAsyncWithHttpInfo(accessToken, xeroTenantId, sort, cancellationToken);
        return response;
    }
    public async Task<Folder> GetInboxAsync(CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetInboxAsync(accessToken, xeroExtendedConfiguration.TenantId, cancellationToken);
    }

    public async Task<Folder> GetInboxAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        ApiResponse<Folder> response = await GetInboxAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<Folder>> GetInboxAsyncWithHttpInfo(CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetInboxAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, cancellationToken);
    }

    public async Task<ApiResponse<Folder>> GetInboxAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        ApiResponse<Folder> response = await fileXeroClient.GetInboxAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response;
    }
    public async Task<FileObject> UpdateFileAsync(Guid fileId, FileObject fileObject, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateFileAsync(accessToken, xeroExtendedConfiguration.TenantId, fileId, fileObject, idempotencyKey, cancellationToken);
    }

    public async Task<FileObject> UpdateFileAsync(string accessToken, string xeroTenantId, Guid fileId, FileObject fileObject, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<FileObject> response = await UpdateFileAsyncWithHttpInfo(accessToken, xeroTenantId, fileId, fileObject, idempotencyKey, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<FileObject>> UpdateFileAsyncWithHttpInfo(Guid fileId, FileObject fileObject, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateFileAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, fileId, fileObject, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<FileObject>> UpdateFileAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid fileId, FileObject fileObject, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<FileObject> response = await fileXeroClient.UpdateFileAsyncWithHttpInfo(accessToken, xeroTenantId, fileId, fileObject, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Folder> UpdateFolderAsync(Guid folderId, Folder folder, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateFolderAsync(accessToken, xeroExtendedConfiguration.TenantId, folderId, folder, idempotencyKey, cancellationToken);
    }

    public async Task<Folder> UpdateFolderAsync(string accessToken, string xeroTenantId, Guid folderId, Folder folder, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Folder> response = await UpdateFolderAsyncWithHttpInfo(accessToken, xeroTenantId, folderId, folder, idempotencyKey, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<Folder>> UpdateFolderAsyncWithHttpInfo(Guid folderId, Folder folder, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateFolderAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, folderId, folder, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<Folder>> UpdateFolderAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid folderId, Folder folder, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Folder> response = await fileXeroClient.UpdateFolderAsyncWithHttpInfo(accessToken, xeroTenantId, folderId, folder, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<FileObject> UploadFileAsync(byte[] body, string name, string filename, string? idempotencyKey = null, string? mimeType = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UploadFileAsync(accessToken, xeroExtendedConfiguration.TenantId, body, name, filename, idempotencyKey, mimeType, cancellationToken);
    }

    public async Task<FileObject> UploadFileAsync(string accessToken, string xeroTenantId, byte[] body, string name, string filename, string? idempotencyKey = null, string? mimeType = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<FileObject> response = await UploadFileAsyncWithHttpInfo(accessToken, xeroTenantId, body, name, filename, idempotencyKey, mimeType, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<FileObject>> UploadFileAsyncWithHttpInfo(byte[] body, string name, string filename, string? idempotencyKey = null, string? mimeType = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UploadFileAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, body, name, filename, idempotencyKey, mimeType, cancellationToken);
    }

    public async Task<ApiResponse<FileObject>> UploadFileAsyncWithHttpInfo(string accessToken, string xeroTenantId, byte[] body, string name, string filename, string? idempotencyKey = null, string? mimeType = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<FileObject> response = await fileXeroClient.UploadFileAsyncWithHttpInfo(accessToken, xeroTenantId, body, name, filename, idempotencyKey, mimeType, cancellationToken);
        return response;
    }
    public async Task<FileObject> UploadFileToFolderAsync(Guid folderId, byte[] body, string name, string filename, string? idempotencyKey = null, string? mimeType = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UploadFileToFolderAsync(accessToken, xeroExtendedConfiguration.TenantId, folderId, body, name, filename, idempotencyKey, mimeType, cancellationToken);
    }

    public async Task<FileObject> UploadFileToFolderAsync(string accessToken, string xeroTenantId, Guid folderId, byte[] body, string name, string filename, string? idempotencyKey = null, string? mimeType = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<FileObject> response = await UploadFileToFolderAsyncWithHttpInfo(accessToken, xeroTenantId, folderId, body, name, filename, idempotencyKey, mimeType, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<FileObject>> UploadFileToFolderAsyncWithHttpInfo(Guid folderId, byte[] body, string name, string filename, string? idempotencyKey = null, string? mimeType = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UploadFileToFolderAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, folderId, body, name, filename, idempotencyKey, mimeType, cancellationToken);
    }

    public async Task<ApiResponse<FileObject>> UploadFileToFolderAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid folderId, byte[] body, string name, string filename, string? idempotencyKey = null, string? mimeType = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<FileObject> response = await fileXeroClient.UploadFileToFolderAsyncWithHttpInfo(accessToken, xeroTenantId, folderId, body, name, filename, idempotencyKey, mimeType, cancellationToken);
        return response;
    }
}

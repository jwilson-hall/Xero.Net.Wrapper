using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Project;

namespace Xero.Net.Wrapper.Api;

public partial class XeroService : IProjectApi
{
    public async Task<Project> CreateProjectAsync(ProjectCreateOrUpdate projectCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateProjectAsync(accessToken, xeroExtendedConfiguration.TenantId, projectCreateOrUpdate, idempotencyKey, cancellationToken);
    }

    public async Task<Project> CreateProjectAsync(string accessToken, string xeroTenantId, ProjectCreateOrUpdate projectCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Project> response = await CreateProjectAsyncWithHttpInfo(accessToken, xeroTenantId, projectCreateOrUpdate, idempotencyKey, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<Project>> CreateProjectAsyncWithHttpInfo(ProjectCreateOrUpdate projectCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateProjectAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, projectCreateOrUpdate, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<Project>> CreateProjectAsyncWithHttpInfo(string accessToken, string xeroTenantId, ProjectCreateOrUpdate projectCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Project> response = await projectXeroClient.CreateProjectAsyncWithHttpInfo(accessToken, xeroTenantId, projectCreateOrUpdate, idempotencyKey, cancellationToken);
        return response;
    }

    public Task<Xero.NetStandard.OAuth2.Model.Project.Task> CreateTaskAsync(string accessToken, string xeroTenantId, Guid projectId, TaskCreateOrUpdate taskCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Xero.NetStandard.OAuth2.Model.Project.Task>> CreateTaskAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, TaskCreateOrUpdate taskCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
    public async Task<TimeEntry> CreateTimeEntryAsync(Guid projectId, TimeEntryCreateOrUpdate timeEntryCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateTimeEntryAsync(accessToken, xeroExtendedConfiguration.TenantId, projectId, timeEntryCreateOrUpdate, idempotencyKey, cancellationToken);
    }

    public async Task<TimeEntry> CreateTimeEntryAsync(string accessToken, string xeroTenantId, Guid projectId, TimeEntryCreateOrUpdate timeEntryCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TimeEntry> response = await CreateTimeEntryAsyncWithHttpInfo(accessToken, xeroTenantId, projectId, timeEntryCreateOrUpdate, idempotencyKey, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<TimeEntry>> CreateTimeEntryAsyncWithHttpInfo(Guid projectId, TimeEntryCreateOrUpdate timeEntryCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateTimeEntryAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, projectId, timeEntryCreateOrUpdate, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<TimeEntry>> CreateTimeEntryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, TimeEntryCreateOrUpdate timeEntryCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TimeEntry> response = await projectXeroClient.CreateTimeEntryAsyncWithHttpInfo(accessToken, xeroTenantId, projectId, timeEntryCreateOrUpdate, idempotencyKey, cancellationToken);
        return response;
    }

    public System.Threading.Tasks.Task DeleteTaskAsync(string accessToken, string xeroTenantId, Guid projectId, Guid taskId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<ApiResponse<object>> DeleteTaskAsyncWithHttpInfo(Guid projectId, Guid taskId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteTaskAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, projectId, taskId, cancellationToken);
    }

    public async Task<ApiResponse<object>> DeleteTaskAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, Guid taskId, CancellationToken cancellationToken = default)
    {
        ApiResponse<object> response = await projectXeroClient.DeleteTaskAsyncWithHttpInfo(accessToken, xeroTenantId, projectId, taskId, cancellationToken);
        return response;
    }

    public System.Threading.Tasks.Task DeleteTimeEntryAsync(string accessToken, string xeroTenantId, Guid projectId, Guid timeEntryId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<ApiResponse<object>> DeleteTimeEntryAsyncWithHttpInfo(Guid projectId, Guid timeEntryId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteTimeEntryAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, projectId, timeEntryId, cancellationToken);
    }

    public async Task<ApiResponse<object>> DeleteTimeEntryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, Guid timeEntryId, CancellationToken cancellationToken = default)
    {
        ApiResponse<object> response = await projectXeroClient.DeleteTimeEntryAsyncWithHttpInfo(accessToken, xeroTenantId, projectId, timeEntryId, cancellationToken);
        return response;
    }
    public async Task<Project> GetProjectAsync(Guid projectId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetProjectAsync(accessToken, xeroExtendedConfiguration.TenantId, projectId, cancellationToken);
    }

    public async Task<Project> GetProjectAsync(string accessToken, string xeroTenantId, Guid projectId, CancellationToken cancellationToken = default)
    {
        ApiResponse<Project> response = await GetProjectAsyncWithHttpInfo(accessToken, xeroTenantId, projectId, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<Project>> GetProjectAsyncWithHttpInfo(Guid projectId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetProjectAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, projectId, cancellationToken);
    }

    public async Task<ApiResponse<Project>> GetProjectAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, CancellationToken cancellationToken = default)
    {
        ApiResponse<Project> response = await projectXeroClient.GetProjectAsyncWithHttpInfo(accessToken, xeroTenantId, projectId, cancellationToken);
        return response;
    }

    public async Task<Projects> GetProjectsAsync(List<Guid>? projectIds = null, Guid? contactID = null, string? states = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetProjectsAsync(accessToken, xeroExtendedConfiguration.TenantId, projectIds, contactID, states, page, pageSize, cancellationToken);
    }

    public async Task<Projects> GetProjectsAsync(string accessToken, string xeroTenantId, List<Guid>? projectIds = null, Guid? contactID = null, string? states = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Projects> response = await GetProjectsAsyncWithHttpInfo(accessToken, xeroTenantId, projectIds, contactID, states, page, pageSize, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<Projects>> GetProjectsAsyncWithHttpInfo(List<Guid>? projectIds = null, Guid? contactID = null, string? states = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetProjectsAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, projectIds, contactID, states, page, pageSize, cancellationToken);
    }

    public async Task<ApiResponse<Projects>> GetProjectsAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<Guid>? projectIds = null, Guid? contactID = null, string? states = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Projects> response = await projectXeroClient.GetProjectsAsyncWithHttpInfo(accessToken, xeroTenantId, projectIds, contactID, states, page, pageSize, cancellationToken);
        return response;
    }
    public async Task<ProjectUsers> GetProjectUsersAsync(int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetProjectUsersAsync(accessToken, xeroExtendedConfiguration.TenantId, page, pageSize, cancellationToken);
    }

    public async Task<ProjectUsers> GetProjectUsersAsync(string accessToken, string xeroTenantId, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ProjectUsers> response = await GetProjectUsersAsyncWithHttpInfo(accessToken, xeroTenantId, page, pageSize, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<ProjectUsers>> GetProjectUsersAsyncWithHttpInfo(int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetProjectUsersAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, page, pageSize, cancellationToken);
    }

    public async Task<ApiResponse<ProjectUsers>> GetProjectUsersAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ProjectUsers> response = await projectXeroClient.GetProjectUsersAsyncWithHttpInfo(accessToken, xeroTenantId, page, pageSize, cancellationToken);
        return response;
    }

    public Task<Xero.NetStandard.OAuth2.Model.Project.Task> GetTaskAsync(string accessToken, string xeroTenantId, Guid projectId, Guid taskId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Xero.NetStandard.OAuth2.Model.Project.Task>> GetTaskAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, Guid taskId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
    public async Task<Tasks> GetTasksAsync(Guid projectId, int? page = null, int? pageSize = null, string? taskIds = null, ChargeType? chargeType = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetTasksAsync(accessToken, xeroExtendedConfiguration.TenantId, projectId, page, pageSize, taskIds, chargeType, cancellationToken);
    }

    public async Task<Tasks> GetTasksAsync(string accessToken, string xeroTenantId, Guid projectId, int? page = null, int? pageSize = null, string? taskIds = null, ChargeType? chargeType = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Tasks> response = await GetTasksAsyncWithHttpInfo(accessToken, xeroTenantId, projectId, page, pageSize, taskIds, chargeType, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<Tasks>> GetTasksAsyncWithHttpInfo(Guid projectId, int? page = null, int? pageSize = null, string? taskIds = null, ChargeType? chargeType = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetTasksAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, projectId, page, pageSize, taskIds, chargeType, cancellationToken);
    }

    public async Task<ApiResponse<Tasks>> GetTasksAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, int? page = null, int? pageSize = null, string? taskIds = null, ChargeType? chargeType = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Tasks> response = await projectXeroClient.GetTasksAsyncWithHttpInfo(accessToken, xeroTenantId, projectId, page, pageSize, taskIds, chargeType, cancellationToken);
        return response;
    }
    public async Task<TimeEntries> GetTimeEntriesAsync(Guid projectId, Guid? userId = null, Guid? taskId = null, Guid? invoiceId = null, Guid? contactId = null, int? page = null, int? pageSize = null, List<string>? states = null, bool? isChargeable = null, DateTime? dateAfterUtc = null, DateTime? dateBeforeUtc = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetTimeEntriesAsync(accessToken, xeroExtendedConfiguration.TenantId, projectId, userId, taskId, invoiceId, contactId, page, pageSize, states, isChargeable, dateAfterUtc, dateBeforeUtc, cancellationToken);
    }

    public async Task<TimeEntries> GetTimeEntriesAsync(string accessToken, string xeroTenantId, Guid projectId, Guid? userId = null, Guid? taskId = null, Guid? invoiceId = null, Guid? contactId = null, int? page = null, int? pageSize = null, List<string>? states = null, bool? isChargeable = null, DateTime? dateAfterUtc = null, DateTime? dateBeforeUtc = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TimeEntries> response = await GetTimeEntriesAsyncWithHttpInfo(accessToken, xeroTenantId, projectId, userId, taskId, invoiceId, contactId, page, pageSize, states, isChargeable, dateAfterUtc, dateBeforeUtc, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<TimeEntries>> GetTimeEntriesAsyncWithHttpInfo(Guid projectId, Guid? userId = null, Guid? taskId = null, Guid? invoiceId = null, Guid? contactId = null, int? page = null, int? pageSize = null, List<string>? states = null, bool? isChargeable = null, DateTime? dateAfterUtc = null, DateTime? dateBeforeUtc = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetTimeEntriesAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, projectId, userId, taskId, invoiceId, contactId, page, pageSize, states, isChargeable, dateAfterUtc, dateBeforeUtc, cancellationToken);
    }

    public async Task<ApiResponse<TimeEntries>> GetTimeEntriesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, Guid? userId = null, Guid? taskId = null, Guid? invoiceId = null, Guid? contactId = null, int? page = null, int? pageSize = null, List<string>? states = null, bool? isChargeable = null, DateTime? dateAfterUtc = null, DateTime? dateBeforeUtc = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TimeEntries> response = await projectXeroClient.GetTimeEntriesAsyncWithHttpInfo(accessToken, xeroTenantId, projectId, userId, taskId, invoiceId, contactId, page, pageSize, states, isChargeable, dateAfterUtc, dateBeforeUtc, cancellationToken);
        return response;
    }
    public async Task<TimeEntry> GetTimeEntryAsync(Guid projectId, Guid timeEntryId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetTimeEntryAsync(accessToken, xeroExtendedConfiguration.TenantId, projectId, timeEntryId, cancellationToken);
    }

    public async Task<TimeEntry> GetTimeEntryAsync(string accessToken, string xeroTenantId, Guid projectId, Guid timeEntryId, CancellationToken cancellationToken = default)
    {
        ApiResponse<TimeEntry> response = await GetTimeEntryAsyncWithHttpInfo(accessToken, xeroTenantId, projectId, timeEntryId, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<TimeEntry>> GetTimeEntryAsyncWithHttpInfo(Guid projectId, Guid timeEntryId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetTimeEntryAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, projectId, timeEntryId, cancellationToken);
    }

    public async Task<ApiResponse<TimeEntry>> GetTimeEntryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, Guid timeEntryId, CancellationToken cancellationToken = default)
    {
        ApiResponse<TimeEntry> response = await projectXeroClient.GetTimeEntryAsyncWithHttpInfo(accessToken, xeroTenantId, projectId, timeEntryId, cancellationToken);
        return response;
    }

    public System.Threading.Tasks.Task PatchProjectAsync(string accessToken, string xeroTenantId, Guid projectId, ProjectPatch projectPatch, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<ApiResponse<object>> PatchProjectAsyncWithHttpInfo(Guid projectId, ProjectPatch projectPatch, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PatchProjectAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, projectId, projectPatch, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<object>> PatchProjectAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, ProjectPatch projectPatch, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<object> response = await projectXeroClient.PatchProjectAsyncWithHttpInfo(accessToken, xeroTenantId, projectId, projectPatch, idempotencyKey, cancellationToken);
        return response;
    }

    public System.Threading.Tasks.Task UpdateProjectAsync(string accessToken, string xeroTenantId, Guid projectId, ProjectCreateOrUpdate projectCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<ApiResponse<object>> UpdateProjectAsyncWithHttpInfo(Guid projectId, ProjectCreateOrUpdate projectCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateProjectAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, projectId, projectCreateOrUpdate, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<object>> UpdateProjectAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, ProjectCreateOrUpdate projectCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<object> response = await projectXeroClient.UpdateProjectAsyncWithHttpInfo(accessToken, xeroTenantId, projectId, projectCreateOrUpdate, idempotencyKey, cancellationToken);
        return response;
    }

    public System.Threading.Tasks.Task UpdateTaskAsync(string accessToken, string xeroTenantId, Guid projectId, Guid taskId, TaskCreateOrUpdate taskCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<ApiResponse<object>> UpdateTaskAsyncWithHttpInfo(Guid projectId, Guid taskId, TaskCreateOrUpdate taskCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateTaskAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, projectId, taskId, taskCreateOrUpdate, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<object>> UpdateTaskAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, Guid taskId, TaskCreateOrUpdate taskCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<object> response = await projectXeroClient.UpdateTaskAsyncWithHttpInfo(accessToken, xeroTenantId, projectId, taskId, taskCreateOrUpdate, idempotencyKey, cancellationToken);
        return response;
    }

    public System.Threading.Tasks.Task UpdateTimeEntryAsync(string accessToken, string xeroTenantId, Guid projectId, Guid timeEntryId, TimeEntryCreateOrUpdate timeEntryCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<ApiResponse<object>> UpdateTimeEntryAsyncWithHttpInfo(Guid projectId, Guid timeEntryId, TimeEntryCreateOrUpdate timeEntryCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateTimeEntryAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, projectId, timeEntryId, timeEntryCreateOrUpdate, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<object>> UpdateTimeEntryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, Guid timeEntryId, TimeEntryCreateOrUpdate timeEntryCreateOrUpdate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<object> response = await projectXeroClient.UpdateTimeEntryAsyncWithHttpInfo(accessToken, xeroTenantId, projectId, timeEntryId, timeEntryCreateOrUpdate, idempotencyKey, cancellationToken);
        return response;
    }
}

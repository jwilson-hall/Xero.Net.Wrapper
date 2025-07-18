using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Project;

public partial class XeroService : IProjectApi
{
    public Task<Project> CreateProjectAsync(string accessToken, string xeroTenantId, ProjectCreateOrUpdate projectCreateOrUpdate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Project>> CreateProjectAsyncWithHttpInfo(string accessToken, string xeroTenantId, ProjectCreateOrUpdate projectCreateOrUpdate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Xero.NetStandard.OAuth2.Model.Project.Task> CreateTaskAsync(string accessToken, string xeroTenantId, Guid projectId, TaskCreateOrUpdate taskCreateOrUpdate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Xero.NetStandard.OAuth2.Model.Project.Task>> CreateTaskAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, TaskCreateOrUpdate taskCreateOrUpdate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TimeEntry> CreateTimeEntryAsync(string accessToken, string xeroTenantId, Guid projectId, TimeEntryCreateOrUpdate timeEntryCreateOrUpdate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TimeEntry>> CreateTimeEntryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, TimeEntryCreateOrUpdate timeEntryCreateOrUpdate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public System.Threading.Tasks.Task DeleteTaskAsync(string accessToken, string xeroTenantId, Guid projectId, Guid taskId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<object>> DeleteTaskAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, Guid taskId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public System.Threading.Tasks.Task DeleteTimeEntryAsync(string accessToken, string xeroTenantId, Guid projectId, Guid timeEntryId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<object>> DeleteTimeEntryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, Guid timeEntryId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Project> GetProjectAsync(string accessToken, string xeroTenantId, Guid projectId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Project>> GetProjectAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Projects> GetProjectsAsync(string accessToken, string xeroTenantId, List<Guid> projectIds = null, Guid? contactID = null, string states = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Projects>> GetProjectsAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<Guid> projectIds = null, Guid? contactID = null, string states = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ProjectUsers> GetProjectUsersAsync(string accessToken, string xeroTenantId, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ProjectUsers>> GetProjectUsersAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Xero.NetStandard.OAuth2.Model.Project.Task> GetTaskAsync(string accessToken, string xeroTenantId, Guid projectId, Guid taskId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Xero.NetStandard.OAuth2.Model.Project.Task>> GetTaskAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, Guid taskId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Tasks> GetTasksAsync(string accessToken, string xeroTenantId, Guid projectId, int? page = null, int? pageSize = null, string taskIds = null, ChargeType? chargeType = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Tasks>> GetTasksAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, int? page = null, int? pageSize = null, string taskIds = null, ChargeType? chargeType = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TimeEntries> GetTimeEntriesAsync(string accessToken, string xeroTenantId, Guid projectId, Guid? userId = null, Guid? taskId = null, Guid? invoiceId = null, Guid? contactId = null, int? page = null, int? pageSize = null, List<string> states = null, bool? isChargeable = null, DateTime? dateAfterUtc = null, DateTime? dateBeforeUtc = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TimeEntries>> GetTimeEntriesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, Guid? userId = null, Guid? taskId = null, Guid? invoiceId = null, Guid? contactId = null, int? page = null, int? pageSize = null, List<string> states = null, bool? isChargeable = null, DateTime? dateAfterUtc = null, DateTime? dateBeforeUtc = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TimeEntry> GetTimeEntryAsync(string accessToken, string xeroTenantId, Guid projectId, Guid timeEntryId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TimeEntry>> GetTimeEntryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, Guid timeEntryId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public System.Threading.Tasks.Task PatchProjectAsync(string accessToken, string xeroTenantId, Guid projectId, ProjectPatch projectPatch, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<object>> PatchProjectAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, ProjectPatch projectPatch, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public System.Threading.Tasks.Task UpdateProjectAsync(string accessToken, string xeroTenantId, Guid projectId, ProjectCreateOrUpdate projectCreateOrUpdate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<object>> UpdateProjectAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, ProjectCreateOrUpdate projectCreateOrUpdate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public System.Threading.Tasks.Task UpdateTaskAsync(string accessToken, string xeroTenantId, Guid projectId, Guid taskId, TaskCreateOrUpdate taskCreateOrUpdate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<object>> UpdateTaskAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, Guid taskId, TaskCreateOrUpdate taskCreateOrUpdate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public System.Threading.Tasks.Task UpdateTimeEntryAsync(string accessToken, string xeroTenantId, Guid projectId, Guid timeEntryId, TimeEntryCreateOrUpdate timeEntryCreateOrUpdate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<object>> UpdateTimeEntryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid projectId, Guid timeEntryId, TimeEntryCreateOrUpdate timeEntryCreateOrUpdate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}

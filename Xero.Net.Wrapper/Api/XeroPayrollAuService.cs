using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.PayrollAu;

namespace Xero.Net.Wrapper.Api;

public partial class XeroService : IPayrollAuApi
{
    public async Task<LeaveApplications> ApproveLeaveApplicationAsync(Guid leaveApplicationID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await ApproveLeaveApplicationAsync(accessToken, xeroExtendedConfiguration.TenantId, leaveApplicationID, idempotencyKey, cancellationToken);
    }

    public async Task<LeaveApplications> ApproveLeaveApplicationAsync(string accessToken, string xeroTenantId, Guid leaveApplicationID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await ApproveLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LeaveApplications>> ApproveLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveApplicationID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await payrollAuXeroClient.ApproveLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<Employees> CreateEmployeeAsync(List<Employee> employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeeAsync(accessToken, xeroExtendedConfiguration.TenantId, employee, idempotencyKey, cancellationToken);
    }

    public async Task<Employees> CreateEmployeeAsync(string accessToken, string xeroTenantId, List<Employee> employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await CreateEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employee, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Employees>> CreateEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<Employee> employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await payrollAuXeroClient.CreateEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employee, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<LeaveApplications> CreateLeaveApplicationAsync(List<LeaveApplication> leaveApplication, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateLeaveApplicationAsync(accessToken, xeroExtendedConfiguration.TenantId, leaveApplication, idempotencyKey, cancellationToken);
    }

    public async Task<LeaveApplications> CreateLeaveApplicationAsync(string accessToken, string xeroTenantId, List<LeaveApplication> leaveApplication, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await CreateLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplication, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LeaveApplications>> CreateLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<LeaveApplication> leaveApplication, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await payrollAuXeroClient.CreateLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplication, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<PayItems> CreatePayItemAsync(PayItem payItem, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreatePayItemAsync(accessToken, xeroExtendedConfiguration.TenantId, payItem, idempotencyKey, cancellationToken);
    }

    public async Task<PayItems> CreatePayItemAsync(string accessToken, string xeroTenantId, PayItem payItem, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayItems> response = await CreatePayItemAsyncWithHttpInfo(accessToken, xeroTenantId, payItem, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayItems>> CreatePayItemAsyncWithHttpInfo(string accessToken, string xeroTenantId, PayItem payItem, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayItems> response = await payrollAuXeroClient.CreatePayItemAsyncWithHttpInfo(accessToken, xeroTenantId, payItem, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<PayrollCalendars> CreatePayrollCalendarAsync(List<PayrollCalendar> payrollCalendar, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreatePayrollCalendarAsync(accessToken, xeroExtendedConfiguration.TenantId, payrollCalendar, idempotencyKey, cancellationToken);
    }

    public async Task<PayrollCalendars> CreatePayrollCalendarAsync(string accessToken, string xeroTenantId, List<PayrollCalendar> payrollCalendar, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayrollCalendars> response = await CreatePayrollCalendarAsyncWithHttpInfo(accessToken, xeroTenantId, payrollCalendar, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayrollCalendars>> CreatePayrollCalendarAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<PayrollCalendar> payrollCalendar, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayrollCalendars> response = await payrollAuXeroClient.CreatePayrollCalendarAsyncWithHttpInfo(accessToken, xeroTenantId, payrollCalendar, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<PayRuns> CreatePayRunAsync(List<PayRun> payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreatePayRunAsync(accessToken, xeroExtendedConfiguration.TenantId, payRun, idempotencyKey, cancellationToken);
    }



    public async Task<PayRuns> CreatePayRunAsync(string accessToken, string xeroTenantId, List<PayRun> payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayRuns> response = await CreatePayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRun, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayRuns>> CreatePayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<PayRun> payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayRuns> response = await payrollAuXeroClient.CreatePayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRun, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<SuperFunds> CreateSuperfundAsync(List<SuperFund> superFund, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateSuperfundAsync(accessToken, xeroExtendedConfiguration.TenantId, superFund, idempotencyKey, cancellationToken);
    }



    public async Task<SuperFunds> CreateSuperfundAsync(string accessToken, string xeroTenantId, List<SuperFund> superFund, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFunds> response = await CreateSuperfundAsyncWithHttpInfo(accessToken, xeroTenantId, superFund, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SuperFunds>> CreateSuperfundAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<SuperFund> superFund, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFunds> response = await payrollAuXeroClient.CreateSuperfundAsyncWithHttpInfo(accessToken, xeroTenantId, superFund, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Timesheets> CreateTimesheetAsync(List<Timesheet> timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateTimesheetAsync(accessToken, xeroExtendedConfiguration.TenantId, timesheet, idempotencyKey, cancellationToken);
    }

    public async Task<Timesheets> CreateTimesheetAsync(string accessToken, string xeroTenantId, List<Timesheet> timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Timesheets> response = await CreateTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheet, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Timesheets>> CreateTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<Timesheet> timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Timesheets> response = await payrollAuXeroClient.CreateTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheet, idempotencyKey, cancellationToken);
        return response;
    }

    Task<Employees> IPayrollAuApiAsync.GetEmployeeAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        return PayrollAuGetEmployeeAsync(accessToken, xeroTenantId, employeeID, cancellationToken);
    }

    Task<ApiResponse<Employees>> IPayrollAuApiAsync.GetEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        return PayrollAuGetEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
    }

    public async Task<Employees> PayrollAuGetEmployeeAsync(Guid employeeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuGetEmployeeAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, cancellationToken);
    }

    public async Task<Employees> PayrollAuGetEmployeeAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await PayrollAuGetEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Employees>> PayrollAuGetEmployeeAsyncWithHttpInfo(Guid employeeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetEmployeeAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, cancellationToken);
    }

    public async Task<ApiResponse<Employees>> PayrollAuGetEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await payrollAuXeroClient.GetEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response;
    }


    public async Task<Employees> GetEmployeesAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeesAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }
    public async Task<Employees> GetEmployeesAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await GetEmployeesAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Employees>> GetEmployeesAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await payrollAuXeroClient.GetEmployeesAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response;
    }
    public async Task<LeaveApplications> GetLeaveApplicationAsync(Guid leaveApplicationID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetLeaveApplicationAsync(accessToken, xeroExtendedConfiguration.TenantId, leaveApplicationID, cancellationToken);
    }



    public async Task<LeaveApplications> GetLeaveApplicationAsync(string accessToken, string xeroTenantId, Guid leaveApplicationID, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await GetLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LeaveApplications>> GetLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveApplicationID, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await payrollAuXeroClient.GetLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, cancellationToken);
        return response;
    }
    public async Task<LeaveApplications> GetLeaveApplicationsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetLeaveApplicationsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }



    public async Task<LeaveApplications> GetLeaveApplicationsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await GetLeaveApplicationsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LeaveApplications>> GetLeaveApplicationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await payrollAuXeroClient.GetLeaveApplicationsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response;
    }
    public async Task<LeaveApplications> GetLeaveApplicationsV2Async(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetLeaveApplicationsV2Async(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }



    public async Task<LeaveApplications> GetLeaveApplicationsV2Async(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await GetLeaveApplicationsV2AsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LeaveApplications>> GetLeaveApplicationsV2AsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await payrollAuXeroClient.GetLeaveApplicationsV2AsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response;
    }
    public async Task<PayItems> GetPayItemsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPayItemsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }



    public async Task<PayItems> GetPayItemsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayItems> response = await GetPayItemsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayItems>> GetPayItemsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayItems> response = await payrollAuXeroClient.GetPayItemsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response;
    }
    public async Task<PayrollCalendars> GetPayrollCalendarAsync(Guid payrollCalendarID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPayrollCalendarAsync(accessToken, xeroExtendedConfiguration.TenantId, payrollCalendarID, cancellationToken);
    }



    public async Task<PayrollCalendars> GetPayrollCalendarAsync(string accessToken, string xeroTenantId, Guid payrollCalendarID, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayrollCalendars> response = await GetPayrollCalendarAsyncWithHttpInfo(accessToken, xeroTenantId, payrollCalendarID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayrollCalendars>> GetPayrollCalendarAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payrollCalendarID, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayrollCalendars> response = await payrollAuXeroClient.GetPayrollCalendarAsyncWithHttpInfo(accessToken, xeroTenantId, payrollCalendarID, cancellationToken);
        return response;
    }
    public async Task<PayrollCalendars> GetPayrollCalendarsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPayrollCalendarsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }



    public async Task<PayrollCalendars> GetPayrollCalendarsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayrollCalendars> response = await GetPayrollCalendarsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayrollCalendars>> GetPayrollCalendarsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayrollCalendars> response = await payrollAuXeroClient.GetPayrollCalendarsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response;
    }
    public async Task<PayRuns> GetPayRunAsync(Guid payRunID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPayRunAsync(accessToken, xeroExtendedConfiguration.TenantId, payRunID, cancellationToken);
    }



    public async Task<PayRuns> GetPayRunAsync(string accessToken, string xeroTenantId, Guid payRunID, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayRuns> response = await GetPayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRunID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayRuns>> GetPayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payRunID, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayRuns> response = await payrollAuXeroClient.GetPayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRunID, cancellationToken);
        return response;
    }
    public async Task<PayRuns> GetPayRunsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPayRunsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }



    public async Task<PayRuns> GetPayRunsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayRuns> response = await GetPayRunsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayRuns>> GetPayRunsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayRuns> response = await payrollAuXeroClient.GetPayRunsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response;
    }
    public async Task<PayslipObject> GetPayslipAsync(Guid payslipID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPayslipAsync(accessToken, xeroExtendedConfiguration.TenantId, payslipID, cancellationToken);
    }



    public async Task<PayslipObject> GetPayslipAsync(string accessToken, string xeroTenantId, Guid payslipID, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayslipObject> response = await GetPayslipAsyncWithHttpInfo(accessToken, xeroTenantId, payslipID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayslipObject>> GetPayslipAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payslipID, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayslipObject> response = await payrollAuXeroClient.GetPayslipAsyncWithHttpInfo(accessToken, xeroTenantId, payslipID, cancellationToken);
        return response;
    }
    public async Task<SettingsObject> GetSettingsAsync(CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetSettingsAsync(accessToken, xeroExtendedConfiguration.TenantId, cancellationToken);
    }



    public async Task<SettingsObject> GetSettingsAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        ApiResponse<SettingsObject> response = await GetSettingsAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SettingsObject>> GetSettingsAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        ApiResponse<SettingsObject> response = await payrollAuXeroClient.GetSettingsAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response;
    }
    public async Task<SuperFunds> GetSuperfundAsync(Guid superFundID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetSuperfundAsync(accessToken, xeroExtendedConfiguration.TenantId, superFundID, cancellationToken);
    }



    public async Task<SuperFunds> GetSuperfundAsync(string accessToken, string xeroTenantId, Guid superFundID, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFunds> response = await GetSuperfundAsyncWithHttpInfo(accessToken, xeroTenantId, superFundID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SuperFunds>> GetSuperfundAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid superFundID, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFunds> response = await payrollAuXeroClient.GetSuperfundAsyncWithHttpInfo(accessToken, xeroTenantId, superFundID, cancellationToken);
        return response;
    }
    public async Task<SuperFundProducts> GetSuperfundProductsAsync(string? ABN = null, string? USI = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetSuperfundProductsAsync(accessToken, xeroExtendedConfiguration.TenantId, ABN, USI, cancellationToken);
    }



    public async Task<SuperFundProducts> GetSuperfundProductsAsync(string accessToken, string xeroTenantId, string? ABN = null, string? USI = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFundProducts> response = await GetSuperfundProductsAsyncWithHttpInfo(accessToken, xeroTenantId, ABN, USI, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SuperFundProducts>> GetSuperfundProductsAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? ABN = null, string? USI = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFundProducts> response = await payrollAuXeroClient.GetSuperfundProductsAsyncWithHttpInfo(accessToken, xeroTenantId, ABN, USI, cancellationToken);
        return response;
    }
    public async Task<SuperFunds> GetSuperfundsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetSuperfundsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }



    public async Task<SuperFunds> GetSuperfundsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFunds> response = await GetSuperfundsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SuperFunds>> GetSuperfundsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFunds> response = await payrollAuXeroClient.GetSuperfundsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response;
    }
    public async Task<TimesheetObject> GetTimesheetAsync(Guid timesheetID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetTimesheetAsync(accessToken, xeroExtendedConfiguration.TenantId, timesheetID, cancellationToken);
    }



    public async Task<TimesheetObject> GetTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, CancellationToken cancellationToken = default)
    {
        ApiResponse<TimesheetObject> response = await GetTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TimesheetObject>> GetTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, CancellationToken cancellationToken = default)
    {
        ApiResponse<TimesheetObject> response = await payrollAuXeroClient.GetTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, cancellationToken);
        return response;
    }
    public async Task<Timesheets> GetTimesheetsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetTimesheetsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    public async Task<Timesheets> GetTimesheetsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Timesheets> response = await GetTimesheetsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Timesheets>> GetTimesheetsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Timesheets> response = await payrollAuXeroClient.GetTimesheetsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response;
    }
    public async Task<LeaveApplications> RejectLeaveApplicationAsync(Guid leaveApplicationID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await RejectLeaveApplicationAsync(accessToken, xeroExtendedConfiguration.TenantId, leaveApplicationID, idempotencyKey, cancellationToken);
    }



    public async Task<LeaveApplications> RejectLeaveApplicationAsync(string accessToken, string xeroTenantId, Guid leaveApplicationID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await RejectLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LeaveApplications>> RejectLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveApplicationID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await payrollAuXeroClient.RejectLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Employees> UpdateEmployeeAsync(Guid employeeID, List<Employee> employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateEmployeeAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employee, idempotencyKey, cancellationToken);
    }



    public async Task<Employees> UpdateEmployeeAsync(string accessToken, string xeroTenantId, Guid employeeID, List<Employee> employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await UpdateEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employee, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Employees>> UpdateEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, List<Employee> employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await payrollAuXeroClient.UpdateEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employee, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<LeaveApplications> UpdateLeaveApplicationAsync(Guid leaveApplicationID, List<LeaveApplication> leaveApplication, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateLeaveApplicationAsync(accessToken, xeroExtendedConfiguration.TenantId, leaveApplicationID, leaveApplication, idempotencyKey, cancellationToken);
    }



    public async Task<LeaveApplications> UpdateLeaveApplicationAsync(string accessToken, string xeroTenantId, Guid leaveApplicationID, List<LeaveApplication> leaveApplication, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await UpdateLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, leaveApplication, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LeaveApplications>> UpdateLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveApplicationID, List<LeaveApplication> leaveApplication, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await payrollAuXeroClient.UpdateLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, leaveApplication, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<PayRuns> UpdatePayRunAsync(Guid payRunID, List<PayRun> payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdatePayRunAsync(accessToken, xeroExtendedConfiguration.TenantId, payRunID, payRun, idempotencyKey, cancellationToken);
    }



    public async Task<PayRuns> UpdatePayRunAsync(string accessToken, string xeroTenantId, Guid payRunID, List<PayRun> payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayRuns> response = await UpdatePayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRunID, payRun, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayRuns>> UpdatePayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payRunID, List<PayRun> payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayRuns> response = await payrollAuXeroClient.UpdatePayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRunID, payRun, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Payslips> UpdatePayslipAsync(Guid payslipID, List<PayslipLines> payslipLines, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdatePayslipAsync(accessToken, xeroExtendedConfiguration.TenantId, payslipID, payslipLines, idempotencyKey, cancellationToken);
    }



    public async Task<Payslips> UpdatePayslipAsync(string accessToken, string xeroTenantId, Guid payslipID, List<PayslipLines> payslipLines, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Payslips> response = await UpdatePayslipAsyncWithHttpInfo(accessToken, xeroTenantId, payslipID, payslipLines, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Payslips>> UpdatePayslipAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payslipID, List<PayslipLines> payslipLines, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Payslips> response = await payrollAuXeroClient.UpdatePayslipAsyncWithHttpInfo(accessToken, xeroTenantId, payslipID, payslipLines, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<SuperFunds> UpdateSuperfundAsync(Guid superFundID, List<SuperFund> superFund, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateSuperfundAsync(accessToken, xeroExtendedConfiguration.TenantId, superFundID, superFund, idempotencyKey, cancellationToken);
    }



    public async Task<SuperFunds> UpdateSuperfundAsync(string accessToken, string xeroTenantId, Guid superFundID, List<SuperFund> superFund, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFunds> response = await UpdateSuperfundAsyncWithHttpInfo(accessToken, xeroTenantId, superFundID, superFund, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SuperFunds>> UpdateSuperfundAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid superFundID, List<SuperFund> superFund, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFunds> response = await payrollAuXeroClient.UpdateSuperfundAsyncWithHttpInfo(accessToken, xeroTenantId, superFundID, superFund, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Timesheets> UpdateTimesheetAsync(Guid timesheetID, List<Timesheet> timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateTimesheetAsync(accessToken, xeroExtendedConfiguration.TenantId, timesheetID, timesheet, idempotencyKey, cancellationToken);
    }



    public async Task<Timesheets> UpdateTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, List<Timesheet> timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Timesheets> response = await UpdateTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, timesheet, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Timesheets>> UpdateTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, List<Timesheet> timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Timesheets> response = await payrollAuXeroClient.UpdateTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, timesheet, idempotencyKey, cancellationToken);
        return response;
    }
}

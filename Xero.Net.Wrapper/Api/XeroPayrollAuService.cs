using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.PayrollAu;

namespace Xero.Net.Wrapper.Api;

public partial class XeroService : IPayrollAuApi
{
    Task<LeaveApplications> IPayrollAuApiAsync.ApproveLeaveApplicationAsync(string accessToken, string xeroTenantId, Guid leaveApplicationID, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuApproveLeaveApplicationAsync(accessToken, xeroTenantId, leaveApplicationID, idempotencyKey, cancellationToken);
    }

    Task<ApiResponse<LeaveApplications>> IPayrollAuApiAsync.ApproveLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveApplicationID, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuApproveLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, idempotencyKey, cancellationToken);
    }
    public async Task<LeaveApplications> PayrollAuApproveLeaveApplicationAsync(Guid leaveApplicationID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuApproveLeaveApplicationAsync(accessToken, xeroExtendedConfiguration.TenantId, leaveApplicationID, idempotencyKey, cancellationToken);
    }

    public async Task<LeaveApplications> PayrollAuApproveLeaveApplicationAsync(string accessToken, string xeroTenantId, Guid leaveApplicationID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await PayrollAuApproveLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LeaveApplications>> PayrollAuApproveLeaveApplicationAsyncWithHttpInfo(Guid leaveApplicationID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuApproveLeaveApplicationAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, leaveApplicationID, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<LeaveApplications>> PayrollAuApproveLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveApplicationID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await payrollAuXeroClient.ApproveLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, idempotencyKey, cancellationToken);
        return response;
    }

    Task<Employees> IPayrollAuApiAsync.CreateEmployeeAsync(string accessToken, string xeroTenantId, List<Employee> employee, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuCreateEmployeeAsync(accessToken, xeroTenantId, employee, idempotencyKey, cancellationToken);
    }

    Task<ApiResponse<Employees>> IPayrollAuApiAsync.CreateEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<Employee> employee, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuCreateEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employee, idempotencyKey, cancellationToken);
    }

    public async Task<Employees> PayrollAuCreateEmployeeAsync(List<Employee> employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuCreateEmployeeAsync(accessToken, xeroExtendedConfiguration.TenantId, employee, idempotencyKey, cancellationToken);
    }

    public async Task<Employees> PayrollAuCreateEmployeeAsync(string accessToken, string xeroTenantId, List<Employee> employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await PayrollAuCreateEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employee, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Employees>> PayrollAuCreateEmployeeAsyncWithHttpInfo(List<Employee> employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuCreateEmployeeAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employee, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<Employees>> PayrollAuCreateEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<Employee> employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await payrollAuXeroClient.CreateEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employee, idempotencyKey, cancellationToken);
        return response;
    }

    Task<LeaveApplications> IPayrollAuApiAsync.CreateLeaveApplicationAsync(string accessToken, string xeroTenantId, List<LeaveApplication> leaveApplication, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuCreateLeaveApplicationAsync(accessToken, xeroTenantId, leaveApplication, idempotencyKey, cancellationToken);
    }

    Task<ApiResponse<LeaveApplications>> IPayrollAuApiAsync.CreateLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<LeaveApplication> leaveApplication, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuCreateLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplication, idempotencyKey, cancellationToken);
    }

    public async Task<LeaveApplications> PayrollAuCreateLeaveApplicationAsync(List<LeaveApplication> leaveApplication, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuCreateLeaveApplicationAsync(accessToken, xeroExtendedConfiguration.TenantId, leaveApplication, idempotencyKey, cancellationToken);
    }

    public async Task<LeaveApplications> PayrollAuCreateLeaveApplicationAsync(string accessToken, string xeroTenantId, List<LeaveApplication> leaveApplication, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await PayrollAuCreateLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplication, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LeaveApplications>> PayrollAuCreateLeaveApplicationAsyncWithHttpInfo(List<LeaveApplication> leaveApplication, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuCreateLeaveApplicationAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, leaveApplication, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<LeaveApplications>> PayrollAuCreateLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<LeaveApplication> leaveApplication, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await payrollAuXeroClient.CreateLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplication, idempotencyKey, cancellationToken);
        return response;
    }

    // Explicit interface implementations
    Task<PayItems> IPayrollAuApiAsync.CreatePayItemAsync(string accessToken, string xeroTenantId, PayItem payItem, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuCreatePayItemAsync(accessToken, xeroTenantId, payItem, idempotencyKey, cancellationToken);
    }

    Task<ApiResponse<PayItems>> IPayrollAuApiAsync.CreatePayItemAsyncWithHttpInfo(string accessToken, string xeroTenantId, PayItem payItem, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuCreatePayItemAsyncWithHttpInfo(accessToken, xeroTenantId, payItem, idempotencyKey, cancellationToken);
    }

    // Public methods
    public async Task<PayItems> PayrollAuCreatePayItemAsync(PayItem payItem, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuCreatePayItemAsync(accessToken, xeroExtendedConfiguration.TenantId, payItem, idempotencyKey, cancellationToken);
    }

    public async Task<PayItems> PayrollAuCreatePayItemAsync(string accessToken, string xeroTenantId, PayItem payItem, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayItems> response = await PayrollAuCreatePayItemAsyncWithHttpInfo(accessToken, xeroTenantId, payItem, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayItems>> PayrollAuCreatePayItemAsyncWithHttpInfo(PayItem payItem, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuCreatePayItemAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, payItem, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<PayItems>> PayrollAuCreatePayItemAsyncWithHttpInfo(string accessToken, string xeroTenantId, PayItem payItem, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return await payrollAuXeroClient.CreatePayItemAsyncWithHttpInfo(accessToken, xeroTenantId, payItem, idempotencyKey, cancellationToken);
    }

    // Explicit interface implementations
    Task<PayrollCalendars> IPayrollAuApiAsync.CreatePayrollCalendarAsync(string accessToken,string xeroTenantId,List<PayrollCalendar> payrollCalendar,string? idempotencyKey,CancellationToken cancellationToken)
    {
        return PayrollAuCreatePayrollCalendarAsync(accessToken, xeroTenantId, payrollCalendar, idempotencyKey, cancellationToken);
    }

    Task<ApiResponse<PayrollCalendars>> IPayrollAuApiAsync.CreatePayrollCalendarAsyncWithHttpInfo(string accessToken,string xeroTenantId,List<PayrollCalendar> payrollCalendar,string? idempotencyKey,CancellationToken cancellationToken)
    {
        return PayrollAuCreatePayrollCalendarAsyncWithHttpInfo(accessToken, xeroTenantId, payrollCalendar, idempotencyKey, cancellationToken);
    }

    // Public methods
    public async Task<PayrollCalendars> PayrollAuCreatePayrollCalendarAsync(List<PayrollCalendar> payrollCalendar, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuCreatePayrollCalendarAsync(accessToken, xeroExtendedConfiguration.TenantId, payrollCalendar, idempotencyKey, cancellationToken);
    }

    public async Task<PayrollCalendars> PayrollAuCreatePayrollCalendarAsync(string accessToken, string xeroTenantId, List<PayrollCalendar> payrollCalendar, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayrollCalendars> response = await PayrollAuCreatePayrollCalendarAsyncWithHttpInfo(accessToken, xeroTenantId, payrollCalendar, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayrollCalendars>> PayrollAuCreatePayrollCalendarAsyncWithHttpInfo(List<PayrollCalendar> payrollCalendar,string? idempotencyKey = null,CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuCreatePayrollCalendarAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, payrollCalendar, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<PayrollCalendars>> PayrollAuCreatePayrollCalendarAsyncWithHttpInfo(string accessToken,string xeroTenantId,List<PayrollCalendar> payrollCalendar,string? idempotencyKey = null,CancellationToken cancellationToken = default)
    {
        return await payrollAuXeroClient.CreatePayrollCalendarAsyncWithHttpInfo(accessToken, xeroTenantId, payrollCalendar, idempotencyKey, cancellationToken);
    }

    // Explicit interface implementations
    Task<PayRuns> IPayrollAuApiAsync.CreatePayRunAsync(string accessToken, string xeroTenantId, List<PayRun> payRun, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuCreatePayRunAsync(accessToken, xeroTenantId, payRun, idempotencyKey, cancellationToken);
    }

    Task<ApiResponse<PayRuns>> IPayrollAuApiAsync.CreatePayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<PayRun> payRun, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuCreatePayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRun, idempotencyKey, cancellationToken);
    }

    // Public methods
    public async Task<PayRuns> PayrollAuCreatePayRunAsync(List<PayRun> payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuCreatePayRunAsync(accessToken, xeroExtendedConfiguration.TenantId, payRun, idempotencyKey, cancellationToken);
    }

    public async Task<PayRuns> PayrollAuCreatePayRunAsync(string accessToken, string xeroTenantId, List<PayRun> payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayRuns> response = await PayrollAuCreatePayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRun, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayRuns>> PayrollAuCreatePayRunAsyncWithHttpInfo(List<PayRun> payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuCreatePayRunAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, payRun, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<PayRuns>> PayrollAuCreatePayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<PayRun> payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return await payrollAuXeroClient.CreatePayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRun, idempotencyKey, cancellationToken);
    }

    // Explicit interface implementations
    Task<SuperFunds> IPayrollAuApiAsync.CreateSuperfundAsync(string accessToken, string xeroTenantId, List<SuperFund> superFund, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuCreateSuperfundAsync(accessToken, xeroTenantId, superFund, idempotencyKey, cancellationToken);
    }

    Task<ApiResponse<SuperFunds>> IPayrollAuApiAsync.CreateSuperfundAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<SuperFund> superFund, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuCreateSuperfundAsyncWithHttpInfo(accessToken, xeroTenantId, superFund, idempotencyKey, cancellationToken);
    }

    // Public methods
    public async Task<SuperFunds> PayrollAuCreateSuperfundAsync(List<SuperFund> superFund, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuCreateSuperfundAsync(accessToken, xeroExtendedConfiguration.TenantId, superFund, idempotencyKey, cancellationToken);
    }

    public async Task<SuperFunds> PayrollAuCreateSuperfundAsync(string accessToken, string xeroTenantId, List<SuperFund> superFund, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFunds> response = await PayrollAuCreateSuperfundAsyncWithHttpInfo(accessToken, xeroTenantId, superFund, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SuperFunds>> PayrollAuCreateSuperfundAsyncWithHttpInfo(List<SuperFund> superFund, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuCreateSuperfundAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, superFund, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<SuperFunds>> PayrollAuCreateSuperfundAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<SuperFund> superFund, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return await payrollAuXeroClient.CreateSuperfundAsyncWithHttpInfo(accessToken, xeroTenantId, superFund, idempotencyKey, cancellationToken);
    }

    // Explicit interface implementations
    Task<Timesheets> IPayrollAuApiAsync.CreateTimesheetAsync(string accessToken, string xeroTenantId, List<Timesheet> timesheet, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuCreateTimesheetAsync(accessToken, xeroTenantId, timesheet, idempotencyKey, cancellationToken);
    }

    Task<ApiResponse<Timesheets>> IPayrollAuApiAsync.CreateTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<Timesheet> timesheet, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuCreateTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheet, idempotencyKey, cancellationToken);
    }

    // Public methods
    public async Task<Timesheets> PayrollAuCreateTimesheetAsync(List<Timesheet> timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuCreateTimesheetAsync(accessToken, xeroExtendedConfiguration.TenantId, timesheet, idempotencyKey, cancellationToken);
    }

    public async Task<Timesheets> PayrollAuCreateTimesheetAsync(string accessToken, string xeroTenantId, List<Timesheet> timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Timesheets> response = await PayrollAuCreateTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheet, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Timesheets>> PayrollAuCreateTimesheetAsyncWithHttpInfo(List<Timesheet> timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuCreateTimesheetAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, timesheet, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<Timesheets>> PayrollAuCreateTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<Timesheet> timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return await payrollAuXeroClient.CreateTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheet, idempotencyKey, cancellationToken);
    }


    // Explicit interface implementations
    Task<Employees> IPayrollAuApiAsync.GetEmployeeAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        return PayrollAuGetEmployeeAsync(accessToken, xeroTenantId, employeeID, cancellationToken);
    }

    Task<ApiResponse<Employees>> IPayrollAuApiAsync.GetEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        return PayrollAuGetEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
    }

    // Public methods
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
        return await payrollAuXeroClient.GetEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
    }

    // Explicit interface implementations
    Task<Employees> IPayrollAuApiAsync.GetEmployeesAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince, string? where, string? order, int? page, CancellationToken cancellationToken)
    {
        return PayrollAuGetEmployeesAsync(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    Task<ApiResponse<Employees>> IPayrollAuApiAsync.GetEmployeesAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince, string? where, string? order, int? page, CancellationToken cancellationToken)
    {
        return PayrollAuGetEmployeesAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    // Public methods
    public async Task<Employees> PayrollAuGetEmployeesAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetEmployeesAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    public async Task<Employees> PayrollAuGetEmployeesAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await PayrollAuGetEmployeesAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Employees>> PayrollAuGetEmployeesAsyncWithHttpInfo(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetEmployeesAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    public async Task<ApiResponse<Employees>> PayrollAuGetEmployeesAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await payrollAuXeroClient.GetEmployeesAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response;
    }

    // Explicit interface implementations
    Task<LeaveApplications> IPayrollAuApiAsync.GetLeaveApplicationAsync(string accessToken, string xeroTenantId, Guid leaveApplicationID, CancellationToken cancellationToken)
    {
        return PayrollAuGetLeaveApplicationAsync(accessToken, xeroTenantId, leaveApplicationID, cancellationToken);
    }

    Task<ApiResponse<LeaveApplications>> IPayrollAuApiAsync.GetLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveApplicationID, CancellationToken cancellationToken)
    {
        return PayrollAuGetLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, cancellationToken);
    }

    // Public methods
    public async Task<LeaveApplications> PayrollAuGetLeaveApplicationAsync(Guid leaveApplicationID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuGetLeaveApplicationAsync(accessToken, xeroExtendedConfiguration.TenantId, leaveApplicationID, cancellationToken);
    }

    public async Task<LeaveApplications> PayrollAuGetLeaveApplicationAsync(string accessToken, string xeroTenantId, Guid leaveApplicationID, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await PayrollAuGetLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LeaveApplications>> PayrollAuGetLeaveApplicationAsyncWithHttpInfo(Guid leaveApplicationID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuGetLeaveApplicationAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, leaveApplicationID, cancellationToken);
    }

    public async Task<ApiResponse<LeaveApplications>> PayrollAuGetLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveApplicationID, CancellationToken cancellationToken = default)
    {
        return await payrollAuXeroClient.GetLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, cancellationToken);
    }
    // Explicit interface implementations
    Task<LeaveApplications> IPayrollAuApiAsync.GetLeaveApplicationsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince, string? where, string? order, int? page, CancellationToken cancellationToken)
    {
        return PayrollAuGetLeaveApplicationsAsync(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    Task<ApiResponse<LeaveApplications>> IPayrollAuApiAsync.GetLeaveApplicationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince, string? where, string? order, int? page, CancellationToken cancellationToken)
    {
        return PayrollAuGetLeaveApplicationsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    // Public methods
    public async Task<LeaveApplications> PayrollAuGetLeaveApplicationsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuGetLeaveApplicationsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    public async Task<LeaveApplications> PayrollAuGetLeaveApplicationsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await PayrollAuGetLeaveApplicationsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LeaveApplications>> PayrollAuGetLeaveApplicationsAsyncWithHttpInfo(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuGetLeaveApplicationsAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    public async Task<ApiResponse<LeaveApplications>> PayrollAuGetLeaveApplicationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        return await payrollAuXeroClient.GetLeaveApplicationsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    // Explicit interface implementations
    Task<LeaveApplications> IPayrollAuApiAsync.GetLeaveApplicationsV2Async(string accessToken, string xeroTenantId, DateTime? ifModifiedSince, string? where, string? order, int? page, CancellationToken cancellationToken)
    {
        return PayrollAuGetLeaveApplicationsV2Async(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    Task<ApiResponse<LeaveApplications>> IPayrollAuApiAsync.GetLeaveApplicationsV2AsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince, string? where, string? order, int? page, CancellationToken cancellationToken)
    {
        return PayrollAuGetLeaveApplicationsV2AsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    // Public methods
    public async Task<LeaveApplications> PayrollAuGetLeaveApplicationsV2Async(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuGetLeaveApplicationsV2Async(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    public async Task<LeaveApplications> PayrollAuGetLeaveApplicationsV2Async(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await PayrollAuGetLeaveApplicationsV2AsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LeaveApplications>> PayrollAuGetLeaveApplicationsV2AsyncWithHttpInfo(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuGetLeaveApplicationsV2AsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    public async Task<ApiResponse<LeaveApplications>> PayrollAuGetLeaveApplicationsV2AsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        return await payrollAuXeroClient.GetLeaveApplicationsV2AsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    // Explicit interface implementations
    Task<PayItems> IPayrollAuApiAsync.GetPayItemsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince, string? where, string? order, int? page, CancellationToken cancellationToken)
    {
        return PayrollAuGetPayItemsAsync(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    Task<ApiResponse<PayItems>> IPayrollAuApiAsync.GetPayItemsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince, string? where, string? order, int? page, CancellationToken cancellationToken)
    {
        return PayrollAuGetPayItemsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    // Public methods
    public async Task<PayItems> PayrollAuGetPayItemsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuGetPayItemsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    public async Task<PayItems> PayrollAuGetPayItemsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayItems> response = await PayrollAuGetPayItemsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayItems>> PayrollAuGetPayItemsAsyncWithHttpInfo(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuGetPayItemsAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    public async Task<ApiResponse<PayItems>> PayrollAuGetPayItemsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        return await payrollAuXeroClient.GetPayItemsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }
    // Explicit interface implementations
    Task<PayrollCalendars> IPayrollAuApiAsync.GetPayrollCalendarAsync(string accessToken, string xeroTenantId, Guid payrollCalendarID, CancellationToken cancellationToken)
    {
        return PayrollAuGetPayrollCalendarAsync(accessToken, xeroTenantId, payrollCalendarID, cancellationToken);
    }

    Task<ApiResponse<PayrollCalendars>> IPayrollAuApiAsync.GetPayrollCalendarAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payrollCalendarID, CancellationToken cancellationToken)
    {
        return PayrollAuGetPayrollCalendarAsyncWithHttpInfo(accessToken, xeroTenantId, payrollCalendarID, cancellationToken);
    }

    // Public methods
    public async Task<PayrollCalendars> PayrollAuGetPayrollCalendarAsync(Guid payrollCalendarID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuGetPayrollCalendarAsync(accessToken, xeroExtendedConfiguration.TenantId, payrollCalendarID, cancellationToken);
    }

    public async Task<PayrollCalendars> PayrollAuGetPayrollCalendarAsync(string accessToken, string xeroTenantId, Guid payrollCalendarID, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayrollCalendars> response = await PayrollAuGetPayrollCalendarAsyncWithHttpInfo(accessToken, xeroTenantId, payrollCalendarID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayrollCalendars>> PayrollAuGetPayrollCalendarAsyncWithHttpInfo(Guid payrollCalendarID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollAuGetPayrollCalendarAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, payrollCalendarID, cancellationToken);
    }

    public async Task<ApiResponse<PayrollCalendars>> PayrollAuGetPayrollCalendarAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payrollCalendarID, CancellationToken cancellationToken = default)
    {
        return await payrollAuXeroClient.GetPayrollCalendarAsyncWithHttpInfo(accessToken, xeroTenantId, payrollCalendarID, cancellationToken);
    }

    // Explicit interface implementations
    Task<PayrollCalendars> IPayrollAuApiAsync.GetPayrollCalendarsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince, string? where, string? order, int? page, CancellationToken cancellationToken)
    {
        return PayrollAuGetPayrollCalendarsAsync(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    Task<ApiResponse<PayrollCalendars>> IPayrollAuApiAsync.GetPayrollCalendarsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince, string? where, string? order, int? page, CancellationToken cancellationToken)
    {
        return PayrollAuGetPayrollCalendarsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    // Public methods
    public async Task<PayrollCalendars> PayrollAuGetPayrollCalendarsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetPayrollCalendarsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    public async Task<PayrollCalendars> PayrollAuGetPayrollCalendarsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayrollCalendars> response = await PayrollAuGetPayrollCalendarsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayrollCalendars>> PayrollAuGetPayrollCalendarsAsyncWithHttpInfo(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetPayrollCalendarsAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    public async Task<ApiResponse<PayrollCalendars>> PayrollAuGetPayrollCalendarsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayrollCalendars> response = await payrollAuXeroClient.GetPayrollCalendarsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response;
    }

    // Explicit interface implementations
    Task<PayRuns> IPayrollAuApiAsync.GetPayRunAsync(string accessToken, string xeroTenantId, Guid payRunID, CancellationToken cancellationToken)
    {
        return PayrollAuGetPayRunAsync(accessToken, xeroTenantId, payRunID, cancellationToken);
    }

    Task<ApiResponse<PayRuns>> IPayrollAuApiAsync.GetPayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payRunID, CancellationToken cancellationToken)
    {
        return PayrollAuGetPayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRunID, cancellationToken);
    }

    // Public methods
    public async Task<PayRuns> PayrollAuGetPayRunAsync(Guid payRunID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetPayRunAsync(accessToken, xeroExtendedConfiguration.TenantId, payRunID, cancellationToken);
    }

    public async Task<PayRuns> PayrollAuGetPayRunAsync(string accessToken, string xeroTenantId, Guid payRunID, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayRuns> response = await PayrollAuGetPayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRunID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayRuns>> PayrollAuGetPayRunAsyncWithHttpInfo(Guid payRunID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetPayRunAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, payRunID, cancellationToken);
    }

    public async Task<ApiResponse<PayRuns>> PayrollAuGetPayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payRunID, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayRuns> response = await payrollAuXeroClient.GetPayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRunID, cancellationToken);
        return response;
    }

    // Explicit interface implementations
    Task<PayRuns> IPayrollAuApiAsync.GetPayRunsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince, string? where, string? order, int? page, CancellationToken cancellationToken)
    {
        return PayrollAuGetPayRunsAsync(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    Task<ApiResponse<PayRuns>> IPayrollAuApiAsync.GetPayRunsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince, string? where, string? order, int? page, CancellationToken cancellationToken)
    {
        return PayrollAuGetPayRunsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    // Public methods
    public async Task<PayRuns> PayrollAuGetPayRunsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetPayRunsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    public async Task<PayRuns> PayrollAuGetPayRunsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayRuns> response = await PayrollAuGetPayRunsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayRuns>> PayrollAuGetPayRunsAsyncWithHttpInfo(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetPayRunsAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    public async Task<ApiResponse<PayRuns>> PayrollAuGetPayRunsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayRuns> response = await payrollAuXeroClient.GetPayRunsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response;
    }

    // Explicit interface implementations
    Task<PayslipObject> IPayrollAuApiAsync.GetPayslipAsync(string accessToken, string xeroTenantId, Guid payslipID, CancellationToken cancellationToken)
    {
        return PayrollAuGetPayslipAsync(accessToken, xeroTenantId, payslipID, cancellationToken);
    }

    Task<ApiResponse<PayslipObject>> IPayrollAuApiAsync.GetPayslipAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payslipID, CancellationToken cancellationToken)
    {
        return PayrollAuGetPayslipAsyncWithHttpInfo(accessToken, xeroTenantId, payslipID, cancellationToken);
    }

    // Public methods
    public async Task<PayslipObject> PayrollAuGetPayslipAsync(Guid payslipID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetPayslipAsync(accessToken, xeroExtendedConfiguration.TenantId, payslipID, cancellationToken);
    }

    public async Task<PayslipObject> PayrollAuGetPayslipAsync(string accessToken, string xeroTenantId, Guid payslipID, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayslipObject> response = await PayrollAuGetPayslipAsyncWithHttpInfo(accessToken, xeroTenantId, payslipID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayslipObject>> PayrollAuGetPayslipAsyncWithHttpInfo(Guid payslipID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetPayslipAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, payslipID, cancellationToken);
    }

    public async Task<ApiResponse<PayslipObject>> PayrollAuGetPayslipAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payslipID, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayslipObject> response = await payrollAuXeroClient.GetPayslipAsyncWithHttpInfo(accessToken, xeroTenantId, payslipID, cancellationToken);
        return response;
    }

    // Explicit interface implementations
    Task<SettingsObject> IPayrollAuApiAsync.GetSettingsAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken)
    {
        return PayrollAuGetSettingsAsync(accessToken, xeroTenantId, cancellationToken);
    }

    Task<ApiResponse<SettingsObject>> IPayrollAuApiAsync.GetSettingsAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken)
    {
        return PayrollAuGetSettingsAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
    }

    // Public methods
    public async Task<SettingsObject> PayrollAuGetSettingsAsync(CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetSettingsAsync(accessToken, xeroExtendedConfiguration.TenantId, cancellationToken);
    }

    public async Task<SettingsObject> PayrollAuGetSettingsAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        ApiResponse<SettingsObject> response = await PayrollAuGetSettingsAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SettingsObject>> PayrollAuGetSettingsAsyncWithHttpInfo(CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetSettingsAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, cancellationToken);
    }

    public async Task<ApiResponse<SettingsObject>> PayrollAuGetSettingsAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        ApiResponse<SettingsObject> response = await payrollAuXeroClient.GetSettingsAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response;
    }

    // Explicit interface implementations
    Task<SuperFunds> IPayrollAuApiAsync.GetSuperfundAsync(string accessToken, string xeroTenantId, Guid superFundID, CancellationToken cancellationToken)
    {
        return PayrollAuGetSuperfundAsync(accessToken, xeroTenantId, superFundID, cancellationToken);
    }

    Task<ApiResponse<SuperFunds>> IPayrollAuApiAsync.GetSuperfundAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid superFundID, CancellationToken cancellationToken)
    {
        return PayrollAuGetSuperfundAsyncWithHttpInfo(accessToken, xeroTenantId, superFundID, cancellationToken);
    }

    // Public methods
    public async Task<SuperFunds> PayrollAuGetSuperfundAsync(Guid superFundID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetSuperfundAsync(accessToken, xeroExtendedConfiguration.TenantId, superFundID, cancellationToken);
    }

    public async Task<SuperFunds> PayrollAuGetSuperfundAsync(string accessToken, string xeroTenantId, Guid superFundID, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFunds> response = await PayrollAuGetSuperfundAsyncWithHttpInfo(accessToken, xeroTenantId, superFundID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SuperFunds>> PayrollAuGetSuperfundAsyncWithHttpInfo(Guid superFundID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetSuperfundAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, superFundID, cancellationToken);
    }

    public async Task<ApiResponse<SuperFunds>> PayrollAuGetSuperfundAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid superFundID, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFunds> response = await payrollAuXeroClient.GetSuperfundAsyncWithHttpInfo(accessToken, xeroTenantId, superFundID, cancellationToken);
        return response;
    }

    // Explicit interface implementations
    Task<SuperFundProducts> IPayrollAuApiAsync.GetSuperfundProductsAsync(string accessToken, string xeroTenantId, string? ABN, string? USI, CancellationToken cancellationToken)
    {
        return PayrollAuGetSuperfundProductsAsync(accessToken, xeroTenantId, ABN, USI, cancellationToken);
    }

    Task<ApiResponse<SuperFundProducts>> IPayrollAuApiAsync.GetSuperfundProductsAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? ABN, string? USI, CancellationToken cancellationToken)
    {
        return PayrollAuGetSuperfundProductsAsyncWithHttpInfo(accessToken, xeroTenantId, ABN, USI, cancellationToken);
    }

    // Public methods
    public async Task<SuperFundProducts> PayrollAuGetSuperfundProductsAsync(string? ABN = null, string? USI = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetSuperfundProductsAsync(accessToken, xeroExtendedConfiguration.TenantId, ABN, USI, cancellationToken);
    }

    public async Task<SuperFundProducts> PayrollAuGetSuperfundProductsAsync(string accessToken, string xeroTenantId, string? ABN = null, string? USI = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFundProducts> response = await PayrollAuGetSuperfundProductsAsyncWithHttpInfo(accessToken, xeroTenantId, ABN, USI, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SuperFundProducts>> PayrollAuGetSuperfundProductsAsyncWithHttpInfo(string? ABN = null, string? USI = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetSuperfundProductsAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, ABN, USI, cancellationToken);
    }

    public async Task<ApiResponse<SuperFundProducts>> PayrollAuGetSuperfundProductsAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? ABN = null, string? USI = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFundProducts> response = await payrollAuXeroClient.GetSuperfundProductsAsyncWithHttpInfo(accessToken, xeroTenantId, ABN, USI, cancellationToken);
        return response;
    }

    // Explicit interface implementations
    Task<SuperFunds> IPayrollAuApiAsync.GetSuperfundsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince, string? where, string? order, int? page, CancellationToken cancellationToken)
    {
        return PayrollAuGetSuperfundsAsync(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    Task<ApiResponse<SuperFunds>> IPayrollAuApiAsync.GetSuperfundsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince, string? where, string? order, int? page, CancellationToken cancellationToken)
    {
        return PayrollAuGetSuperfundsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    // Public methods
    public async Task<SuperFunds> PayrollAuGetSuperfundsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetSuperfundsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    public async Task<SuperFunds> PayrollAuGetSuperfundsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFunds> response = await PayrollAuGetSuperfundsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SuperFunds>> PayrollAuGetSuperfundsAsyncWithHttpInfo(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetSuperfundsAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    public async Task<ApiResponse<SuperFunds>> PayrollAuGetSuperfundsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFunds> response = await payrollAuXeroClient.GetSuperfundsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response;
    }

    // Explicit interface implementations
    Task<TimesheetObject> IPayrollAuApiAsync.GetTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, CancellationToken cancellationToken)
    {
        return PayrollAuGetTimesheetAsync(accessToken, xeroTenantId, timesheetID, cancellationToken);
    }

    Task<ApiResponse<TimesheetObject>> IPayrollAuApiAsync.GetTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, CancellationToken cancellationToken)
    {
        return PayrollAuGetTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, cancellationToken);
    }

    // Public methods
    public async Task<TimesheetObject> PayrollAuGetTimesheetAsync(Guid timesheetID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetTimesheetAsync(accessToken, xeroExtendedConfiguration.TenantId, timesheetID, cancellationToken);
    }

    public async Task<TimesheetObject> PayrollAuGetTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, CancellationToken cancellationToken = default)
    {
        ApiResponse<TimesheetObject> response = await PayrollAuGetTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TimesheetObject>> PayrollAuGetTimesheetAsyncWithHttpInfo(Guid timesheetID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetTimesheetAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, timesheetID, cancellationToken);
    }

    public async Task<ApiResponse<TimesheetObject>> PayrollAuGetTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, CancellationToken cancellationToken = default)
    {
        ApiResponse<TimesheetObject> response = await payrollAuXeroClient.GetTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, cancellationToken);
        return response;
    }

    // Explicit interface implementations
    Task<Timesheets> IPayrollAuApiAsync.GetTimesheetsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince, string? where, string? order, int? page, CancellationToken cancellationToken)
    {
        return PayrollAuGetTimesheetsAsync(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    Task<ApiResponse<Timesheets>> IPayrollAuApiAsync.GetTimesheetsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince, string? where, string? order, int? page, CancellationToken cancellationToken)
    {
        return PayrollAuGetTimesheetsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    // Public methods
    public async Task<Timesheets> PayrollAuGetTimesheetsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetTimesheetsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    public async Task<Timesheets> PayrollAuGetTimesheetsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Timesheets> response = await PayrollAuGetTimesheetsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Timesheets>> PayrollAuGetTimesheetsAsyncWithHttpInfo(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuGetTimesheetsAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, cancellationToken);
    }

    public async Task<ApiResponse<Timesheets>> PayrollAuGetTimesheetsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Timesheets> response = await payrollAuXeroClient.GetTimesheetsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, cancellationToken);
        return response;
    }

    // Explicit interface implementations
    Task<LeaveApplications> IPayrollAuApiAsync.RejectLeaveApplicationAsync(string accessToken, string xeroTenantId, Guid leaveApplicationID, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuRejectLeaveApplicationAsync(accessToken, xeroTenantId, leaveApplicationID, idempotencyKey, cancellationToken);
    }

    Task<ApiResponse<LeaveApplications>> IPayrollAuApiAsync.RejectLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveApplicationID, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuRejectLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, idempotencyKey, cancellationToken);
    }

    // Public methods
    public async Task<LeaveApplications> PayrollAuRejectLeaveApplicationAsync(Guid leaveApplicationID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuRejectLeaveApplicationAsync(accessToken, xeroExtendedConfiguration.TenantId, leaveApplicationID, idempotencyKey, cancellationToken);
    }

    public async Task<LeaveApplications> PayrollAuRejectLeaveApplicationAsync(string accessToken, string xeroTenantId, Guid leaveApplicationID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await PayrollAuRejectLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LeaveApplications>> PayrollAuRejectLeaveApplicationAsyncWithHttpInfo(Guid leaveApplicationID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuRejectLeaveApplicationAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, leaveApplicationID, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<LeaveApplications>> PayrollAuRejectLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveApplicationID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await payrollAuXeroClient.RejectLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, idempotencyKey, cancellationToken);
        return response;
    }

    // Explicit interface implementations
    Task<Employees> IPayrollAuApiAsync.UpdateEmployeeAsync(string accessToken, string xeroTenantId, Guid employeeID, List<Employee> employee, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuUpdateEmployeeAsync(accessToken, xeroTenantId, employeeID, employee, idempotencyKey, cancellationToken);
    }

    Task<ApiResponse<Employees>> IPayrollAuApiAsync.UpdateEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, List<Employee> employee, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuUpdateEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employee, idempotencyKey, cancellationToken);
    }

    // Public methods
    public async Task<Employees> PayrollAuUpdateEmployeeAsync(Guid employeeID, List<Employee> employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuUpdateEmployeeAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employee, idempotencyKey, cancellationToken);
    }

    public async Task<Employees> PayrollAuUpdateEmployeeAsync(string accessToken, string xeroTenantId, Guid employeeID, List<Employee> employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await PayrollAuUpdateEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employee, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Employees>> PayrollAuUpdateEmployeeAsyncWithHttpInfo(Guid employeeID, List<Employee> employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuUpdateEmployeeAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employee, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<Employees>> PayrollAuUpdateEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, List<Employee> employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await payrollAuXeroClient.UpdateEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employee, idempotencyKey, cancellationToken);
        return response;
    }

    // Explicit interface implementations
    Task<LeaveApplications> IPayrollAuApiAsync.UpdateLeaveApplicationAsync(string accessToken, string xeroTenantId, Guid leaveApplicationID, List<LeaveApplication> leaveApplication, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuUpdateLeaveApplicationAsync(accessToken, xeroTenantId, leaveApplicationID, leaveApplication, idempotencyKey, cancellationToken);
    }

    Task<ApiResponse<LeaveApplications>> IPayrollAuApiAsync.UpdateLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveApplicationID, List<LeaveApplication> leaveApplication, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuUpdateLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, leaveApplication, idempotencyKey, cancellationToken);
    }

    // Public methods
    public async Task<LeaveApplications> PayrollAuUpdateLeaveApplicationAsync(Guid leaveApplicationID, List<LeaveApplication> leaveApplication, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuUpdateLeaveApplicationAsync(accessToken, xeroExtendedConfiguration.TenantId, leaveApplicationID, leaveApplication, idempotencyKey, cancellationToken);
    }

    public async Task<LeaveApplications> PayrollAuUpdateLeaveApplicationAsync(string accessToken, string xeroTenantId, Guid leaveApplicationID, List<LeaveApplication> leaveApplication, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await PayrollAuUpdateLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, leaveApplication, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LeaveApplications>> PayrollAuUpdateLeaveApplicationAsyncWithHttpInfo(Guid leaveApplicationID, List<LeaveApplication> leaveApplication, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuUpdateLeaveApplicationAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, leaveApplicationID, leaveApplication, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<LeaveApplications>> PayrollAuUpdateLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveApplicationID, List<LeaveApplication> leaveApplication, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveApplications> response = await payrollAuXeroClient.UpdateLeaveApplicationAsyncWithHttpInfo(accessToken, xeroTenantId, leaveApplicationID, leaveApplication, idempotencyKey, cancellationToken);
        return response;
    }

    // Explicit interface implementations
    Task<PayRuns> IPayrollAuApiAsync.UpdatePayRunAsync(string accessToken, string xeroTenantId, Guid payRunID, List<PayRun> payRun, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuUpdatePayRunAsync(accessToken, xeroTenantId, payRunID, payRun, idempotencyKey, cancellationToken);
    }

    Task<ApiResponse<PayRuns>> IPayrollAuApiAsync.UpdatePayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payRunID, List<PayRun> payRun, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuUpdatePayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRunID, payRun, idempotencyKey, cancellationToken);
    }

    // Public methods
    public async Task<PayRuns> PayrollAuUpdatePayRunAsync(Guid payRunID, List<PayRun> payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuUpdatePayRunAsync(accessToken, xeroExtendedConfiguration.TenantId, payRunID, payRun, idempotencyKey, cancellationToken);
    }

    public async Task<PayRuns> PayrollAuUpdatePayRunAsync(string accessToken, string xeroTenantId, Guid payRunID, List<PayRun> payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayRuns> response = await PayrollAuUpdatePayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRunID, payRun, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayRuns>> PayrollAuUpdatePayRunAsyncWithHttpInfo(Guid payRunID, List<PayRun> payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuUpdatePayRunAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, payRunID, payRun, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<PayRuns>> PayrollAuUpdatePayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payRunID, List<PayRun> payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayRuns> response = await payrollAuXeroClient.UpdatePayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRunID, payRun, idempotencyKey, cancellationToken);
        return response;
    }

    // Explicit interface implementations
    Task<Payslips> IPayrollAuApiAsync.UpdatePayslipAsync(string accessToken, string xeroTenantId, Guid payslipID, List<PayslipLines> payslipLines, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuUpdatePayslipAsync(accessToken, xeroTenantId, payslipID, payslipLines, idempotencyKey, cancellationToken);
    }

    Task<ApiResponse<Payslips>> IPayrollAuApiAsync.UpdatePayslipAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payslipID, List<PayslipLines> payslipLines, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuUpdatePayslipAsyncWithHttpInfo(accessToken, xeroTenantId, payslipID, payslipLines, idempotencyKey, cancellationToken);
    }

    // Public methods
    public async Task<Payslips> PayrollAuUpdatePayslipAsync(Guid payslipID, List<PayslipLines> payslipLines, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuUpdatePayslipAsync(accessToken, xeroExtendedConfiguration.TenantId, payslipID, payslipLines, idempotencyKey, cancellationToken);
    }

    public async Task<Payslips> PayrollAuUpdatePayslipAsync(string accessToken, string xeroTenantId, Guid payslipID, List<PayslipLines> payslipLines, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Payslips> response = await PayrollAuUpdatePayslipAsyncWithHttpInfo(accessToken, xeroTenantId, payslipID, payslipLines, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Payslips>> PayrollAuUpdatePayslipAsyncWithHttpInfo(Guid payslipID, List<PayslipLines> payslipLines, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuUpdatePayslipAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, payslipID, payslipLines, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<Payslips>> PayrollAuUpdatePayslipAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payslipID, List<PayslipLines> payslipLines, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Payslips> response = await payrollAuXeroClient.UpdatePayslipAsyncWithHttpInfo(accessToken, xeroTenantId, payslipID, payslipLines, idempotencyKey, cancellationToken);
        return response;
    }

    // Explicit interface implementations
    Task<SuperFunds> IPayrollAuApiAsync.UpdateSuperfundAsync(string accessToken, string xeroTenantId, Guid superFundID, List<SuperFund> superFund, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuUpdateSuperfundAsync(accessToken, xeroTenantId, superFundID, superFund, idempotencyKey, cancellationToken);
    }

    Task<ApiResponse<SuperFunds>> IPayrollAuApiAsync.UpdateSuperfundAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid superFundID, List<SuperFund> superFund, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuUpdateSuperfundAsyncWithHttpInfo(accessToken, xeroTenantId, superFundID, superFund, idempotencyKey, cancellationToken);
    }

    // Public methods
    public async Task<SuperFunds> PayrollAuUpdateSuperfundAsync(Guid superFundID, List<SuperFund> superFund, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuUpdateSuperfundAsync(accessToken, xeroExtendedConfiguration.TenantId, superFundID, superFund, idempotencyKey, cancellationToken);
    }

    public async Task<SuperFunds> PayrollAuUpdateSuperfundAsync(string accessToken, string xeroTenantId, Guid superFundID, List<SuperFund> superFund, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFunds> response = await PayrollAuUpdateSuperfundAsyncWithHttpInfo(accessToken, xeroTenantId, superFundID, superFund, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SuperFunds>> PayrollAuUpdateSuperfundAsyncWithHttpInfo(Guid superFundID, List<SuperFund> superFund, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuUpdateSuperfundAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, superFundID, superFund, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<SuperFunds>> PayrollAuUpdateSuperfundAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid superFundID, List<SuperFund> superFund, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<SuperFunds> response = await payrollAuXeroClient.UpdateSuperfundAsyncWithHttpInfo(accessToken, xeroTenantId, superFundID, superFund, idempotencyKey, cancellationToken);
        return response;
    }


    // Explicit interface implementations
    Task<Timesheets> IPayrollAuApiAsync.UpdateTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, List<Timesheet> timesheet, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuUpdateTimesheetAsync(accessToken, xeroTenantId, timesheetID, timesheet, idempotencyKey, cancellationToken);
    }

    Task<ApiResponse<Timesheets>> IPayrollAuApiAsync.UpdateTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, List<Timesheet> timesheet, string? idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollAuUpdateTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, timesheet, idempotencyKey, cancellationToken);
    }

    // Public methods
    public async Task<Timesheets> PayrollAuUpdateTimesheetAsync(Guid timesheetID, List<Timesheet> timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuUpdateTimesheetAsync(accessToken, xeroExtendedConfiguration.TenantId, timesheetID, timesheet, idempotencyKey, cancellationToken);
    }

    public async Task<Timesheets> PayrollAuUpdateTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, List<Timesheet> timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Timesheets> response = await PayrollAuUpdateTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, timesheet, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Timesheets>> PayrollAuUpdateTimesheetAsyncWithHttpInfo(Guid timesheetID, List<Timesheet> timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollAuUpdateTimesheetAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, timesheetID, timesheet, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<Timesheets>> PayrollAuUpdateTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, List<Timesheet> timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Timesheets> response = await payrollAuXeroClient.UpdateTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, timesheet, idempotencyKey, cancellationToken);
        return response;
    }
}

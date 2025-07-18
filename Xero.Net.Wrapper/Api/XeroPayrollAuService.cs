using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.PayrollAu;

public partial class XeroService : IPayrollAuApi
{
    public Task<LeaveApplications> ApproveLeaveApplicationAsync(string accessToken, string xeroTenantId, Guid leaveApplicationID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<LeaveApplications>> ApproveLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveApplicationID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Employees> CreateEmployeeAsync(string accessToken, string xeroTenantId, List<Employee> employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Employees>> CreateEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<Employee> employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<LeaveApplications> CreateLeaveApplicationAsync(string accessToken, string xeroTenantId, List<LeaveApplication> leaveApplication, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<LeaveApplications>> CreateLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<LeaveApplication> leaveApplication, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PayItems> CreatePayItemAsync(string accessToken, string xeroTenantId, PayItem payItem, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PayItems>> CreatePayItemAsyncWithHttpInfo(string accessToken, string xeroTenantId, PayItem payItem, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PayrollCalendars> CreatePayrollCalendarAsync(string accessToken, string xeroTenantId, List<PayrollCalendar> payrollCalendar, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PayrollCalendars>> CreatePayrollCalendarAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<PayrollCalendar> payrollCalendar, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PayRuns> CreatePayRunAsync(string accessToken, string xeroTenantId, List<PayRun> payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PayRuns>> CreatePayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<PayRun> payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<SuperFunds> CreateSuperfundAsync(string accessToken, string xeroTenantId, List<SuperFund> superFund, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<SuperFunds>> CreateSuperfundAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<SuperFund> superFund, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Timesheets> CreateTimesheetAsync(string accessToken, string xeroTenantId, List<Timesheet> timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Timesheets>> CreateTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<Timesheet> timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Employees> GetEmployeeAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Employees>> GetEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Employees> GetEmployeesAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Employees>> GetEmployeesAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<LeaveApplications> GetLeaveApplicationAsync(string accessToken, string xeroTenantId, Guid leaveApplicationID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<LeaveApplications>> GetLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveApplicationID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<LeaveApplications> GetLeaveApplicationsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<LeaveApplications>> GetLeaveApplicationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<LeaveApplications> GetLeaveApplicationsV2Async(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<LeaveApplications>> GetLeaveApplicationsV2AsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PayItems> GetPayItemsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PayItems>> GetPayItemsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PayrollCalendars> GetPayrollCalendarAsync(string accessToken, string xeroTenantId, Guid payrollCalendarID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PayrollCalendars>> GetPayrollCalendarAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payrollCalendarID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PayrollCalendars> GetPayrollCalendarsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PayrollCalendars>> GetPayrollCalendarsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PayRuns> GetPayRunAsync(string accessToken, string xeroTenantId, Guid payRunID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PayRuns>> GetPayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payRunID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PayRuns> GetPayRunsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PayRuns>> GetPayRunsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PayslipObject> GetPayslipAsync(string accessToken, string xeroTenantId, Guid payslipID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PayslipObject>> GetPayslipAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payslipID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<SettingsObject> GetSettingsAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<SettingsObject>> GetSettingsAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<SuperFunds> GetSuperfundAsync(string accessToken, string xeroTenantId, Guid superFundID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<SuperFunds>> GetSuperfundAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid superFundID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<SuperFundProducts> GetSuperfundProductsAsync(string accessToken, string xeroTenantId, string? ABN = null, string? USI = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<SuperFundProducts>> GetSuperfundProductsAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? ABN = null, string? USI = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<SuperFunds> GetSuperfundsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<SuperFunds>> GetSuperfundsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TimesheetObject> GetTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TimesheetObject>> GetTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Timesheets> GetTimesheetsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Timesheets>> GetTimesheetsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<LeaveApplications> RejectLeaveApplicationAsync(string accessToken, string xeroTenantId, Guid leaveApplicationID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<LeaveApplications>> RejectLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveApplicationID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Employees> UpdateEmployeeAsync(string accessToken, string xeroTenantId, Guid employeeID, List<Employee> employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Employees>> UpdateEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, List<Employee> employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<LeaveApplications> UpdateLeaveApplicationAsync(string accessToken, string xeroTenantId, Guid leaveApplicationID, List<LeaveApplication> leaveApplication, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<LeaveApplications>> UpdateLeaveApplicationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveApplicationID, List<LeaveApplication> leaveApplication, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PayRuns> UpdatePayRunAsync(string accessToken, string xeroTenantId, Guid payRunID, List<PayRun> payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PayRuns>> UpdatePayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payRunID, List<PayRun> payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Payslips> UpdatePayslipAsync(string accessToken, string xeroTenantId, Guid payslipID, List<PayslipLines> payslipLines, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Payslips>> UpdatePayslipAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payslipID, List<PayslipLines> payslipLines, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<SuperFunds> UpdateSuperfundAsync(string accessToken, string xeroTenantId, Guid superFundID, List<SuperFund> superFund, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<SuperFunds>> UpdateSuperfundAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid superFundID, List<SuperFund> superFund, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Timesheets> UpdateTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, List<Timesheet> timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Timesheets>> UpdateTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, List<Timesheet> timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}

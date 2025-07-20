using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.PayrollNz;

namespace Xero.Net.Wrapper.Api;

public partial class XeroService : IPayrollNzApi
{
    public async Task<TimesheetObject> ApproveTimesheetAsync(Guid timesheetID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await ApproveTimesheetAsync(accessToken, xeroExtendedConfiguration.TenantId, timesheetID, idempotencyKey, cancellationToken);
    }


    public async Task<TimesheetObject> ApproveTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<TimesheetObject> response = await ApproveTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TimesheetObject>> ApproveTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<TimesheetObject> response = await payrollNzXeroClient.ApproveTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<DeductionObject> CreateDeductionAsync(Deduction deduction, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateDeductionAsync(accessToken, xeroExtendedConfiguration.TenantId, deduction, idempotencyKey, cancellationToken);
    }



    public async Task<DeductionObject> CreateDeductionAsync(string accessToken, string xeroTenantId, Deduction deduction, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<DeductionObject> response = await CreateDeductionAsyncWithHttpInfo(accessToken, xeroTenantId, deduction, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<DeductionObject>> CreateDeductionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Deduction deduction, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<DeductionObject> response = await payrollNzXeroClient.CreateDeductionAsyncWithHttpInfo(accessToken, xeroTenantId, deduction, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EarningsRateObject> CreateEarningsRateAsync(EarningsRate earningsRate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEarningsRateAsync(accessToken, xeroExtendedConfiguration.TenantId, earningsRate, idempotencyKey, cancellationToken);
    }



    public async Task<EarningsRateObject> CreateEarningsRateAsync(string accessToken, string xeroTenantId, EarningsRate earningsRate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EarningsRateObject> response = await CreateEarningsRateAsyncWithHttpInfo(accessToken, xeroTenantId, earningsRate, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EarningsRateObject>> CreateEarningsRateAsyncWithHttpInfo(string accessToken, string xeroTenantId, EarningsRate earningsRate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EarningsRateObject> response = await payrollNzXeroClient.CreateEarningsRateAsyncWithHttpInfo(accessToken, xeroTenantId, earningsRate, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EmployeeObject> CreateEmployeeAsync(Employee employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeeAsync(accessToken, xeroExtendedConfiguration.TenantId, employee, idempotencyKey, cancellationToken);
    }



    public async Task<EmployeeObject> CreateEmployeeAsync(string accessToken, string xeroTenantId, Employee employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeObject> response = await CreateEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employee, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeObject>> CreateEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Employee employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeObject> response = await payrollNzXeroClient.CreateEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employee, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EarningsTemplateObject> CreateEmployeeEarningsTemplateAsync(Guid employeeID, EarningsTemplate earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeeEarningsTemplateAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, earningsTemplate, idempotencyKey, cancellationToken);
    }



    public async Task<EarningsTemplateObject> CreateEmployeeEarningsTemplateAsync(string accessToken, string xeroTenantId, Guid employeeID, EarningsTemplate earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EarningsTemplateObject> response = await CreateEmployeeEarningsTemplateAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, earningsTemplate, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EarningsTemplateObject>> CreateEmployeeEarningsTemplateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EarningsTemplate earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EarningsTemplateObject> response = await payrollNzXeroClient.CreateEmployeeEarningsTemplateAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, earningsTemplate, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EmployeeLeaveObject> CreateEmployeeLeaveAsync(Guid employeeID, EmployeeLeave employeeLeave, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeeLeaveAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employeeLeave, idempotencyKey, cancellationToken);
    }



    public async Task<EmployeeLeaveObject> CreateEmployeeLeaveAsync(string accessToken, string xeroTenantId, Guid employeeID, EmployeeLeave employeeLeave, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeLeaveObject> response = await CreateEmployeeLeaveAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeLeave, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeLeaveObject>> CreateEmployeeLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EmployeeLeave employeeLeave, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeLeaveObject> response = await payrollNzXeroClient.CreateEmployeeLeaveAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeLeave, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EmployeeLeaveSetupObject> CreateEmployeeLeaveSetupAsync(Guid employeeID, EmployeeLeaveSetup employeeLeaveSetup, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeeLeaveSetupAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employeeLeaveSetup, idempotencyKey, cancellationToken);
    }



    public async Task<EmployeeLeaveSetupObject> CreateEmployeeLeaveSetupAsync(string accessToken, string xeroTenantId, Guid employeeID, EmployeeLeaveSetup employeeLeaveSetup, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeLeaveSetupObject> response = await CreateEmployeeLeaveSetupAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeLeaveSetup, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeLeaveSetupObject>> CreateEmployeeLeaveSetupAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EmployeeLeaveSetup employeeLeaveSetup, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeLeaveSetupObject> response = await payrollNzXeroClient.CreateEmployeeLeaveSetupAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeLeaveSetup, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EmployeeLeaveTypeObject> CreateEmployeeLeaveTypeAsync(Guid employeeID, EmployeeLeaveType employeeLeaveType, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeeLeaveTypeAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employeeLeaveType, idempotencyKey, cancellationToken);
    }



    public async Task<EmployeeLeaveTypeObject> CreateEmployeeLeaveTypeAsync(string accessToken, string xeroTenantId, Guid employeeID, EmployeeLeaveType employeeLeaveType, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeLeaveTypeObject> response = await CreateEmployeeLeaveTypeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeLeaveType, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeLeaveTypeObject>> CreateEmployeeLeaveTypeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EmployeeLeaveType employeeLeaveType, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeLeaveTypeObject> response = await payrollNzXeroClient.CreateEmployeeLeaveTypeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeLeaveType, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EmployeeOpeningBalancesObject> CreateEmployeeOpeningBalancesAsync(Guid employeeID, List<EmployeeOpeningBalance> employeeOpeningBalance, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeeOpeningBalancesAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employeeOpeningBalance, idempotencyKey, cancellationToken);
    }



    public async Task<EmployeeOpeningBalancesObject> CreateEmployeeOpeningBalancesAsync(string accessToken, string xeroTenantId, Guid employeeID, List<EmployeeOpeningBalance> employeeOpeningBalance, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeOpeningBalancesObject> response = await CreateEmployeeOpeningBalancesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeOpeningBalance, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeOpeningBalancesObject>> CreateEmployeeOpeningBalancesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, List<EmployeeOpeningBalance> employeeOpeningBalance, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeOpeningBalancesObject> response = await payrollNzXeroClient.CreateEmployeeOpeningBalancesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeOpeningBalance, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<PaymentMethodObject> CreateEmployeePaymentMethodAsync(Guid employeeID, PaymentMethod paymentMethod, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeePaymentMethodAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, paymentMethod, idempotencyKey, cancellationToken);
    }



    public async Task<PaymentMethodObject> CreateEmployeePaymentMethodAsync(string accessToken, string xeroTenantId, Guid employeeID, PaymentMethod paymentMethod, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<PaymentMethodObject> response = await CreateEmployeePaymentMethodAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, paymentMethod, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PaymentMethodObject>> CreateEmployeePaymentMethodAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, PaymentMethod paymentMethod, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<PaymentMethodObject> response = await payrollNzXeroClient.CreateEmployeePaymentMethodAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, paymentMethod, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<SalaryAndWageObject> CreateEmployeeSalaryAndWageAsync(Guid employeeID, SalaryAndWage salaryAndWage, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeeSalaryAndWageAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, salaryAndWage, idempotencyKey, cancellationToken);
    }



    public async Task<SalaryAndWageObject> CreateEmployeeSalaryAndWageAsync(string accessToken, string xeroTenantId, Guid employeeID, SalaryAndWage salaryAndWage, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<SalaryAndWageObject> response = await CreateEmployeeSalaryAndWageAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, salaryAndWage, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SalaryAndWageObject>> CreateEmployeeSalaryAndWageAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, SalaryAndWage salaryAndWage, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<SalaryAndWageObject> response = await payrollNzXeroClient.CreateEmployeeSalaryAndWageAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, salaryAndWage, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EmployeeWorkingPatternWithWorkingWeeksObject> CreateEmployeeWorkingPatternAsync(Guid employeeID, EmployeeWorkingPatternWithWorkingWeeksRequest employeeWorkingPatternWithWorkingWeeksRequest, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeeWorkingPatternAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employeeWorkingPatternWithWorkingWeeksRequest, idempotencyKey, cancellationToken);
    }



    public async Task<EmployeeWorkingPatternWithWorkingWeeksObject> CreateEmployeeWorkingPatternAsync(string accessToken, string xeroTenantId, Guid employeeID, EmployeeWorkingPatternWithWorkingWeeksRequest employeeWorkingPatternWithWorkingWeeksRequest, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeWorkingPatternWithWorkingWeeksObject> response = await CreateEmployeeWorkingPatternAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeWorkingPatternWithWorkingWeeksRequest, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeWorkingPatternWithWorkingWeeksObject>> CreateEmployeeWorkingPatternAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EmployeeWorkingPatternWithWorkingWeeksRequest employeeWorkingPatternWithWorkingWeeksRequest, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeWorkingPatternWithWorkingWeeksObject> response = await payrollNzXeroClient.CreateEmployeeWorkingPatternAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeWorkingPatternWithWorkingWeeksRequest, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EmploymentObject> CreateEmploymentAsync(Guid employeeID, Employment employment, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmploymentAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employment, idempotencyKey, cancellationToken);
    }



    public async Task<EmploymentObject> CreateEmploymentAsync(string accessToken, string xeroTenantId, Guid employeeID, Employment employment, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmploymentObject> response = await CreateEmploymentAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employment, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmploymentObject>> CreateEmploymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Employment employment, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmploymentObject> response = await payrollNzXeroClient.CreateEmploymentAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employment, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<LeaveTypeObject> CreateLeaveTypeAsync(LeaveType leaveType, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateLeaveTypeAsync(accessToken, xeroExtendedConfiguration.TenantId, leaveType, idempotencyKey, cancellationToken);
    }



    public async Task<LeaveTypeObject> CreateLeaveTypeAsync(string accessToken, string xeroTenantId, LeaveType leaveType, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<LeaveTypeObject> response = await CreateLeaveTypeAsyncWithHttpInfo(accessToken, xeroTenantId, leaveType, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LeaveTypeObject>> CreateLeaveTypeAsyncWithHttpInfo(string accessToken, string xeroTenantId, LeaveType leaveType, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<LeaveTypeObject> response = await payrollNzXeroClient.CreateLeaveTypeAsyncWithHttpInfo(accessToken, xeroTenantId, leaveType, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EmployeeEarningsTemplates> CreateMultipleEmployeeEarningsTemplateAsync(Guid employeeID, List<EarningsTemplate> earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateMultipleEmployeeEarningsTemplateAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, earningsTemplate, idempotencyKey, cancellationToken);
    }



    public async Task<EmployeeEarningsTemplates> CreateMultipleEmployeeEarningsTemplateAsync(string accessToken, string xeroTenantId, Guid employeeID, List<EarningsTemplate> earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeEarningsTemplates> response = await CreateMultipleEmployeeEarningsTemplateAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, earningsTemplate, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeEarningsTemplates>> CreateMultipleEmployeeEarningsTemplateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, List<EarningsTemplate> earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeEarningsTemplates> response = await payrollNzXeroClient.CreateMultipleEmployeeEarningsTemplateAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, earningsTemplate, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<PayRunObject> CreatePayRunAsync(PayRun payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreatePayRunAsync(accessToken, xeroExtendedConfiguration.TenantId, payRun, idempotencyKey, cancellationToken);
    }



    public async Task<PayRunObject> CreatePayRunAsync(string accessToken, string xeroTenantId, PayRun payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<PayRunObject> response = await CreatePayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRun, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayRunObject>> CreatePayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, PayRun payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<PayRunObject> response = await payrollNzXeroClient.CreatePayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRun, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<PayRunCalendarObject> CreatePayRunCalendarAsync(PayRunCalendar payRunCalendar, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreatePayRunCalendarAsync(accessToken, xeroExtendedConfiguration.TenantId, payRunCalendar, idempotencyKey, cancellationToken);
    }



    public async Task<PayRunCalendarObject> CreatePayRunCalendarAsync(string accessToken, string xeroTenantId, PayRunCalendar payRunCalendar, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<PayRunCalendarObject> response = await CreatePayRunCalendarAsyncWithHttpInfo(accessToken, xeroTenantId, payRunCalendar, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayRunCalendarObject>> CreatePayRunCalendarAsyncWithHttpInfo(string accessToken, string xeroTenantId, PayRunCalendar payRunCalendar, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<PayRunCalendarObject> response = await payrollNzXeroClient.CreatePayRunCalendarAsyncWithHttpInfo(accessToken, xeroTenantId, payRunCalendar, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<ReimbursementObject> CreateReimbursementAsync(Reimbursement reimbursement, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateReimbursementAsync(accessToken, xeroExtendedConfiguration.TenantId, reimbursement, idempotencyKey, cancellationToken);
    }



    public async Task<ReimbursementObject> CreateReimbursementAsync(string accessToken, string xeroTenantId, Reimbursement reimbursement, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<ReimbursementObject> response = await CreateReimbursementAsyncWithHttpInfo(accessToken, xeroTenantId, reimbursement, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ReimbursementObject>> CreateReimbursementAsyncWithHttpInfo(string accessToken, string xeroTenantId, Reimbursement reimbursement, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<ReimbursementObject> response = await payrollNzXeroClient.CreateReimbursementAsyncWithHttpInfo(accessToken, xeroTenantId, reimbursement, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<SuperannuationObject> CreateSuperannuationAsync(Benefit benefit, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateSuperannuationAsync(accessToken, xeroExtendedConfiguration.TenantId, benefit, idempotencyKey, cancellationToken);
    }



    public async Task<SuperannuationObject> CreateSuperannuationAsync(string accessToken, string xeroTenantId, Benefit benefit, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<SuperannuationObject> response = await CreateSuperannuationAsyncWithHttpInfo(accessToken, xeroTenantId, benefit, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SuperannuationObject>> CreateSuperannuationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Benefit benefit, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<SuperannuationObject> response = await payrollNzXeroClient.CreateSuperannuationAsyncWithHttpInfo(accessToken, xeroTenantId, benefit, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<TimesheetObject> CreateTimesheetAsync(Timesheet timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateTimesheetAsync(accessToken, xeroExtendedConfiguration.TenantId, timesheet, idempotencyKey, cancellationToken);
    }



    public async Task<TimesheetObject> CreateTimesheetAsync(string accessToken, string xeroTenantId, Timesheet timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<TimesheetObject> response = await CreateTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheet, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TimesheetObject>> CreateTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Timesheet timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<TimesheetObject> response = await payrollNzXeroClient.CreateTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheet, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<TimesheetLineObject> CreateTimesheetLineAsync(Guid timesheetID, TimesheetLine timesheetLine, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateTimesheetLineAsync(accessToken, xeroExtendedConfiguration.TenantId, timesheetID, timesheetLine, idempotencyKey, cancellationToken);
    }



    public async Task<TimesheetLineObject> CreateTimesheetLineAsync(string accessToken, string xeroTenantId, Guid timesheetID, TimesheetLine timesheetLine, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<TimesheetLineObject> response = await CreateTimesheetLineAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, timesheetLine, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TimesheetLineObject>> CreateTimesheetLineAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, TimesheetLine timesheetLine, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<TimesheetLineObject> response = await payrollNzXeroClient.CreateTimesheetLineAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, timesheetLine, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EarningsTemplateObject> DeleteEmployeeEarningsTemplateAsync(Guid employeeID, Guid payTemplateEarningID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteEmployeeEarningsTemplateAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, payTemplateEarningID, cancellationToken);
    }



    public async Task<EarningsTemplateObject> DeleteEmployeeEarningsTemplateAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid payTemplateEarningID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EarningsTemplateObject> response = await DeleteEmployeeEarningsTemplateAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, payTemplateEarningID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EarningsTemplateObject>> DeleteEmployeeEarningsTemplateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid payTemplateEarningID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EarningsTemplateObject> response = await payrollNzXeroClient.DeleteEmployeeEarningsTemplateAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, payTemplateEarningID, cancellationToken);
        return response;
    }
    public async Task<EmployeeLeaveObject> DeleteEmployeeLeaveAsync(Guid employeeID, Guid leaveID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteEmployeeLeaveAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, leaveID, cancellationToken);
    }



    public async Task<EmployeeLeaveObject> DeleteEmployeeLeaveAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeLeaveObject> response = await DeleteEmployeeLeaveAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, leaveID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeLeaveObject>> DeleteEmployeeLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeLeaveObject> response = await payrollNzXeroClient.DeleteEmployeeLeaveAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, leaveID, cancellationToken);
        return response;
    }
    public async Task<SalaryAndWageObject> DeleteEmployeeSalaryAndWageAsync(Guid employeeID, Guid salaryAndWagesID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteEmployeeSalaryAndWageAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, salaryAndWagesID, cancellationToken);
    }



    public async Task<SalaryAndWageObject> DeleteEmployeeSalaryAndWageAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, CancellationToken cancellationToken = default)
        {
        ApiResponse<SalaryAndWageObject> response = await DeleteEmployeeSalaryAndWageAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, salaryAndWagesID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SalaryAndWageObject>> DeleteEmployeeSalaryAndWageAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, CancellationToken cancellationToken = default)
        {
        ApiResponse<SalaryAndWageObject> response = await payrollNzXeroClient.DeleteEmployeeSalaryAndWageAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, salaryAndWagesID, cancellationToken);
        return response;
    }
    public async Task<EmployeeLeaveObject> DeleteEmployeeWorkingPatternAsync(Guid employeeID, Guid employeeWorkingPatternID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteEmployeeWorkingPatternAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employeeWorkingPatternID, cancellationToken);
    }



    public async Task<EmployeeLeaveObject> DeleteEmployeeWorkingPatternAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid employeeWorkingPatternID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeLeaveObject> response = await DeleteEmployeeWorkingPatternAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeWorkingPatternID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeLeaveObject>> DeleteEmployeeWorkingPatternAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid employeeWorkingPatternID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeLeaveObject> response = await payrollNzXeroClient.DeleteEmployeeWorkingPatternAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeWorkingPatternID, cancellationToken);
        return response;
    }
    public async Task<TimesheetLine> DeleteTimesheetAsync(Guid timesheetID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteTimesheetAsync(accessToken, xeroExtendedConfiguration.TenantId, timesheetID, cancellationToken);
    }



    public async Task<TimesheetLine> DeleteTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, CancellationToken cancellationToken = default)
        {
        ApiResponse<TimesheetLine> response = await DeleteTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TimesheetLine>> DeleteTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, CancellationToken cancellationToken = default)
        {
        ApiResponse<TimesheetLine> response = await payrollNzXeroClient.DeleteTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, cancellationToken);
        return response;
    }
    public async Task<TimesheetLine> DeleteTimesheetLineAsync(Guid timesheetID, Guid timesheetLineID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteTimesheetLineAsync(accessToken, xeroExtendedConfiguration.TenantId, timesheetID, timesheetLineID, cancellationToken);
    }



    public async Task<TimesheetLine> DeleteTimesheetLineAsync(string accessToken, string xeroTenantId, Guid timesheetID, Guid timesheetLineID, CancellationToken cancellationToken = default)
        {
        ApiResponse<TimesheetLine> response = await DeleteTimesheetLineAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, timesheetLineID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TimesheetLine>> DeleteTimesheetLineAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, Guid timesheetLineID, CancellationToken cancellationToken = default)
        {
        ApiResponse<TimesheetLine> response = await payrollNzXeroClient.DeleteTimesheetLineAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, timesheetLineID, cancellationToken);
        return response;
    }
    public async Task<DeductionObject> GetDeductionAsync(Guid deductionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetDeductionAsync(accessToken, xeroExtendedConfiguration.TenantId, deductionId, cancellationToken);
    }



    public async Task<DeductionObject> GetDeductionAsync(string accessToken, string xeroTenantId, Guid deductionId, CancellationToken cancellationToken = default)
        {
        ApiResponse<DeductionObject> response = await GetDeductionAsyncWithHttpInfo(accessToken, xeroTenantId, deductionId, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<DeductionObject>> GetDeductionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid deductionId, CancellationToken cancellationToken = default)
        {
        ApiResponse<DeductionObject> response = await payrollNzXeroClient.GetDeductionAsyncWithHttpInfo(accessToken, xeroTenantId, deductionId, cancellationToken);
        return response;
    }
    public async Task<Deductions> GetDeductionsAsync(int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetDeductionsAsync(accessToken, xeroExtendedConfiguration.TenantId, page, cancellationToken);
    }



    public async Task<Deductions> GetDeductionsAsync(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<Deductions> response = await GetDeductionsAsyncWithHttpInfo(accessToken, xeroTenantId, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Deductions>> GetDeductionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<Deductions> response = await payrollNzXeroClient.GetDeductionsAsyncWithHttpInfo(accessToken, xeroTenantId, page, cancellationToken);
        return response;
    }
    public async Task<EarningsRateObject> GetEarningsRateAsync(Guid earningsRateID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEarningsRateAsync(accessToken, xeroExtendedConfiguration.TenantId, earningsRateID, cancellationToken);
    }



    public async Task<EarningsRateObject> GetEarningsRateAsync(string accessToken, string xeroTenantId, Guid earningsRateID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EarningsRateObject> response = await GetEarningsRateAsyncWithHttpInfo(accessToken, xeroTenantId, earningsRateID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EarningsRateObject>> GetEarningsRateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid earningsRateID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EarningsRateObject> response = await payrollNzXeroClient.GetEarningsRateAsyncWithHttpInfo(accessToken, xeroTenantId, earningsRateID, cancellationToken);
        return response;
    }
    public async Task<EarningsRates> GetEarningsRatesAsync(int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEarningsRatesAsync(accessToken, xeroExtendedConfiguration.TenantId, page, cancellationToken);
    }



    public async Task<EarningsRates> GetEarningsRatesAsync(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EarningsRates> response = await GetEarningsRatesAsyncWithHttpInfo(accessToken, xeroTenantId, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EarningsRates>> GetEarningsRatesAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EarningsRates> response = await payrollNzXeroClient.GetEarningsRatesAsyncWithHttpInfo(accessToken, xeroTenantId, page, cancellationToken);
        return response;
    }
    public async Task<EmployeeLeaveBalances> GetEmployeeLeaveBalancesAsync(Guid employeeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeeLeaveBalancesAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, cancellationToken);
    }



    public async Task<EmployeeLeaveBalances> GetEmployeeLeaveBalancesAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeLeaveBalances> response = await GetEmployeeLeaveBalancesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeLeaveBalances>> GetEmployeeLeaveBalancesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeLeaveBalances> response = await payrollNzXeroClient.GetEmployeeLeaveBalancesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response;
    }
    public async Task<LeavePeriods> GetEmployeeLeavePeriodsAsync(Guid employeeID, DateTime? startDate = null, DateTime? endDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeeLeavePeriodsAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, startDate, endDate, cancellationToken);
    }



    public async Task<LeavePeriods> GetEmployeeLeavePeriodsAsync(string accessToken, string xeroTenantId, Guid employeeID, DateTime? startDate = null, DateTime? endDate = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<LeavePeriods> response = await GetEmployeeLeavePeriodsAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, startDate, endDate, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LeavePeriods>> GetEmployeeLeavePeriodsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, DateTime? startDate = null, DateTime? endDate = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<LeavePeriods> response = await payrollNzXeroClient.GetEmployeeLeavePeriodsAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, startDate, endDate, cancellationToken);
        return response;
    }
    public async Task<EmployeeLeaves> GetEmployeeLeavesAsync(Guid employeeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeeLeavesAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, cancellationToken);
    }



    public async Task<EmployeeLeaves> GetEmployeeLeavesAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeLeaves> response = await GetEmployeeLeavesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeLeaves>> GetEmployeeLeavesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeLeaves> response = await payrollNzXeroClient.GetEmployeeLeavesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response;
    }
    public async Task<EmployeeLeaveTypes> GetEmployeeLeaveTypesAsync(Guid employeeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeeLeaveTypesAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, cancellationToken);
    }



    public async Task<EmployeeLeaveTypes> GetEmployeeLeaveTypesAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeLeaveTypes> response = await GetEmployeeLeaveTypesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeLeaveTypes>> GetEmployeeLeaveTypesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeLeaveTypes> response = await payrollNzXeroClient.GetEmployeeLeaveTypesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response;
    }
    public async Task<EmployeeOpeningBalancesObject> GetEmployeeOpeningBalancesAsync(Guid employeeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeeOpeningBalancesAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, cancellationToken);
    }



    public async Task<EmployeeOpeningBalancesObject> GetEmployeeOpeningBalancesAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeOpeningBalancesObject> response = await GetEmployeeOpeningBalancesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeOpeningBalancesObject>> GetEmployeeOpeningBalancesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeOpeningBalancesObject> response = await payrollNzXeroClient.GetEmployeeOpeningBalancesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response;
    }
    public async Task<PaymentMethodObject> GetEmployeePaymentMethodAsync(Guid employeeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeePaymentMethodAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, cancellationToken);
    }



    public async Task<PaymentMethodObject> GetEmployeePaymentMethodAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
        {
        ApiResponse<PaymentMethodObject> response = await GetEmployeePaymentMethodAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PaymentMethodObject>> GetEmployeePaymentMethodAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
        {
        ApiResponse<PaymentMethodObject> response = await payrollNzXeroClient.GetEmployeePaymentMethodAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response;
    }
    public async Task<EmployeePayTemplates> GetEmployeePayTemplatesAsync(Guid employeeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeePayTemplatesAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, cancellationToken);
    }



    public async Task<EmployeePayTemplates> GetEmployeePayTemplatesAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeePayTemplates> response = await GetEmployeePayTemplatesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeePayTemplates>> GetEmployeePayTemplatesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeePayTemplates> response = await payrollNzXeroClient.GetEmployeePayTemplatesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response;
    }
    public async Task<SalaryAndWages> GetEmployeeSalaryAndWageAsync(Guid employeeID, Guid salaryAndWagesID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeeSalaryAndWageAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, salaryAndWagesID, cancellationToken);
    }



    public async Task<SalaryAndWages> GetEmployeeSalaryAndWageAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, CancellationToken cancellationToken = default)
        {
        ApiResponse<SalaryAndWages> response = await GetEmployeeSalaryAndWageAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, salaryAndWagesID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SalaryAndWages>> GetEmployeeSalaryAndWageAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, CancellationToken cancellationToken = default)
        {
        ApiResponse<SalaryAndWages> response = await payrollNzXeroClient.GetEmployeeSalaryAndWageAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, salaryAndWagesID, cancellationToken);
        return response;
    }
    public async Task<SalaryAndWages> GetEmployeeSalaryAndWagesAsync(Guid employeeID, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeeSalaryAndWagesAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, page, cancellationToken);
    }



    public async Task<SalaryAndWages> GetEmployeeSalaryAndWagesAsync(string accessToken, string xeroTenantId, Guid employeeID, int? page = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<SalaryAndWages> response = await GetEmployeeSalaryAndWagesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SalaryAndWages>> GetEmployeeSalaryAndWagesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, int? page = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<SalaryAndWages> response = await payrollNzXeroClient.GetEmployeeSalaryAndWagesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, page, cancellationToken);
        return response;
    }
    public async Task<Employees> GetEmployeesAsync(string? filter = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeesAsync(accessToken, xeroExtendedConfiguration.TenantId, filter, page, cancellationToken);
    }



    public async Task<Employees> GetEmployeesAsync(string accessToken, string xeroTenantId, string? filter = null, int? page = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<Employees> response = await GetEmployeesAsyncWithHttpInfo(accessToken, xeroTenantId, filter, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Employees>> GetEmployeesAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? filter = null, int? page = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<Employees> response = await payrollNzXeroClient.GetEmployeesAsyncWithHttpInfo(accessToken, xeroTenantId, filter, page, cancellationToken);
        return response;
    }
    public async Task<EmployeeTaxObject> GetEmployeeTaxAsync(Guid employeeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeeTaxAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, cancellationToken);
    }



    public async Task<EmployeeTaxObject> GetEmployeeTaxAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeTaxObject> response = await GetEmployeeTaxAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeTaxObject>> GetEmployeeTaxAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeTaxObject> response = await payrollNzXeroClient.GetEmployeeTaxAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response;
    }
    public async Task<EmployeeWorkingPatternWithWorkingWeeksObject> GetEmployeeWorkingPatternAsync(Guid employeeID, Guid employeeWorkingPatternID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeeWorkingPatternAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employeeWorkingPatternID, cancellationToken);
    }



    public async Task<EmployeeWorkingPatternWithWorkingWeeksObject> GetEmployeeWorkingPatternAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid employeeWorkingPatternID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeWorkingPatternWithWorkingWeeksObject> response = await GetEmployeeWorkingPatternAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeWorkingPatternID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeWorkingPatternWithWorkingWeeksObject>> GetEmployeeWorkingPatternAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid employeeWorkingPatternID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeWorkingPatternWithWorkingWeeksObject> response = await payrollNzXeroClient.GetEmployeeWorkingPatternAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeWorkingPatternID, cancellationToken);
        return response;
    }
    public async Task<EmployeeWorkingPatternsObject> GetEmployeeWorkingPatternsAsync(Guid employeeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeeWorkingPatternsAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, cancellationToken);
    }



    public async Task<EmployeeWorkingPatternsObject> GetEmployeeWorkingPatternsAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeWorkingPatternsObject> response = await GetEmployeeWorkingPatternsAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeWorkingPatternsObject>> GetEmployeeWorkingPatternsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeWorkingPatternsObject> response = await payrollNzXeroClient.GetEmployeeWorkingPatternsAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response;
    }
    public async Task<LeaveTypeObject> GetLeaveTypeAsync(Guid leaveTypeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetLeaveTypeAsync(accessToken, xeroExtendedConfiguration.TenantId, leaveTypeID, cancellationToken);
    }



    public async Task<LeaveTypeObject> GetLeaveTypeAsync(string accessToken, string xeroTenantId, Guid leaveTypeID, CancellationToken cancellationToken = default)
        {
        ApiResponse<LeaveTypeObject> response = await GetLeaveTypeAsyncWithHttpInfo(accessToken, xeroTenantId, leaveTypeID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LeaveTypeObject>> GetLeaveTypeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveTypeID, CancellationToken cancellationToken = default)
        {
        ApiResponse<LeaveTypeObject> response = await payrollNzXeroClient.GetLeaveTypeAsyncWithHttpInfo(accessToken, xeroTenantId, leaveTypeID, cancellationToken);
        return response;
    }
    public async Task<LeaveTypes> GetLeaveTypesAsync(int? page = null, bool? activeOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetLeaveTypesAsync(accessToken, xeroExtendedConfiguration.TenantId, page, activeOnly, cancellationToken);
    }



    public async Task<LeaveTypes> GetLeaveTypesAsync(string accessToken, string xeroTenantId, int? page = null, bool? activeOnly = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<LeaveTypes> response = await GetLeaveTypesAsyncWithHttpInfo(accessToken, xeroTenantId, page, activeOnly, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LeaveTypes>> GetLeaveTypesAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, bool? activeOnly = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<LeaveTypes> response = await payrollNzXeroClient.GetLeaveTypesAsyncWithHttpInfo(accessToken, xeroTenantId, page, activeOnly, cancellationToken);
        return response;
    }
    public async Task<PayRunCalendarObject> GetPayRunCalendarAsync(Guid payrollCalendarID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPayRunCalendarAsync(accessToken, xeroExtendedConfiguration.TenantId, payrollCalendarID, cancellationToken);
    }



    public async Task<PayRunCalendarObject> GetPayRunCalendarAsync(string accessToken, string xeroTenantId, Guid payrollCalendarID, CancellationToken cancellationToken = default)
        {
        ApiResponse<PayRunCalendarObject> response = await GetPayRunCalendarAsyncWithHttpInfo(accessToken, xeroTenantId, payrollCalendarID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayRunCalendarObject>> GetPayRunCalendarAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payrollCalendarID, CancellationToken cancellationToken = default)
        {
        ApiResponse<PayRunCalendarObject> response = await payrollNzXeroClient.GetPayRunCalendarAsyncWithHttpInfo(accessToken, xeroTenantId, payrollCalendarID, cancellationToken);
        return response;
    }
    public async Task<PayRunCalendars> GetPayRunCalendarsAsync(int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPayRunCalendarsAsync(accessToken, xeroExtendedConfiguration.TenantId, page, cancellationToken);
    }



    public async Task<PayRunCalendars> GetPayRunCalendarsAsync(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<PayRunCalendars> response = await GetPayRunCalendarsAsyncWithHttpInfo(accessToken, xeroTenantId, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayRunCalendars>> GetPayRunCalendarsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<PayRunCalendars> response = await payrollNzXeroClient.GetPayRunCalendarsAsyncWithHttpInfo(accessToken, xeroTenantId, page, cancellationToken);
        return response;
    }
    public async Task<PayRuns> GetPayRunsAsync(int? page = null, string? status = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPayRunsAsync(accessToken, xeroExtendedConfiguration.TenantId, page, status, cancellationToken);
    }



    public async Task<PayRuns> GetPayRunsAsync(string accessToken, string xeroTenantId, int? page = null, string? status = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<PayRuns> response = await GetPayRunsAsyncWithHttpInfo(accessToken, xeroTenantId, page, status, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayRuns>> GetPayRunsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, string? status = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<PayRuns> response = await payrollNzXeroClient.GetPayRunsAsyncWithHttpInfo(accessToken, xeroTenantId, page, status, cancellationToken);
        return response;
    }
    public async Task<PaySlipObject> GetPaySlipAsync(Guid paySlipID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPaySlipAsync(accessToken, xeroExtendedConfiguration.TenantId, paySlipID, cancellationToken);
    }



    public async Task<PaySlipObject> GetPaySlipAsync(string accessToken, string xeroTenantId, Guid paySlipID, CancellationToken cancellationToken = default)
        {
        ApiResponse<PaySlipObject> response = await GetPaySlipAsyncWithHttpInfo(accessToken, xeroTenantId, paySlipID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PaySlipObject>> GetPaySlipAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid paySlipID, CancellationToken cancellationToken = default)
        {
        ApiResponse<PaySlipObject> response = await payrollNzXeroClient.GetPaySlipAsyncWithHttpInfo(accessToken, xeroTenantId, paySlipID, cancellationToken);
        return response;
    }
    public async Task<PaySlips> GetPaySlipsAsync(Guid payRunID, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPaySlipsAsync(accessToken, xeroExtendedConfiguration.TenantId, payRunID, page, cancellationToken);
    }



    public async Task<PaySlips> GetPaySlipsAsync(string accessToken, string xeroTenantId, Guid payRunID, int? page = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<PaySlips> response = await GetPaySlipsAsyncWithHttpInfo(accessToken, xeroTenantId, payRunID, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PaySlips>> GetPaySlipsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payRunID, int? page = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<PaySlips> response = await payrollNzXeroClient.GetPaySlipsAsyncWithHttpInfo(accessToken, xeroTenantId, payRunID, page, cancellationToken);
        return response;
    }
    public async Task<ReimbursementObject> GetReimbursementAsync(Guid reimbursementID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReimbursementAsync(accessToken, xeroExtendedConfiguration.TenantId, reimbursementID, cancellationToken);
    }



    public async Task<ReimbursementObject> GetReimbursementAsync(string accessToken, string xeroTenantId, Guid reimbursementID, CancellationToken cancellationToken = default)
        {
        ApiResponse<ReimbursementObject> response = await GetReimbursementAsyncWithHttpInfo(accessToken, xeroTenantId, reimbursementID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ReimbursementObject>> GetReimbursementAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid reimbursementID, CancellationToken cancellationToken = default)
        {
        ApiResponse<ReimbursementObject> response = await payrollNzXeroClient.GetReimbursementAsyncWithHttpInfo(accessToken, xeroTenantId, reimbursementID, cancellationToken);
        return response;
    }
    public async Task<Reimbursements> GetReimbursementsAsync(int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReimbursementsAsync(accessToken, xeroExtendedConfiguration.TenantId, page, cancellationToken);
    }



    public async Task<Reimbursements> GetReimbursementsAsync(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<Reimbursements> response = await GetReimbursementsAsyncWithHttpInfo(accessToken, xeroTenantId, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Reimbursements>> GetReimbursementsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<Reimbursements> response = await payrollNzXeroClient.GetReimbursementsAsyncWithHttpInfo(accessToken, xeroTenantId, page, cancellationToken);
        return response;
    }
    public async Task<StatutoryDeductionObject> GetStatutoryDeductionAsync(Guid id, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetStatutoryDeductionAsync(accessToken, xeroExtendedConfiguration.TenantId, id, cancellationToken);
    }



    public async Task<StatutoryDeductionObject> GetStatutoryDeductionAsync(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
        {
        ApiResponse<StatutoryDeductionObject> response = await GetStatutoryDeductionAsyncWithHttpInfo(accessToken, xeroTenantId, id, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<StatutoryDeductionObject>> GetStatutoryDeductionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
        {
        ApiResponse<StatutoryDeductionObject> response = await payrollNzXeroClient.GetStatutoryDeductionAsyncWithHttpInfo(accessToken, xeroTenantId, id, cancellationToken);
        return response;
    }
    public async Task<StatutoryDeductions> GetStatutoryDeductionsAsync(int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetStatutoryDeductionsAsync(accessToken, xeroExtendedConfiguration.TenantId, page, cancellationToken);
    }



    public async Task<StatutoryDeductions> GetStatutoryDeductionsAsync(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<StatutoryDeductions> response = await GetStatutoryDeductionsAsyncWithHttpInfo(accessToken, xeroTenantId, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<StatutoryDeductions>> GetStatutoryDeductionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<StatutoryDeductions> response = await payrollNzXeroClient.GetStatutoryDeductionsAsyncWithHttpInfo(accessToken, xeroTenantId, page, cancellationToken);
        return response;
    }
    public async Task<SuperannuationObject> GetSuperannuationAsync(Guid superannuationID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetSuperannuationAsync(accessToken, xeroExtendedConfiguration.TenantId, superannuationID, cancellationToken);
    }



    public async Task<SuperannuationObject> GetSuperannuationAsync(string accessToken, string xeroTenantId, Guid superannuationID, CancellationToken cancellationToken = default)
        {
        ApiResponse<SuperannuationObject> response = await GetSuperannuationAsyncWithHttpInfo(accessToken, xeroTenantId, superannuationID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SuperannuationObject>> GetSuperannuationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid superannuationID, CancellationToken cancellationToken = default)
        {
        ApiResponse<SuperannuationObject> response = await payrollNzXeroClient.GetSuperannuationAsyncWithHttpInfo(accessToken, xeroTenantId, superannuationID, cancellationToken);
        return response;
    }
    public async Task<Superannuations> GetSuperannuationsAsync(int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetSuperannuationsAsync(accessToken, xeroExtendedConfiguration.TenantId, page, cancellationToken);
    }



    public async Task<Superannuations> GetSuperannuationsAsync(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<Superannuations> response = await GetSuperannuationsAsyncWithHttpInfo(accessToken, xeroTenantId, page, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Superannuations>> GetSuperannuationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<Superannuations> response = await payrollNzXeroClient.GetSuperannuationsAsyncWithHttpInfo(accessToken, xeroTenantId, page, cancellationToken);
        return response;
    }
    public async Task<Timesheets> GetTimesheetsAsync(int? page = null, string? filter = null, string? status = null, string? startDate = null, string? endDate = null, string? sort = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetTimesheetsAsync(accessToken, xeroExtendedConfiguration.TenantId, page, filter, status, startDate, endDate, sort, cancellationToken);
    }



    public async Task<Timesheets> GetTimesheetsAsync(string accessToken, string xeroTenantId, int? page = null, string? filter = null, string? status = null, string? startDate = null, string? endDate = null, string? sort = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<Timesheets> response = await GetTimesheetsAsyncWithHttpInfo(accessToken, xeroTenantId, page, filter, status, startDate, endDate, sort, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Timesheets>> GetTimesheetsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, string? filter = null, string? status = null, string? startDate = null, string? endDate = null, string? sort = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<Timesheets> response = await payrollNzXeroClient.GetTimesheetsAsyncWithHttpInfo(accessToken, xeroTenantId, page, filter, status, startDate, endDate, sort, cancellationToken);
        return response;
    }
    public async Task<TrackingCategories> GetTrackingCategoriesAsync(CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetTrackingCategoriesAsync(accessToken, xeroExtendedConfiguration.TenantId, cancellationToken);
    }



    public async Task<TrackingCategories> GetTrackingCategoriesAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
        {
        ApiResponse<TrackingCategories> response = await GetTrackingCategoriesAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TrackingCategories>> GetTrackingCategoriesAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
        {
        ApiResponse<TrackingCategories> response = await payrollNzXeroClient.GetTrackingCategoriesAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response;
    }
    public async Task<TimesheetObject> RevertTimesheetAsync(Guid timesheetID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await RevertTimesheetAsync(accessToken, xeroExtendedConfiguration.TenantId, timesheetID, idempotencyKey, cancellationToken);
    }



    public async Task<TimesheetObject> RevertTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<TimesheetObject> response = await RevertTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TimesheetObject>> RevertTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<TimesheetObject> response = await payrollNzXeroClient.RevertTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EmployeeObject> UpdateEmployeeAsync(Guid employeeID, Employee employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateEmployeeAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employee, idempotencyKey, cancellationToken);
    }



    public async Task<EmployeeObject> UpdateEmployeeAsync(string accessToken, string xeroTenantId, Guid employeeID, Employee employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeObject> response = await UpdateEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employee, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeObject>> UpdateEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Employee employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeObject> response = await payrollNzXeroClient.UpdateEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employee, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EarningsTemplateObject> UpdateEmployeeEarningsTemplateAsync(Guid employeeID, Guid payTemplateEarningID, EarningsTemplate earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateEmployeeEarningsTemplateAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, payTemplateEarningID, earningsTemplate, idempotencyKey, cancellationToken);
    }



    public async Task<EarningsTemplateObject> UpdateEmployeeEarningsTemplateAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid payTemplateEarningID, EarningsTemplate earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EarningsTemplateObject> response = await UpdateEmployeeEarningsTemplateAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, payTemplateEarningID, earningsTemplate, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EarningsTemplateObject>> UpdateEmployeeEarningsTemplateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid payTemplateEarningID, EarningsTemplate earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EarningsTemplateObject> response = await payrollNzXeroClient.UpdateEmployeeEarningsTemplateAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, payTemplateEarningID, earningsTemplate, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EmployeeLeaveObject> UpdateEmployeeLeaveAsync(Guid employeeID, Guid leaveID, EmployeeLeave employeeLeave, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateEmployeeLeaveAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, leaveID, employeeLeave, idempotencyKey, cancellationToken);
    }



    public async Task<EmployeeLeaveObject> UpdateEmployeeLeaveAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, EmployeeLeave employeeLeave, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeLeaveObject> response = await UpdateEmployeeLeaveAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, leaveID, employeeLeave, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeLeaveObject>> UpdateEmployeeLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, EmployeeLeave employeeLeave, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeLeaveObject> response = await payrollNzXeroClient.UpdateEmployeeLeaveAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, leaveID, employeeLeave, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<SalaryAndWageObject> UpdateEmployeeSalaryAndWageAsync(Guid employeeID, Guid salaryAndWagesID, SalaryAndWage salaryAndWage, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateEmployeeSalaryAndWageAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, salaryAndWagesID, salaryAndWage, idempotencyKey, cancellationToken);
    }



    public async Task<SalaryAndWageObject> UpdateEmployeeSalaryAndWageAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, SalaryAndWage salaryAndWage, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<SalaryAndWageObject> response = await UpdateEmployeeSalaryAndWageAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, salaryAndWagesID, salaryAndWage, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<SalaryAndWageObject>> UpdateEmployeeSalaryAndWageAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, SalaryAndWage salaryAndWage, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<SalaryAndWageObject> response = await payrollNzXeroClient.UpdateEmployeeSalaryAndWageAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, salaryAndWagesID, salaryAndWage, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EmployeeTaxObject> UpdateEmployeeTaxAsync(Guid employeeID, EmployeeTax employeeTax, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateEmployeeTaxAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employeeTax, idempotencyKey, cancellationToken);
    }



    public async Task<EmployeeTaxObject> UpdateEmployeeTaxAsync(string accessToken, string xeroTenantId, Guid employeeID, EmployeeTax employeeTax, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeTaxObject> response = await UpdateEmployeeTaxAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeTax, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeTaxObject>> UpdateEmployeeTaxAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EmployeeTax employeeTax, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<EmployeeTaxObject> response = await payrollNzXeroClient.UpdateEmployeeTaxAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeTax, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<PayRunObject> UpdatePayRunAsync(Guid payRunID, PayRun payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdatePayRunAsync(accessToken, xeroExtendedConfiguration.TenantId, payRunID, payRun, idempotencyKey, cancellationToken);
    }

    public async Task<PayRunObject> UpdatePayRunAsync(string accessToken, string xeroTenantId, Guid payRunID, PayRun payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<PayRunObject> response = await UpdatePayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRunID, payRun, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PayRunObject>> UpdatePayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payRunID, PayRun payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<PayRunObject> response = await payrollNzXeroClient.UpdatePayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRunID, payRun, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<PaySlipObject> UpdatePaySlipLineItemsAsync(Guid paySlipID, PaySlip paySlip, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdatePaySlipLineItemsAsync(accessToken, xeroExtendedConfiguration.TenantId, paySlipID, paySlip, idempotencyKey, cancellationToken);
    }



    public async Task<PaySlipObject> UpdatePaySlipLineItemsAsync(string accessToken, string xeroTenantId, Guid paySlipID, PaySlip paySlip, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<PaySlipObject> response = await UpdatePaySlipLineItemsAsyncWithHttpInfo(accessToken, xeroTenantId, paySlipID, paySlip, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PaySlipObject>> UpdatePaySlipLineItemsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid paySlipID, PaySlip paySlip, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<PaySlipObject> response = await payrollNzXeroClient.UpdatePaySlipLineItemsAsyncWithHttpInfo(accessToken, xeroTenantId, paySlipID, paySlip, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<TimesheetLineObject> UpdateTimesheetLineAsync(Guid timesheetID, Guid timesheetLineID, TimesheetLine timesheetLine, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateTimesheetLineAsync(accessToken, xeroExtendedConfiguration.TenantId, timesheetID, timesheetLineID, timesheetLine, idempotencyKey, cancellationToken);
    }



    public async Task<TimesheetLineObject> UpdateTimesheetLineAsync(string accessToken, string xeroTenantId, Guid timesheetID, Guid timesheetLineID, TimesheetLine timesheetLine, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<TimesheetLineObject> response = await UpdateTimesheetLineAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, timesheetLineID, timesheetLine, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TimesheetLineObject>> UpdateTimesheetLineAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, Guid timesheetLineID, TimesheetLine timesheetLine, string? idempotencyKey = null, CancellationToken cancellationToken = default)
        {
        ApiResponse<TimesheetLineObject> response = await payrollNzXeroClient.UpdateTimesheetLineAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, timesheetLineID, timesheetLine, idempotencyKey, cancellationToken);
        return response;
    }

    Task<EmployeeObject> IPayrollNzApiAsync.GetEmployeeAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        return PayrollNzGetEmployeeAsync(accessToken, xeroTenantId, employeeID, cancellationToken);
    }

    Task<ApiResponse<EmployeeObject>> IPayrollNzApiAsync.GetEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        return PayrollNzGetEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
    }

    public async Task<EmployeeObject> PayrollNzGetEmployeeAsync(Guid employeeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollNzGetEmployeeAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, cancellationToken);
    }

    public async Task<EmployeeObject> PayrollNzGetEmployeeAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeObject> response = await PayrollNzGetEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeObject>> PayrollNzGetEmployeeAsyncWithHttpInfo(Guid employeeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollNzGetEmployeeAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, cancellationToken);
    }

    public async Task<ApiResponse<EmployeeObject>> PayrollNzGetEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeObject> response = await payrollNzXeroClient.GetEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response;
    }


    Task<PayRunObject> IPayrollNzApiAsync.GetPayRunAsync(string accessToken, string xeroTenantId, Guid payRunID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<PayRunObject>> IPayrollNzApiAsync.GetPayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payRunID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<Settings> IPayrollNzApiAsync.GetSettingsAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<Settings>> IPayrollNzApiAsync.GetSettingsAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<TimesheetObject> IPayrollNzApiAsync.GetTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<TimesheetObject>> IPayrollNzApiAsync.GetTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

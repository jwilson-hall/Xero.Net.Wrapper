using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.PayrollNz;

public partial class XeroService : IPayrollNzApi
{
    public Task<TimesheetObject> ApproveTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TimesheetObject>> ApproveTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<DeductionObject> CreateDeductionAsync(string accessToken, string xeroTenantId, Deduction deduction, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<DeductionObject>> CreateDeductionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Deduction deduction, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EarningsRateObject> CreateEarningsRateAsync(string accessToken, string xeroTenantId, EarningsRate earningsRate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EarningsRateObject>> CreateEarningsRateAsyncWithHttpInfo(string accessToken, string xeroTenantId, EarningsRate earningsRate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeObject> CreateEmployeeAsync(string accessToken, string xeroTenantId, Employee employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeObject>> CreateEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Employee employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EarningsTemplateObject> CreateEmployeeEarningsTemplateAsync(string accessToken, string xeroTenantId, Guid employeeID, EarningsTemplate earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EarningsTemplateObject>> CreateEmployeeEarningsTemplateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EarningsTemplate earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeLeaveObject> CreateEmployeeLeaveAsync(string accessToken, string xeroTenantId, Guid employeeID, EmployeeLeave employeeLeave, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeLeaveObject>> CreateEmployeeLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EmployeeLeave employeeLeave, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeLeaveSetupObject> CreateEmployeeLeaveSetupAsync(string accessToken, string xeroTenantId, Guid employeeID, EmployeeLeaveSetup employeeLeaveSetup, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeLeaveSetupObject>> CreateEmployeeLeaveSetupAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EmployeeLeaveSetup employeeLeaveSetup, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeLeaveTypeObject> CreateEmployeeLeaveTypeAsync(string accessToken, string xeroTenantId, Guid employeeID, EmployeeLeaveType employeeLeaveType, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeLeaveTypeObject>> CreateEmployeeLeaveTypeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EmployeeLeaveType employeeLeaveType, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeOpeningBalancesObject> CreateEmployeeOpeningBalancesAsync(string accessToken, string xeroTenantId, Guid employeeID, List<EmployeeOpeningBalance> employeeOpeningBalance, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeOpeningBalancesObject>> CreateEmployeeOpeningBalancesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, List<EmployeeOpeningBalance> employeeOpeningBalance, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentMethodObject> CreateEmployeePaymentMethodAsync(string accessToken, string xeroTenantId, Guid employeeID, PaymentMethod paymentMethod, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PaymentMethodObject>> CreateEmployeePaymentMethodAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, PaymentMethod paymentMethod, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<SalaryAndWageObject> CreateEmployeeSalaryAndWageAsync(string accessToken, string xeroTenantId, Guid employeeID, SalaryAndWage salaryAndWage, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<SalaryAndWageObject>> CreateEmployeeSalaryAndWageAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, SalaryAndWage salaryAndWage, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeWorkingPatternWithWorkingWeeksObject> CreateEmployeeWorkingPatternAsync(string accessToken, string xeroTenantId, Guid employeeID, EmployeeWorkingPatternWithWorkingWeeksRequest employeeWorkingPatternWithWorkingWeeksRequest, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeWorkingPatternWithWorkingWeeksObject>> CreateEmployeeWorkingPatternAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EmployeeWorkingPatternWithWorkingWeeksRequest employeeWorkingPatternWithWorkingWeeksRequest, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmploymentObject> CreateEmploymentAsync(string accessToken, string xeroTenantId, Guid employeeID, Employment employment, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmploymentObject>> CreateEmploymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Employment employment, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<LeaveTypeObject> CreateLeaveTypeAsync(string accessToken, string xeroTenantId, LeaveType leaveType, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<LeaveTypeObject>> CreateLeaveTypeAsyncWithHttpInfo(string accessToken, string xeroTenantId, LeaveType leaveType, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeEarningsTemplates> CreateMultipleEmployeeEarningsTemplateAsync(string accessToken, string xeroTenantId, Guid employeeID, List<EarningsTemplate> earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeEarningsTemplates>> CreateMultipleEmployeeEarningsTemplateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, List<EarningsTemplate> earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PayRunObject> CreatePayRunAsync(string accessToken, string xeroTenantId, PayRun payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PayRunObject>> CreatePayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, PayRun payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PayRunCalendarObject> CreatePayRunCalendarAsync(string accessToken, string xeroTenantId, PayRunCalendar payRunCalendar, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PayRunCalendarObject>> CreatePayRunCalendarAsyncWithHttpInfo(string accessToken, string xeroTenantId, PayRunCalendar payRunCalendar, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ReimbursementObject> CreateReimbursementAsync(string accessToken, string xeroTenantId, Reimbursement reimbursement, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ReimbursementObject>> CreateReimbursementAsyncWithHttpInfo(string accessToken, string xeroTenantId, Reimbursement reimbursement, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<SuperannuationObject> CreateSuperannuationAsync(string accessToken, string xeroTenantId, Benefit benefit, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<SuperannuationObject>> CreateSuperannuationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Benefit benefit, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TimesheetObject> CreateTimesheetAsync(string accessToken, string xeroTenantId, Timesheet timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TimesheetObject>> CreateTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Timesheet timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TimesheetLineObject> CreateTimesheetLineAsync(string accessToken, string xeroTenantId, Guid timesheetID, TimesheetLine timesheetLine, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TimesheetLineObject>> CreateTimesheetLineAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, TimesheetLine timesheetLine, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EarningsTemplateObject> DeleteEmployeeEarningsTemplateAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid payTemplateEarningID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EarningsTemplateObject>> DeleteEmployeeEarningsTemplateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid payTemplateEarningID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeLeaveObject> DeleteEmployeeLeaveAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeLeaveObject>> DeleteEmployeeLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<SalaryAndWageObject> DeleteEmployeeSalaryAndWageAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<SalaryAndWageObject>> DeleteEmployeeSalaryAndWageAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeLeaveObject> DeleteEmployeeWorkingPatternAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid employeeWorkingPatternID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeLeaveObject>> DeleteEmployeeWorkingPatternAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid employeeWorkingPatternID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TimesheetLine> DeleteTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TimesheetLine>> DeleteTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TimesheetLine> DeleteTimesheetLineAsync(string accessToken, string xeroTenantId, Guid timesheetID, Guid timesheetLineID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TimesheetLine>> DeleteTimesheetLineAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, Guid timesheetLineID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<DeductionObject> GetDeductionAsync(string accessToken, string xeroTenantId, Guid deductionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<DeductionObject>> GetDeductionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid deductionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Deductions> GetDeductionsAsync(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Deductions>> GetDeductionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EarningsRateObject> GetEarningsRateAsync(string accessToken, string xeroTenantId, Guid earningsRateID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EarningsRateObject>> GetEarningsRateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid earningsRateID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EarningsRates> GetEarningsRatesAsync(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EarningsRates>> GetEarningsRatesAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeLeaveBalances> GetEmployeeLeaveBalancesAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeLeaveBalances>> GetEmployeeLeaveBalancesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<LeavePeriods> GetEmployeeLeavePeriodsAsync(string accessToken, string xeroTenantId, Guid employeeID, DateTime? startDate = null, DateTime? endDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<LeavePeriods>> GetEmployeeLeavePeriodsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, DateTime? startDate = null, DateTime? endDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeLeaves> GetEmployeeLeavesAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeLeaves>> GetEmployeeLeavesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeLeaveTypes> GetEmployeeLeaveTypesAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeLeaveTypes>> GetEmployeeLeaveTypesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeOpeningBalancesObject> GetEmployeeOpeningBalancesAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeOpeningBalancesObject>> GetEmployeeOpeningBalancesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentMethodObject> GetEmployeePaymentMethodAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PaymentMethodObject>> GetEmployeePaymentMethodAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeePayTemplates> GetEmployeePayTemplatesAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeePayTemplates>> GetEmployeePayTemplatesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<SalaryAndWages> GetEmployeeSalaryAndWageAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<SalaryAndWages>> GetEmployeeSalaryAndWageAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<SalaryAndWages> GetEmployeeSalaryAndWagesAsync(string accessToken, string xeroTenantId, Guid employeeID, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<SalaryAndWages>> GetEmployeeSalaryAndWagesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Employees> GetEmployeesAsync(string accessToken, string xeroTenantId, string? filter = null, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Employees>> GetEmployeesAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? filter = null, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeTaxObject> GetEmployeeTaxAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeTaxObject>> GetEmployeeTaxAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeWorkingPatternWithWorkingWeeksObject> GetEmployeeWorkingPatternAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid employeeWorkingPatternID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeWorkingPatternWithWorkingWeeksObject>> GetEmployeeWorkingPatternAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid employeeWorkingPatternID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeWorkingPatternsObject> GetEmployeeWorkingPatternsAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeWorkingPatternsObject>> GetEmployeeWorkingPatternsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<LeaveTypeObject> GetLeaveTypeAsync(string accessToken, string xeroTenantId, Guid leaveTypeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<LeaveTypeObject>> GetLeaveTypeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveTypeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<LeaveTypes> GetLeaveTypesAsync(string accessToken, string xeroTenantId, int? page = null, bool? activeOnly = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<LeaveTypes>> GetLeaveTypesAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, bool? activeOnly = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PayRunCalendarObject> GetPayRunCalendarAsync(string accessToken, string xeroTenantId, Guid payrollCalendarID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PayRunCalendarObject>> GetPayRunCalendarAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payrollCalendarID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PayRunCalendars> GetPayRunCalendarsAsync(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PayRunCalendars>> GetPayRunCalendarsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PayRuns> GetPayRunsAsync(string accessToken, string xeroTenantId, int? page = null, string? status = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PayRuns>> GetPayRunsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, string? status = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PaySlipObject> GetPaySlipAsync(string accessToken, string xeroTenantId, Guid paySlipID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PaySlipObject>> GetPaySlipAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid paySlipID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PaySlips> GetPaySlipsAsync(string accessToken, string xeroTenantId, Guid payRunID, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PaySlips>> GetPaySlipsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payRunID, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ReimbursementObject> GetReimbursementAsync(string accessToken, string xeroTenantId, Guid reimbursementID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ReimbursementObject>> GetReimbursementAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid reimbursementID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Reimbursements> GetReimbursementsAsync(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Reimbursements>> GetReimbursementsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<StatutoryDeductionObject> GetStatutoryDeductionAsync(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<StatutoryDeductionObject>> GetStatutoryDeductionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<StatutoryDeductions> GetStatutoryDeductionsAsync(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<StatutoryDeductions>> GetStatutoryDeductionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<SuperannuationObject> GetSuperannuationAsync(string accessToken, string xeroTenantId, Guid superannuationID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<SuperannuationObject>> GetSuperannuationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid superannuationID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Superannuations> GetSuperannuationsAsync(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Superannuations>> GetSuperannuationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Timesheets> GetTimesheetsAsync(string accessToken, string xeroTenantId, int? page = null, string? filter = null, string? status = null, string? startDate = null, string? endDate = null, string? sort = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Timesheets>> GetTimesheetsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, string? filter = null, string? status = null, string? startDate = null, string? endDate = null, string? sort = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TrackingCategories> GetTrackingCategoriesAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TrackingCategories>> GetTrackingCategoriesAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TimesheetObject> RevertTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TimesheetObject>> RevertTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeObject> UpdateEmployeeAsync(string accessToken, string xeroTenantId, Guid employeeID, Employee employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeObject>> UpdateEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Employee employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EarningsTemplateObject> UpdateEmployeeEarningsTemplateAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid payTemplateEarningID, EarningsTemplate earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EarningsTemplateObject>> UpdateEmployeeEarningsTemplateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid payTemplateEarningID, EarningsTemplate earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeLeaveObject> UpdateEmployeeLeaveAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, EmployeeLeave employeeLeave, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeLeaveObject>> UpdateEmployeeLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, EmployeeLeave employeeLeave, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<SalaryAndWageObject> UpdateEmployeeSalaryAndWageAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, SalaryAndWage salaryAndWage, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<SalaryAndWageObject>> UpdateEmployeeSalaryAndWageAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, SalaryAndWage salaryAndWage, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeTaxObject> UpdateEmployeeTaxAsync(string accessToken, string xeroTenantId, Guid employeeID, EmployeeTax employeeTax, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeTaxObject>> UpdateEmployeeTaxAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EmployeeTax employeeTax, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PayRunObject> UpdatePayRunAsync(string accessToken, string xeroTenantId, Guid payRunID, PayRun payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PayRunObject>> UpdatePayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payRunID, PayRun payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PaySlipObject> UpdatePaySlipLineItemsAsync(string accessToken, string xeroTenantId, Guid paySlipID, PaySlip paySlip, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PaySlipObject>> UpdatePaySlipLineItemsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid paySlipID, PaySlip paySlip, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TimesheetLineObject> UpdateTimesheetLineAsync(string accessToken, string xeroTenantId, Guid timesheetID, Guid timesheetLineID, TimesheetLine timesheetLine, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TimesheetLineObject>> UpdateTimesheetLineAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, Guid timesheetLineID, TimesheetLine timesheetLine, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    Task<EmployeeObject> IPayrollNzApiAsync.GetEmployeeAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<EmployeeObject>> IPayrollNzApiAsync.GetEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
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

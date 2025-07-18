using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.PayrollUk;

public partial class XeroService : IPayrollUkApi
{
    public Task<BenefitObject> CreateBenefitAsync(string accessToken, string xeroTenantId, Benefit benefit, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BenefitObject>> CreateBenefitAsyncWithHttpInfo(string accessToken, string xeroTenantId, Benefit benefit, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<DeductionObject> CreateDeductionAsync(string accessToken, string xeroTenantId, Deduction deduction, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<DeductionObject>> CreateDeductionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Deduction deduction, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EarningsRateObject> CreateEarningsRateAsync(string accessToken, string xeroTenantId, EarningsRate earningsRate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EarningsRateObject>> CreateEarningsRateAsyncWithHttpInfo(string accessToken, string xeroTenantId, EarningsRate earningsRate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeObject> CreateEmployeeAsync(string accessToken, string xeroTenantId, Employee employee, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeObject>> CreateEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Employee employee, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EarningsTemplateObject> CreateEmployeeEarningsTemplateAsync(string accessToken, string xeroTenantId, Guid employeeID, EarningsTemplate earningsTemplate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EarningsTemplateObject>> CreateEmployeeEarningsTemplateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EarningsTemplate earningsTemplate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeLeaveObject> CreateEmployeeLeaveAsync(string accessToken, string xeroTenantId, Guid employeeID, EmployeeLeave employeeLeave, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeLeaveObject>> CreateEmployeeLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EmployeeLeave employeeLeave, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeLeaveTypeObject> CreateEmployeeLeaveTypeAsync(string accessToken, string xeroTenantId, Guid employeeID, EmployeeLeaveType employeeLeaveType, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeLeaveTypeObject>> CreateEmployeeLeaveTypeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EmployeeLeaveType employeeLeaveType, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeOpeningBalancesObject> CreateEmployeeOpeningBalancesAsync(string accessToken, string xeroTenantId, Guid employeeID, EmployeeOpeningBalances employeeOpeningBalances, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeOpeningBalancesObject>> CreateEmployeeOpeningBalancesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EmployeeOpeningBalances employeeOpeningBalances, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentMethodObject> CreateEmployeePaymentMethodAsync(string accessToken, string xeroTenantId, Guid employeeID, PaymentMethod paymentMethod, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PaymentMethodObject>> CreateEmployeePaymentMethodAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, PaymentMethod paymentMethod, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<SalaryAndWageObject> CreateEmployeeSalaryAndWageAsync(string accessToken, string xeroTenantId, Guid employeeID, SalaryAndWage salaryAndWage, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<SalaryAndWageObject>> CreateEmployeeSalaryAndWageAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, SalaryAndWage salaryAndWage, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeStatutorySickLeaveObject> CreateEmployeeStatutorySickLeaveAsync(string accessToken, string xeroTenantId, EmployeeStatutorySickLeave employeeStatutorySickLeave, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeStatutorySickLeaveObject>> CreateEmployeeStatutorySickLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, EmployeeStatutorySickLeave employeeStatutorySickLeave, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmploymentObject> CreateEmploymentAsync(string accessToken, string xeroTenantId, Guid employeeID, Employment employment, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmploymentObject>> CreateEmploymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Employment employment, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<LeaveTypeObject> CreateLeaveTypeAsync(string accessToken, string xeroTenantId, LeaveType leaveType, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<LeaveTypeObject>> CreateLeaveTypeAsyncWithHttpInfo(string accessToken, string xeroTenantId, LeaveType leaveType, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeePayTemplates> CreateMultipleEmployeeEarningsTemplateAsync(string accessToken, string xeroTenantId, Guid employeeID, List<EarningsTemplate> earningsTemplate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeePayTemplates>> CreateMultipleEmployeeEarningsTemplateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, List<EarningsTemplate> earningsTemplate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PayRunCalendarObject> CreatePayRunCalendarAsync(string accessToken, string xeroTenantId, PayRunCalendar payRunCalendar, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PayRunCalendarObject>> CreatePayRunCalendarAsyncWithHttpInfo(string accessToken, string xeroTenantId, PayRunCalendar payRunCalendar, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ReimbursementObject> CreateReimbursementAsync(string accessToken, string xeroTenantId, Reimbursement reimbursement, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ReimbursementObject>> CreateReimbursementAsyncWithHttpInfo(string accessToken, string xeroTenantId, Reimbursement reimbursement, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TimesheetObject> CreateTimesheetAsync(string accessToken, string xeroTenantId, Timesheet timesheet, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TimesheetObject>> CreateTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Timesheet timesheet, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TimesheetLineObject> CreateTimesheetLineAsync(string accessToken, string xeroTenantId, Guid timesheetID, TimesheetLine timesheetLine, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TimesheetLineObject>> CreateTimesheetLineAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, TimesheetLine timesheetLine, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<BenefitObject> GetBenefitAsync(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BenefitObject>> GetBenefitAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Benefits> GetBenefitsAsync(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Benefits>> GetBenefitsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EarningsOrderObject> GetEarningsOrderAsync(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EarningsOrderObject>> GetEarningsOrderAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EarningsOrders> GetEarningsOrdersAsync(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EarningsOrders>> GetEarningsOrdersAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeLeaveObject> GetEmployeeLeaveAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeLeaveObject>> GetEmployeeLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeePayTemplateObject> GetEmployeePayTemplateAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeePayTemplateObject>> GetEmployeePayTemplateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeStatutoryLeaveBalanceObject> GetEmployeeStatutoryLeaveBalancesAsync(string accessToken, string xeroTenantId, Guid employeeID, string leaveType = null, DateTime? asOfDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeStatutoryLeaveBalanceObject>> GetEmployeeStatutoryLeaveBalancesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, string leaveType = null, DateTime? asOfDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeStatutorySickLeaveObject> GetEmployeeStatutorySickLeaveAsync(string accessToken, string xeroTenantId, Guid statutorySickLeaveID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeStatutorySickLeaveObject>> GetEmployeeStatutorySickLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid statutorySickLeaveID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeStatutoryLeavesSummaries> GetStatutoryLeaveSummaryAsync(string accessToken, string xeroTenantId, Guid employeeID, bool? activeOnly = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeStatutoryLeavesSummaries>> GetStatutoryLeaveSummaryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, bool? activeOnly = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeObject> UpdateEmployeeAsync(string accessToken, string xeroTenantId, Guid employeeID, Employee employee, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeObject>> UpdateEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Employee employee, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EarningsTemplateObject> UpdateEmployeeEarningsTemplateAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid payTemplateEarningID, EarningsTemplate earningsTemplate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EarningsTemplateObject>> UpdateEmployeeEarningsTemplateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid payTemplateEarningID, EarningsTemplate earningsTemplate, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeLeaveObject> UpdateEmployeeLeaveAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, EmployeeLeave employeeLeave, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeLeaveObject>> UpdateEmployeeLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, EmployeeLeave employeeLeave, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeOpeningBalancesObject> UpdateEmployeeOpeningBalancesAsync(string accessToken, string xeroTenantId, Guid employeeID, EmployeeOpeningBalances employeeOpeningBalances, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EmployeeOpeningBalancesObject>> UpdateEmployeeOpeningBalancesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EmployeeOpeningBalances employeeOpeningBalances, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<SalaryAndWageObject> UpdateEmployeeSalaryAndWageAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, SalaryAndWage salaryAndWage, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<SalaryAndWageObject>> UpdateEmployeeSalaryAndWageAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, SalaryAndWage salaryAndWage, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PayRunObject> UpdatePayRunAsync(string accessToken, string xeroTenantId, Guid payRunID, PayRun payRun, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PayRunObject>> UpdatePayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payRunID, PayRun payRun, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TimesheetLineObject> UpdateTimesheetLineAsync(string accessToken, string xeroTenantId, Guid timesheetID, Guid timesheetLineID, TimesheetLine timesheetLine, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TimesheetLineObject>> UpdateTimesheetLineAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, Guid timesheetLineID, TimesheetLine timesheetLine, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    Task<TimesheetObject> IPayrollUkApiAsync.ApproveTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, string idempotencyKey, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<TimesheetObject>> IPayrollUkApiAsync.ApproveTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, string idempotencyKey, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task IPayrollUkApiAsync.DeleteEmployeeEarningsTemplateAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid payTemplateEarningID, CancellationToken cancellationToken)
    {
        return DeleteEmployeeEarningsTemplateAsync(accessToken, xeroTenantId, employeeID, payTemplateEarningID, cancellationToken);
    }

    Task<ApiResponse<object>> IPayrollUkApiAsync.DeleteEmployeeEarningsTemplateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid payTemplateEarningID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<EmployeeLeaveObject> IPayrollUkApiAsync.DeleteEmployeeLeaveAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<EmployeeLeaveObject>> IPayrollUkApiAsync.DeleteEmployeeLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task IPayrollUkApiAsync.DeleteEmployeeSalaryAndWageAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, CancellationToken cancellationToken)
    {
        return DeleteEmployeeSalaryAndWageAsync(accessToken, xeroTenantId, employeeID, salaryAndWagesID, cancellationToken);
    }

    Task<ApiResponse<object>> IPayrollUkApiAsync.DeleteEmployeeSalaryAndWageAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<TimesheetLine> IPayrollUkApiAsync.DeleteTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<TimesheetLine>> IPayrollUkApiAsync.DeleteTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<TimesheetLine> IPayrollUkApiAsync.DeleteTimesheetLineAsync(string accessToken, string xeroTenantId, Guid timesheetID, Guid timesheetLineID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<TimesheetLine>> IPayrollUkApiAsync.DeleteTimesheetLineAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, Guid timesheetLineID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<DeductionObject> IPayrollUkApiAsync.GetDeductionAsync(string accessToken, string xeroTenantId, Guid deductionId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<DeductionObject>> IPayrollUkApiAsync.GetDeductionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid deductionId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<Deductions> IPayrollUkApiAsync.GetDeductionsAsync(string accessToken, string xeroTenantId, int? page, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<Deductions>> IPayrollUkApiAsync.GetDeductionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<EarningsRateObject> IPayrollUkApiAsync.GetEarningsRateAsync(string accessToken, string xeroTenantId, Guid earningsRateID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<EarningsRateObject>> IPayrollUkApiAsync.GetEarningsRateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid earningsRateID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<EarningsRates> IPayrollUkApiAsync.GetEarningsRatesAsync(string accessToken, string xeroTenantId, int? page, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<EarningsRates>> IPayrollUkApiAsync.GetEarningsRatesAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<EmployeeObject> IPayrollUkApiAsync.GetEmployeeAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<EmployeeObject>> IPayrollUkApiAsync.GetEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<EmployeeLeaveBalances> IPayrollUkApiAsync.GetEmployeeLeaveBalancesAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<EmployeeLeaveBalances>> IPayrollUkApiAsync.GetEmployeeLeaveBalancesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<LeavePeriods> IPayrollUkApiAsync.GetEmployeeLeavePeriodsAsync(string accessToken, string xeroTenantId, Guid employeeID, DateTime? startDate, DateTime? endDate, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<LeavePeriods>> IPayrollUkApiAsync.GetEmployeeLeavePeriodsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, DateTime? startDate, DateTime? endDate, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<EmployeeLeaves> IPayrollUkApiAsync.GetEmployeeLeavesAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<EmployeeLeaves>> IPayrollUkApiAsync.GetEmployeeLeavesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<EmployeeLeaveTypes> IPayrollUkApiAsync.GetEmployeeLeaveTypesAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<EmployeeLeaveTypes>> IPayrollUkApiAsync.GetEmployeeLeaveTypesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<EmployeeOpeningBalancesObject> IPayrollUkApiAsync.GetEmployeeOpeningBalancesAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<EmployeeOpeningBalancesObject>> IPayrollUkApiAsync.GetEmployeeOpeningBalancesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<PaymentMethodObject> IPayrollUkApiAsync.GetEmployeePaymentMethodAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<PaymentMethodObject>> IPayrollUkApiAsync.GetEmployeePaymentMethodAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<SalaryAndWages> IPayrollUkApiAsync.GetEmployeeSalaryAndWageAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<SalaryAndWages>> IPayrollUkApiAsync.GetEmployeeSalaryAndWageAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<SalaryAndWages> IPayrollUkApiAsync.GetEmployeeSalaryAndWagesAsync(string accessToken, string xeroTenantId, Guid employeeID, int? page, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<SalaryAndWages>> IPayrollUkApiAsync.GetEmployeeSalaryAndWagesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, int? page, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<Employees> IPayrollUkApiAsync.GetEmployeesAsync(string accessToken, string xeroTenantId, string filter, int? page, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<Employees>> IPayrollUkApiAsync.GetEmployeesAsyncWithHttpInfo(string accessToken, string xeroTenantId, string filter, int? page, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<EmployeeTaxObject> IPayrollUkApiAsync.GetEmployeeTaxAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<EmployeeTaxObject>> IPayrollUkApiAsync.GetEmployeeTaxAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<LeaveTypeObject> IPayrollUkApiAsync.GetLeaveTypeAsync(string accessToken, string xeroTenantId, Guid leaveTypeID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<LeaveTypeObject>> IPayrollUkApiAsync.GetLeaveTypeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid leaveTypeID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<LeaveTypes> IPayrollUkApiAsync.GetLeaveTypesAsync(string accessToken, string xeroTenantId, int? page, bool? activeOnly, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<LeaveTypes>> IPayrollUkApiAsync.GetLeaveTypesAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page, bool? activeOnly, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<PayRunObject> IPayrollUkApiAsync.GetPayRunAsync(string accessToken, string xeroTenantId, Guid payRunID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<PayRunObject>> IPayrollUkApiAsync.GetPayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payRunID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<PayRunCalendarObject> IPayrollUkApiAsync.GetPayRunCalendarAsync(string accessToken, string xeroTenantId, Guid payRunCalendarID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<PayRunCalendarObject>> IPayrollUkApiAsync.GetPayRunCalendarAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payRunCalendarID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<PayRunCalendars> IPayrollUkApiAsync.GetPayRunCalendarsAsync(string accessToken, string xeroTenantId, int? page, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<PayRunCalendars>> IPayrollUkApiAsync.GetPayRunCalendarsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<PayRuns> IPayrollUkApiAsync.GetPayRunsAsync(string accessToken, string xeroTenantId, int? page, string status, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<PayRuns>> IPayrollUkApiAsync.GetPayRunsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page, string status, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<PayslipObject> IPayrollUkApiAsync.GetPaySlipAsync(string accessToken, string xeroTenantId, Guid payslipID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<PayslipObject>> IPayrollUkApiAsync.GetPaySlipAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payslipID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<Payslips> IPayrollUkApiAsync.GetPaySlipsAsync(string accessToken, string xeroTenantId, Guid payRunID, int? page, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<Payslips>> IPayrollUkApiAsync.GetPaySlipsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payRunID, int? page, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ReimbursementObject> IPayrollUkApiAsync.GetReimbursementAsync(string accessToken, string xeroTenantId, Guid reimbursementID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<ReimbursementObject>> IPayrollUkApiAsync.GetReimbursementAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid reimbursementID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<Reimbursements> IPayrollUkApiAsync.GetReimbursementsAsync(string accessToken, string xeroTenantId, int? page, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<Reimbursements>> IPayrollUkApiAsync.GetReimbursementsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<Settings> IPayrollUkApiAsync.GetSettingsAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<Settings>> IPayrollUkApiAsync.GetSettingsAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<TimesheetObject> IPayrollUkApiAsync.GetTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<TimesheetObject>> IPayrollUkApiAsync.GetTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<Timesheets> IPayrollUkApiAsync.GetTimesheetsAsync(string accessToken, string xeroTenantId, int? page, string filter, string status, string startDate, string endDate, string sort, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<Timesheets>> IPayrollUkApiAsync.GetTimesheetsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page, string filter, string status, string startDate, string endDate, string sort, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<TrackingCategories> IPayrollUkApiAsync.GetTrackingCategoriesAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<TrackingCategories>> IPayrollUkApiAsync.GetTrackingCategoriesAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<TimesheetObject> IPayrollUkApiAsync.RevertTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, string idempotencyKey, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<ApiResponse<TimesheetObject>> IPayrollUkApiAsync.RevertTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, string idempotencyKey, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

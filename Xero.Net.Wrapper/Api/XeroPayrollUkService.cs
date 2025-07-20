using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.PayrollUk;

namespace Xero.Net.Wrapper.Api;

public partial class XeroService : IPayrollUkApi
{
    public async Task<BenefitObject> CreateBenefitAsync(Benefit benefit, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateBenefitAsync(accessToken, xeroExtendedConfiguration.TenantId, benefit, idempotencyKey, cancellationToken);
    }


    public async Task<BenefitObject> CreateBenefitAsync(string accessToken, string xeroTenantId, Benefit benefit, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BenefitObject> response = await CreateBenefitAsyncWithHttpInfo(accessToken, xeroTenantId, benefit, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<BenefitObject>> CreateBenefitAsyncWithHttpInfo(Benefit benefit, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateBenefitAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, benefit, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<BenefitObject>> CreateBenefitAsyncWithHttpInfo(string accessToken, string xeroTenantId, Benefit benefit, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BenefitObject> response = await payrollUkXeroClient.CreateBenefitAsyncWithHttpInfo(accessToken, xeroTenantId, benefit, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<DeductionObject>> CreateDeductionAsyncWithHttpInfo(Deduction deduction, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateDeductionAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, deduction, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<DeductionObject>> CreateDeductionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Deduction deduction, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<DeductionObject> response = await payrollUkXeroClient.CreateDeductionAsyncWithHttpInfo(accessToken, xeroTenantId, deduction, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<EarningsRateObject>> CreateEarningsRateAsyncWithHttpInfo(EarningsRate earningsRate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEarningsRateAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, earningsRate, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<EarningsRateObject>> CreateEarningsRateAsyncWithHttpInfo(string accessToken, string xeroTenantId, EarningsRate earningsRate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EarningsRateObject> response = await payrollUkXeroClient.CreateEarningsRateAsyncWithHttpInfo(accessToken, xeroTenantId, earningsRate, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<EmployeeObject>> CreateEmployeeAsyncWithHttpInfo(Employee employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeeAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employee, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<EmployeeObject>> CreateEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Employee employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeObject> response = await payrollUkXeroClient.CreateEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employee, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<EarningsTemplateObject>> CreateEmployeeEarningsTemplateAsyncWithHttpInfo(Guid employeeID, EarningsTemplate earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeeEarningsTemplateAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, earningsTemplate, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<EarningsTemplateObject>> CreateEmployeeEarningsTemplateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EarningsTemplate earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EarningsTemplateObject> response = await payrollUkXeroClient.CreateEmployeeEarningsTemplateAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, earningsTemplate, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<EmployeeLeaveObject>> CreateEmployeeLeaveAsyncWithHttpInfo(Guid employeeID, EmployeeLeave employeeLeave, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeeLeaveAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employeeLeave, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<EmployeeLeaveObject>> CreateEmployeeLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EmployeeLeave employeeLeave, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeLeaveObject> response = await payrollUkXeroClient.CreateEmployeeLeaveAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeLeave, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<EmployeeLeaveTypeObject>> CreateEmployeeLeaveTypeAsyncWithHttpInfo(Guid employeeID, EmployeeLeaveType employeeLeaveType, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeeLeaveTypeAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employeeLeaveType, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<EmployeeLeaveTypeObject>> CreateEmployeeLeaveTypeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EmployeeLeaveType employeeLeaveType, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeLeaveTypeObject> response = await payrollUkXeroClient.CreateEmployeeLeaveTypeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeLeaveType, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EmployeeOpeningBalancesObject> CreateEmployeeOpeningBalancesAsync(Guid employeeID, EmployeeOpeningBalances employeeOpeningBalances, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeeOpeningBalancesAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employeeOpeningBalances, idempotencyKey, cancellationToken);
    }



    public async Task<EmployeeOpeningBalancesObject> CreateEmployeeOpeningBalancesAsync(string accessToken, string xeroTenantId, Guid employeeID, EmployeeOpeningBalances employeeOpeningBalances, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeOpeningBalancesObject> response = await CreateEmployeeOpeningBalancesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeOpeningBalances, idempotencyKey, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<EmployeeOpeningBalancesObject>> CreateEmployeeOpeningBalancesAsyncWithHttpInfo(Guid employeeID, EmployeeOpeningBalances employeeOpeningBalances, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeeOpeningBalancesAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employeeOpeningBalances, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<EmployeeOpeningBalancesObject>> CreateEmployeeOpeningBalancesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EmployeeOpeningBalances employeeOpeningBalances, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeOpeningBalancesObject> response = await payrollUkXeroClient.CreateEmployeeOpeningBalancesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeOpeningBalances, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<PaymentMethodObject>> CreateEmployeePaymentMethodAsyncWithHttpInfo(Guid employeeID, PaymentMethod paymentMethod, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeePaymentMethodAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, paymentMethod, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<PaymentMethodObject>> CreateEmployeePaymentMethodAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, PaymentMethod paymentMethod, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PaymentMethodObject> response = await payrollUkXeroClient.CreateEmployeePaymentMethodAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, paymentMethod, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<SalaryAndWageObject>> CreateEmployeeSalaryAndWageAsyncWithHttpInfo(Guid employeeID, SalaryAndWage salaryAndWage, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeeSalaryAndWageAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, salaryAndWage, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<SalaryAndWageObject>> CreateEmployeeSalaryAndWageAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, SalaryAndWage salaryAndWage, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<SalaryAndWageObject> response = await payrollUkXeroClient.CreateEmployeeSalaryAndWageAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, salaryAndWage, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EmployeeStatutorySickLeaveObject> CreateEmployeeStatutorySickLeaveAsync(EmployeeStatutorySickLeave employeeStatutorySickLeave, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeeStatutorySickLeaveAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeStatutorySickLeave, idempotencyKey, cancellationToken);
    }



    public async Task<EmployeeStatutorySickLeaveObject> CreateEmployeeStatutorySickLeaveAsync(string accessToken, string xeroTenantId, EmployeeStatutorySickLeave employeeStatutorySickLeave, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeStatutorySickLeaveObject> response = await CreateEmployeeStatutorySickLeaveAsyncWithHttpInfo(accessToken, xeroTenantId, employeeStatutorySickLeave, idempotencyKey, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<EmployeeStatutorySickLeaveObject>> CreateEmployeeStatutorySickLeaveAsyncWithHttpInfo(EmployeeStatutorySickLeave employeeStatutorySickLeave, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeeStatutorySickLeaveAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeStatutorySickLeave, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<EmployeeStatutorySickLeaveObject>> CreateEmployeeStatutorySickLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, EmployeeStatutorySickLeave employeeStatutorySickLeave, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeStatutorySickLeaveObject> response = await payrollUkXeroClient.CreateEmployeeStatutorySickLeaveAsyncWithHttpInfo(accessToken, xeroTenantId, employeeStatutorySickLeave, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<EmploymentObject>> CreateEmploymentAsyncWithHttpInfo(Guid employeeID, Employment employment, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmploymentAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employment, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<EmploymentObject>> CreateEmploymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Employment employment, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmploymentObject> response = await payrollUkXeroClient.CreateEmploymentAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employment, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<LeaveTypeObject>> CreateLeaveTypeAsyncWithHttpInfo(LeaveType leaveType, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateLeaveTypeAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, leaveType, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<LeaveTypeObject>> CreateLeaveTypeAsyncWithHttpInfo(string accessToken, string xeroTenantId, LeaveType leaveType, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LeaveTypeObject> response = await payrollUkXeroClient.CreateLeaveTypeAsyncWithHttpInfo(accessToken, xeroTenantId, leaveType, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EmployeePayTemplates> CreateMultipleEmployeeEarningsTemplateAsync(Guid employeeID, List<EarningsTemplate> earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateMultipleEmployeeEarningsTemplateAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, earningsTemplate, idempotencyKey, cancellationToken);
    }



    public async Task<EmployeePayTemplates> CreateMultipleEmployeeEarningsTemplateAsync(string accessToken, string xeroTenantId, Guid employeeID, List<EarningsTemplate> earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeePayTemplates> response = await CreateMultipleEmployeeEarningsTemplateAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, earningsTemplate, idempotencyKey, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<EmployeePayTemplates>> CreateMultipleEmployeeEarningsTemplateAsyncWithHttpInfo(Guid employeeID, List<EarningsTemplate> earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateMultipleEmployeeEarningsTemplateAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, earningsTemplate, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<EmployeePayTemplates>> CreateMultipleEmployeeEarningsTemplateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, List<EarningsTemplate> earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeePayTemplates> response = await payrollUkXeroClient.CreateMultipleEmployeeEarningsTemplateAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, earningsTemplate, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<PayRunCalendarObject>> CreatePayRunCalendarAsyncWithHttpInfo(PayRunCalendar payRunCalendar, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreatePayRunCalendarAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, payRunCalendar, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<PayRunCalendarObject>> CreatePayRunCalendarAsyncWithHttpInfo(string accessToken, string xeroTenantId, PayRunCalendar payRunCalendar, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayRunCalendarObject> response = await payrollUkXeroClient.CreatePayRunCalendarAsyncWithHttpInfo(accessToken, xeroTenantId, payRunCalendar, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<ReimbursementObject>> CreateReimbursementAsyncWithHttpInfo(Reimbursement reimbursement, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateReimbursementAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, reimbursement, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<ReimbursementObject>> CreateReimbursementAsyncWithHttpInfo(string accessToken, string xeroTenantId, Reimbursement reimbursement, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReimbursementObject> response = await payrollUkXeroClient.CreateReimbursementAsyncWithHttpInfo(accessToken, xeroTenantId, reimbursement, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<TimesheetObject>> CreateTimesheetAsyncWithHttpInfo(Timesheet timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateTimesheetAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, timesheet, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<TimesheetObject>> CreateTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Timesheet timesheet, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TimesheetObject> response = await payrollUkXeroClient.CreateTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheet, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<TimesheetLineObject>> CreateTimesheetLineAsyncWithHttpInfo(Guid timesheetID, TimesheetLine timesheetLine, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateTimesheetLineAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, timesheetID, timesheetLine, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<TimesheetLineObject>> CreateTimesheetLineAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, TimesheetLine timesheetLine, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TimesheetLineObject> response = await payrollUkXeroClient.CreateTimesheetLineAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, timesheetLine, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<BenefitObject> GetBenefitAsync(Guid id, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBenefitAsync(accessToken, xeroExtendedConfiguration.TenantId, id, cancellationToken);
    }



    public async Task<BenefitObject> GetBenefitAsync(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
    {
        ApiResponse<BenefitObject> response = await GetBenefitAsyncWithHttpInfo(accessToken, xeroTenantId, id, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<BenefitObject>> GetBenefitAsyncWithHttpInfo(Guid id, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBenefitAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, id, cancellationToken);
    }



    public async Task<ApiResponse<BenefitObject>> GetBenefitAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
    {
        ApiResponse<BenefitObject> response = await payrollUkXeroClient.GetBenefitAsyncWithHttpInfo(accessToken, xeroTenantId, id, cancellationToken);
        return response;
    }
    public async Task<Benefits> GetBenefitsAsync(int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBenefitsAsync(accessToken, xeroExtendedConfiguration.TenantId, page, cancellationToken);
    }



    public async Task<Benefits> GetBenefitsAsync(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Benefits> response = await GetBenefitsAsyncWithHttpInfo(accessToken, xeroTenantId, page, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<Benefits>> GetBenefitsAsyncWithHttpInfo(int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBenefitsAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, page, cancellationToken);
    }



    public async Task<ApiResponse<Benefits>> GetBenefitsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Benefits> response = await payrollUkXeroClient.GetBenefitsAsyncWithHttpInfo(accessToken, xeroTenantId, page, cancellationToken);
        return response;
    }
    public async Task<EarningsOrderObject> GetEarningsOrderAsync(Guid id, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEarningsOrderAsync(accessToken, xeroExtendedConfiguration.TenantId, id, cancellationToken);
    }



    public async Task<EarningsOrderObject> GetEarningsOrderAsync(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
    {
        ApiResponse<EarningsOrderObject> response = await GetEarningsOrderAsyncWithHttpInfo(accessToken, xeroTenantId, id, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<EarningsOrderObject>> GetEarningsOrderAsyncWithHttpInfo(Guid id, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEarningsOrderAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, id, cancellationToken);
    }



    public async Task<ApiResponse<EarningsOrderObject>> GetEarningsOrderAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid id, CancellationToken cancellationToken = default)
    {
        ApiResponse<EarningsOrderObject> response = await payrollUkXeroClient.GetEarningsOrderAsyncWithHttpInfo(accessToken, xeroTenantId, id, cancellationToken);
        return response;
    }
    public async Task<EarningsOrders> GetEarningsOrdersAsync(int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEarningsOrdersAsync(accessToken, xeroExtendedConfiguration.TenantId, page, cancellationToken);
    }



    public async Task<EarningsOrders> GetEarningsOrdersAsync(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EarningsOrders> response = await GetEarningsOrdersAsyncWithHttpInfo(accessToken, xeroTenantId, page, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<EarningsOrders>> GetEarningsOrdersAsyncWithHttpInfo(int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEarningsOrdersAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, page, cancellationToken);
    }



    public async Task<ApiResponse<EarningsOrders>> GetEarningsOrdersAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EarningsOrders> response = await payrollUkXeroClient.GetEarningsOrdersAsyncWithHttpInfo(accessToken, xeroTenantId, page, cancellationToken);
        return response;
    }
    public async Task<EmployeeLeaveObject> GetEmployeeLeaveAsync(Guid employeeID, Guid leaveID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeeLeaveAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, leaveID, cancellationToken);
    }



    public async Task<EmployeeLeaveObject> GetEmployeeLeaveAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeLeaveObject> response = await GetEmployeeLeaveAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, leaveID, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<EmployeeLeaveObject>> GetEmployeeLeaveAsyncWithHttpInfo(Guid employeeID, Guid leaveID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeeLeaveAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, leaveID, cancellationToken);
    }



    public async Task<ApiResponse<EmployeeLeaveObject>> GetEmployeeLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeLeaveObject> response = await payrollUkXeroClient.GetEmployeeLeaveAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, leaveID, cancellationToken);
        return response;
    }
    public async Task<EmployeePayTemplateObject> GetEmployeePayTemplateAsync(Guid employeeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeePayTemplateAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, cancellationToken);
    }



    public async Task<EmployeePayTemplateObject> GetEmployeePayTemplateAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeePayTemplateObject> response = await GetEmployeePayTemplateAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<EmployeePayTemplateObject>> GetEmployeePayTemplateAsyncWithHttpInfo(Guid employeeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeePayTemplateAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, cancellationToken);
    }



    public async Task<ApiResponse<EmployeePayTemplateObject>> GetEmployeePayTemplateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeePayTemplateObject> response = await payrollUkXeroClient.GetEmployeePayTemplateAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response;
    }
    public async Task<EmployeeStatutoryLeaveBalanceObject> GetEmployeeStatutoryLeaveBalancesAsync(Guid employeeID, string? leaveType = null, DateTime? asOfDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeeStatutoryLeaveBalancesAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, leaveType, asOfDate, cancellationToken);
    }



    public async Task<EmployeeStatutoryLeaveBalanceObject> GetEmployeeStatutoryLeaveBalancesAsync(string accessToken, string xeroTenantId, Guid employeeID, string? leaveType = null, DateTime? asOfDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeStatutoryLeaveBalanceObject> response = await GetEmployeeStatutoryLeaveBalancesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, leaveType, asOfDate, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<EmployeeStatutoryLeaveBalanceObject>> GetEmployeeStatutoryLeaveBalancesAsyncWithHttpInfo(Guid employeeID, string? leaveType = null, DateTime? asOfDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeeStatutoryLeaveBalancesAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, leaveType, asOfDate, cancellationToken);
    }



    public async Task<ApiResponse<EmployeeStatutoryLeaveBalanceObject>> GetEmployeeStatutoryLeaveBalancesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, string? leaveType = null, DateTime? asOfDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeStatutoryLeaveBalanceObject> response = await payrollUkXeroClient.GetEmployeeStatutoryLeaveBalancesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, leaveType, asOfDate, cancellationToken);
        return response;
    }
    public async Task<EmployeeStatutorySickLeaveObject> GetEmployeeStatutorySickLeaveAsync(Guid statutorySickLeaveID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeeStatutorySickLeaveAsync(accessToken, xeroExtendedConfiguration.TenantId, statutorySickLeaveID, cancellationToken);
    }



    public async Task<EmployeeStatutorySickLeaveObject> GetEmployeeStatutorySickLeaveAsync(string accessToken, string xeroTenantId, Guid statutorySickLeaveID, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeStatutorySickLeaveObject> response = await GetEmployeeStatutorySickLeaveAsyncWithHttpInfo(accessToken, xeroTenantId, statutorySickLeaveID, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<EmployeeStatutorySickLeaveObject>> GetEmployeeStatutorySickLeaveAsyncWithHttpInfo(Guid statutorySickLeaveID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeeStatutorySickLeaveAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, statutorySickLeaveID, cancellationToken);
    }



    public async Task<ApiResponse<EmployeeStatutorySickLeaveObject>> GetEmployeeStatutorySickLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid statutorySickLeaveID, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeStatutorySickLeaveObject> response = await payrollUkXeroClient.GetEmployeeStatutorySickLeaveAsyncWithHttpInfo(accessToken, xeroTenantId, statutorySickLeaveID, cancellationToken);
        return response;
    }
    public async Task<EmployeeStatutoryLeavesSummaries> GetStatutoryLeaveSummaryAsync(Guid employeeID, bool? activeOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetStatutoryLeaveSummaryAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, activeOnly, cancellationToken);
    }



    public async Task<EmployeeStatutoryLeavesSummaries> GetStatutoryLeaveSummaryAsync(string accessToken, string xeroTenantId, Guid employeeID, bool? activeOnly = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeStatutoryLeavesSummaries> response = await GetStatutoryLeaveSummaryAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, activeOnly, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<EmployeeStatutoryLeavesSummaries>> GetStatutoryLeaveSummaryAsyncWithHttpInfo(Guid employeeID, bool? activeOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetStatutoryLeaveSummaryAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, activeOnly, cancellationToken);
    }



    public async Task<ApiResponse<EmployeeStatutoryLeavesSummaries>> GetStatutoryLeaveSummaryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, bool? activeOnly = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeStatutoryLeavesSummaries> response = await payrollUkXeroClient.GetStatutoryLeaveSummaryAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, activeOnly, cancellationToken);
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
    public async Task<ApiResponse<EmployeeObject>> UpdateEmployeeAsyncWithHttpInfo(Guid employeeID, Employee employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateEmployeeAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employee, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<EmployeeObject>> UpdateEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Employee employee, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeObject> response = await payrollUkXeroClient.UpdateEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employee, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<EarningsTemplateObject>> UpdateEmployeeEarningsTemplateAsyncWithHttpInfo(Guid employeeID, Guid payTemplateEarningID, EarningsTemplate earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateEmployeeEarningsTemplateAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, payTemplateEarningID, earningsTemplate, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<EarningsTemplateObject>> UpdateEmployeeEarningsTemplateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid payTemplateEarningID, EarningsTemplate earningsTemplate, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EarningsTemplateObject> response = await payrollUkXeroClient.UpdateEmployeeEarningsTemplateAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, payTemplateEarningID, earningsTemplate, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<EmployeeLeaveObject>> UpdateEmployeeLeaveAsyncWithHttpInfo(Guid employeeID, Guid leaveID, EmployeeLeave employeeLeave, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateEmployeeLeaveAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, leaveID, employeeLeave, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<EmployeeLeaveObject>> UpdateEmployeeLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, EmployeeLeave employeeLeave, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeLeaveObject> response = await payrollUkXeroClient.UpdateEmployeeLeaveAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, leaveID, employeeLeave, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<EmployeeOpeningBalancesObject> UpdateEmployeeOpeningBalancesAsync(Guid employeeID, EmployeeOpeningBalances employeeOpeningBalances, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateEmployeeOpeningBalancesAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employeeOpeningBalances, idempotencyKey, cancellationToken);
    }



    public async Task<EmployeeOpeningBalancesObject> UpdateEmployeeOpeningBalancesAsync(string accessToken, string xeroTenantId, Guid employeeID, EmployeeOpeningBalances employeeOpeningBalances, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeOpeningBalancesObject> response = await UpdateEmployeeOpeningBalancesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeOpeningBalances, idempotencyKey, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<EmployeeOpeningBalancesObject>> UpdateEmployeeOpeningBalancesAsyncWithHttpInfo(Guid employeeID, EmployeeOpeningBalances employeeOpeningBalances, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateEmployeeOpeningBalancesAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, employeeOpeningBalances, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<EmployeeOpeningBalancesObject>> UpdateEmployeeOpeningBalancesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, EmployeeOpeningBalances employeeOpeningBalances, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeOpeningBalancesObject> response = await payrollUkXeroClient.UpdateEmployeeOpeningBalancesAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, employeeOpeningBalances, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<SalaryAndWageObject>> UpdateEmployeeSalaryAndWageAsyncWithHttpInfo(Guid employeeID, Guid salaryAndWagesID, SalaryAndWage salaryAndWage, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateEmployeeSalaryAndWageAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, salaryAndWagesID, salaryAndWage, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<SalaryAndWageObject>> UpdateEmployeeSalaryAndWageAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid salaryAndWagesID, SalaryAndWage salaryAndWage, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<SalaryAndWageObject> response = await payrollUkXeroClient.UpdateEmployeeSalaryAndWageAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, salaryAndWagesID, salaryAndWage, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<PayRunObject>> UpdatePayRunAsyncWithHttpInfo(Guid payRunID, PayRun payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdatePayRunAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, payRunID, payRun, idempotencyKey, cancellationToken);
    }



    public async Task<ApiResponse<PayRunObject>> UpdatePayRunAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid payRunID, PayRun payRun, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PayRunObject> response = await payrollUkXeroClient.UpdatePayRunAsyncWithHttpInfo(accessToken, xeroTenantId, payRunID, payRun, idempotencyKey, cancellationToken);
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
    public async Task<ApiResponse<TimesheetLineObject>> UpdateTimesheetLineAsyncWithHttpInfo(Guid timesheetID, Guid timesheetLineID, TimesheetLine timesheetLine, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateTimesheetLineAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, timesheetID, timesheetLineID, timesheetLine, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<TimesheetLineObject>> UpdateTimesheetLineAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, Guid timesheetLineID, TimesheetLine timesheetLine, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TimesheetLineObject> response = await payrollUkXeroClient.UpdateTimesheetLineAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, timesheetLineID, timesheetLine, idempotencyKey, cancellationToken);
        return response;
    }

    Task<TimesheetObject> IPayrollUkApiAsync.ApproveTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, string idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollUkApproveTimesheetAsync(accessToken, xeroTenantId, timesheetID, idempotencyKey, cancellationToken);
    }

    Task<ApiResponse<TimesheetObject>> IPayrollUkApiAsync.ApproveTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, string idempotencyKey, CancellationToken cancellationToken)
    {
        return PayrollUkApproveTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, idempotencyKey, cancellationToken);
    }

    public async Task<TimesheetObject> PayrollUkApproveTimesheetAsync(Guid timesheetID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollUkApproveTimesheetAsync(accessToken, xeroExtendedConfiguration.TenantId, timesheetID, idempotencyKey, cancellationToken);
    }

    public async Task<TimesheetObject> PayrollUkApproveTimesheetAsync(string accessToken, string xeroTenantId, Guid timesheetID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TimesheetObject> response = await PayrollUkApproveTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TimesheetObject>> PayrollUkApproveTimesheetAsyncWithHttpInfo(Guid timesheetID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollUkApproveTimesheetAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, timesheetID, idempotencyKey, cancellationToken);
    }

    public async Task<ApiResponse<TimesheetObject>> PayrollUkApproveTimesheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid timesheetID, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TimesheetObject> response = await payrollUkXeroClient.ApproveTimesheetAsyncWithHttpInfo(accessToken, xeroTenantId, timesheetID, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task DeleteEmployeeEarningsTemplateAsync(Guid employeeID, Guid payTemplateEarningID, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        await PayrollUkDeleteEmployeeEarningsTemplateAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, payTemplateEarningID, cancellationToken);
    }

    async Task IPayrollUkApiAsync.DeleteEmployeeEarningsTemplateAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid payTemplateEarningID, CancellationToken cancellationToken)
    {
        await PayrollUkDeleteEmployeeEarningsTemplateAsync(accessToken, xeroTenantId, employeeID, payTemplateEarningID, cancellationToken);
    }

    // Public methods
    public async Task PayrollUkDeleteEmployeeEarningsTemplateAsync(Guid employeeID, Guid payTemplateEarningID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        await PayrollUkDeleteEmployeeEarningsTemplateAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, payTemplateEarningID, cancellationToken);
    }

    public async Task PayrollUkDeleteEmployeeEarningsTemplateAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid payTemplateEarningID, CancellationToken cancellationToken = default)
    {
        await PayrollUkDeleteEmployeeEarningsTemplateAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, payTemplateEarningID, cancellationToken);
    }

    public async Task<ApiResponse<object>> PayrollUkDeleteEmployeeEarningsTemplateAsyncWithHttpInfo(Guid employeeID, Guid payTemplateEarningID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollUkDeleteEmployeeEarningsTemplateAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, payTemplateEarningID, cancellationToken);
    }

    public async Task<ApiResponse<object>> PayrollUkDeleteEmployeeEarningsTemplateAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid payTemplateEarningID, CancellationToken cancellationToken = default)
    {
        return await payrollUkXeroClient.DeleteEmployeeEarningsTemplateAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, payTemplateEarningID, cancellationToken);
    }
    Task<EmployeeLeaveObject> IPayrollUkApiAsync.DeleteEmployeeLeaveAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, CancellationToken cancellationToken)
    {
        return PayrollUkDeleteEmployeeLeaveAsync(accessToken, xeroTenantId, employeeID, leaveID, cancellationToken);
    }

    Task<ApiResponse<EmployeeLeaveObject>> IPayrollUkApiAsync.DeleteEmployeeLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, CancellationToken cancellationToken)
    {
        return PayrollUkDeleteEmployeeLeaveAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, leaveID, cancellationToken);
    }

    // Public methods
    public async Task<EmployeeLeaveObject> PayrollUkDeleteEmployeeLeaveAsync(Guid employeeID, Guid leaveID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollUkDeleteEmployeeLeaveAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, leaveID, cancellationToken);
    }

    public async Task<EmployeeLeaveObject> PayrollUkDeleteEmployeeLeaveAsync(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeLeaveObject> response = await PayrollUkDeleteEmployeeLeaveAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, leaveID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeLeaveObject>> PayrollUkDeleteEmployeeLeaveAsyncWithHttpInfo(Guid employeeID, Guid leaveID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollUkDeleteEmployeeLeaveAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, leaveID, cancellationToken);
    }

    public async Task<ApiResponse<EmployeeLeaveObject>> PayrollUkDeleteEmployeeLeaveAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, Guid leaveID, CancellationToken cancellationToken = default)
    {
        return await payrollUkXeroClient.DeleteEmployeeLeaveAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, leaveID, cancellationToken);
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
        return PayrollUkGetEmployeeAsync(accessToken, xeroTenantId, employeeID, cancellationToken);
    }

    Task<ApiResponse<EmployeeObject>> IPayrollUkApiAsync.GetEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken)
    {
        return PayrollUkGetEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
    }

    public async Task<EmployeeObject> PayrollUkGetEmployeeAsync(Guid employeeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;
        return await PayrollUkGetEmployeeAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, cancellationToken);
    }

    public async Task<EmployeeObject> PayrollUkGetEmployeeAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeObject> response = await PayrollUkGetEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<EmployeeObject>> PayrollUkGetEmployeeAsyncWithHttpInfo(Guid employeeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PayrollUkGetEmployeeAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, employeeID, cancellationToken);
    }

    public async Task<ApiResponse<EmployeeObject>> PayrollUkGetEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        ApiResponse<EmployeeObject> response = await payrollUkXeroClient.GetEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response;
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

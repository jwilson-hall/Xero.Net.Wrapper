using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Finance;

namespace Xero.Net.Wrapper.Api;

public partial class XeroService : IFinanceApi
{
    public async Task<AccountUsageResponse> GetAccountingActivityAccountUsageAsync(string? startMonth = null, string? endMonth = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAccountingActivityAccountUsageAsync(accessToken, xeroExtendedConfiguration.TenantId, startMonth, endMonth, cancellationToken);
    }

    public async Task<AccountUsageResponse> GetAccountingActivityAccountUsageAsync(string accessToken, string xeroTenantId, string? startMonth = null, string? endMonth = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<AccountUsageResponse> response = await GetAccountingActivityAccountUsageAsyncWithHttpInfo(accessToken, xeroTenantId, startMonth, endMonth, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<AccountUsageResponse>> GetAccountingActivityAccountUsageAsyncWithHttpInfo(string? startMonth = null, string? endMonth = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAccountingActivityAccountUsageAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, startMonth, endMonth, cancellationToken);
    }

    public async Task<ApiResponse<AccountUsageResponse>> GetAccountingActivityAccountUsageAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? startMonth = null, string? endMonth = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<AccountUsageResponse> response = await financeXeroClient.GetAccountingActivityAccountUsageAsyncWithHttpInfo(accessToken, xeroTenantId, startMonth, endMonth, cancellationToken);
        return response;
    }

    public async Task<LockHistoryResponse> GetAccountingActivityLockHistoryAsync(string? endDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAccountingActivityLockHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, endDate, cancellationToken);
    }

    public async Task<LockHistoryResponse> GetAccountingActivityLockHistoryAsync(string accessToken, string xeroTenantId, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LockHistoryResponse> response = await GetAccountingActivityLockHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, endDate, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<LockHistoryResponse>> GetAccountingActivityLockHistoryAsyncWithHttpInfo(string? endDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAccountingActivityLockHistoryAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, endDate, cancellationToken);
    }

    public async Task<ApiResponse<LockHistoryResponse>> GetAccountingActivityLockHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LockHistoryResponse> response = await financeXeroClient.GetAccountingActivityLockHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, endDate, cancellationToken);
        return response;
    }

    public async Task<ReportHistoryResponse> GetAccountingActivityReportHistoryAsync(string? endDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAccountingActivityReportHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, endDate, cancellationToken);
    }

    public async Task<ReportHistoryResponse> GetAccountingActivityReportHistoryAsync(string accessToken, string xeroTenantId, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportHistoryResponse> response = await GetAccountingActivityReportHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, endDate, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<ReportHistoryResponse>> GetAccountingActivityReportHistoryAsyncWithHttpInfo(string? endDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAccountingActivityReportHistoryAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, endDate, cancellationToken);
    }

    public async Task<ApiResponse<ReportHistoryResponse>> GetAccountingActivityReportHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportHistoryResponse> response = await financeXeroClient.GetAccountingActivityReportHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, endDate, cancellationToken);
        return response;
    }

    public async Task<UserActivitiesResponse> GetAccountingActivityUserActivitiesAsync(string? dataMonth = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAccountingActivityUserActivitiesAsync(accessToken, xeroExtendedConfiguration.TenantId, dataMonth, cancellationToken);
    }

    public async Task<UserActivitiesResponse> GetAccountingActivityUserActivitiesAsync(string accessToken, string xeroTenantId, string? dataMonth = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<UserActivitiesResponse> response = await GetAccountingActivityUserActivitiesAsyncWithHttpInfo(accessToken, xeroTenantId, dataMonth, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<UserActivitiesResponse>> GetAccountingActivityUserActivitiesAsyncWithHttpInfo(string? dataMonth = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAccountingActivityUserActivitiesAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, dataMonth, cancellationToken);
    }

    public async Task<ApiResponse<UserActivitiesResponse>> GetAccountingActivityUserActivitiesAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? dataMonth = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<UserActivitiesResponse> response = await financeXeroClient.GetAccountingActivityUserActivitiesAsyncWithHttpInfo(accessToken, xeroTenantId, dataMonth, cancellationToken);
        return response;
    }

    public async Task<BankStatementAccountingResponse> GetBankStatementAccountingAsync(Guid bankAccountID, string fromDate, string toDate, bool? summaryOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBankStatementAccountingAsync(accessToken, xeroExtendedConfiguration.TenantId, bankAccountID, fromDate, toDate, summaryOnly, cancellationToken);
    }

    public async Task<BankStatementAccountingResponse> GetBankStatementAccountingAsync(string accessToken, string xeroTenantId, Guid bankAccountID, string fromDate, string toDate, bool? summaryOnly = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BankStatementAccountingResponse> response = await GetBankStatementAccountingAsyncWithHttpInfo(accessToken, xeroTenantId, bankAccountID, fromDate, toDate, summaryOnly, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<BankStatementAccountingResponse>> GetBankStatementAccountingAsyncWithHttpInfo(Guid bankAccountID, string fromDate, string toDate, bool? summaryOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBankStatementAccountingAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, bankAccountID, fromDate, toDate, summaryOnly, cancellationToken);
    }

    public async Task<ApiResponse<BankStatementAccountingResponse>> GetBankStatementAccountingAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankAccountID, string fromDate, string toDate, bool? summaryOnly = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BankStatementAccountingResponse> response = await financeXeroClient.GetBankStatementAccountingAsyncWithHttpInfo(accessToken, xeroTenantId, bankAccountID, fromDate, toDate, summaryOnly, cancellationToken);
        return response;
    }

    public async Task<List<CashValidationResponse>> GetCashValidationAsync(string? balanceDate = null, string? asAtSystemDate = null, string? beginDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetCashValidationAsync(accessToken, xeroExtendedConfiguration.TenantId, balanceDate, asAtSystemDate, beginDate, cancellationToken);
    }

    public async Task<List<CashValidationResponse>> GetCashValidationAsync(string accessToken, string xeroTenantId, string? balanceDate = null, string? asAtSystemDate = null, string? beginDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<List<CashValidationResponse>> response = await GetCashValidationAsyncWithHttpInfo(accessToken, xeroTenantId, balanceDate, asAtSystemDate, beginDate, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<List<CashValidationResponse>>> GetCashValidationAsyncWithHttpInfo(string? balanceDate = null, string? asAtSystemDate = null, string? beginDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetCashValidationAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, balanceDate, asAtSystemDate, beginDate, cancellationToken);
    }

    public async Task<ApiResponse<List<CashValidationResponse>>> GetCashValidationAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? balanceDate = null, string? asAtSystemDate = null, string? beginDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<List<CashValidationResponse>> response = await financeXeroClient.GetCashValidationAsyncWithHttpInfo(accessToken, xeroTenantId, balanceDate, asAtSystemDate, beginDate, cancellationToken);
        return response;
    }
    public async Task<BalanceSheetResponse> GetFinancialStatementBalanceSheetAsync(string? balanceDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFinancialStatementBalanceSheetAsync(accessToken, xeroExtendedConfiguration.TenantId, balanceDate, cancellationToken);
    }

    public async Task<BalanceSheetResponse> GetFinancialStatementBalanceSheetAsync(string accessToken, string xeroTenantId, string? balanceDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BalanceSheetResponse> response = await GetFinancialStatementBalanceSheetAsyncWithHttpInfo(accessToken, xeroTenantId, balanceDate, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<BalanceSheetResponse>> GetFinancialStatementBalanceSheetAsyncWithHttpInfo(string? balanceDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFinancialStatementBalanceSheetAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, balanceDate, cancellationToken);
    }

    public async Task<ApiResponse<BalanceSheetResponse>> GetFinancialStatementBalanceSheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? balanceDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BalanceSheetResponse> response = await financeXeroClient.GetFinancialStatementBalanceSheetAsyncWithHttpInfo(accessToken, xeroTenantId, balanceDate, cancellationToken);
        return response;
    }
    public async Task<CashflowResponse> GetFinancialStatementCashflowAsync(string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFinancialStatementCashflowAsync(accessToken, xeroExtendedConfiguration.TenantId, startDate, endDate, cancellationToken);
    }

    public async Task<CashflowResponse> GetFinancialStatementCashflowAsync(string accessToken, string xeroTenantId, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<CashflowResponse> response = await GetFinancialStatementCashflowAsyncWithHttpInfo(accessToken, xeroTenantId, startDate, endDate, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<CashflowResponse>> GetFinancialStatementCashflowAsyncWithHttpInfo(string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFinancialStatementCashflowAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, startDate, endDate, cancellationToken);
    }

    public async Task<ApiResponse<CashflowResponse>> GetFinancialStatementCashflowAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<CashflowResponse> response = await financeXeroClient.GetFinancialStatementCashflowAsyncWithHttpInfo(accessToken, xeroTenantId, startDate, endDate, cancellationToken);
        return response;
    }
    public async Task<IncomeByContactResponse> GetFinancialStatementContactsExpenseAsync(List<Guid>? contactIds = null, bool? includeManualJournals = null, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFinancialStatementContactsExpenseAsync(accessToken, xeroExtendedConfiguration.TenantId, contactIds, includeManualJournals, startDate, endDate, cancellationToken);
    }

    public async Task<IncomeByContactResponse> GetFinancialStatementContactsExpenseAsync(string accessToken, string xeroTenantId, List<Guid>? contactIds = null, bool? includeManualJournals = null, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<IncomeByContactResponse> response = await GetFinancialStatementContactsExpenseAsyncWithHttpInfo(accessToken, xeroTenantId, contactIds, includeManualJournals, startDate, endDate, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<IncomeByContactResponse>> GetFinancialStatementContactsExpenseAsyncWithHttpInfo(List<Guid>? contactIds = null, bool? includeManualJournals = null, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFinancialStatementContactsExpenseAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, contactIds, includeManualJournals, startDate, endDate, cancellationToken);
    }

    public async Task<ApiResponse<IncomeByContactResponse>> GetFinancialStatementContactsExpenseAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<Guid>? contactIds = null, bool? includeManualJournals = null, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<IncomeByContactResponse> response = await financeXeroClient.GetFinancialStatementContactsExpenseAsyncWithHttpInfo(accessToken, xeroTenantId, contactIds, includeManualJournals, startDate, endDate, cancellationToken);
        return response;
    }

    public async Task<IncomeByContactResponse> GetFinancialStatementContactsRevenueAsync(List<Guid>? contactIds = null, bool? includeManualJournals = null, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFinancialStatementContactsRevenueAsync(accessToken, xeroExtendedConfiguration.TenantId, contactIds, includeManualJournals, startDate, endDate, cancellationToken);
    }

    public async Task<IncomeByContactResponse> GetFinancialStatementContactsRevenueAsync(string accessToken, string xeroTenantId, List<Guid>? contactIds = null, bool? includeManualJournals = null, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<IncomeByContactResponse> response = await GetFinancialStatementContactsRevenueAsyncWithHttpInfo(accessToken, xeroTenantId, contactIds, includeManualJournals, startDate, endDate, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<IncomeByContactResponse>> GetFinancialStatementContactsRevenueAsyncWithHttpInfo(List<Guid>? contactIds = null, bool? includeManualJournals = null, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFinancialStatementContactsRevenueAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, contactIds, includeManualJournals, startDate, endDate, cancellationToken);
    }

    public async Task<ApiResponse<IncomeByContactResponse>> GetFinancialStatementContactsRevenueAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<Guid>? contactIds = null, bool? includeManualJournals = null, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<IncomeByContactResponse> response = await financeXeroClient.GetFinancialStatementContactsRevenueAsyncWithHttpInfo(accessToken, xeroTenantId, contactIds, includeManualJournals, startDate, endDate, cancellationToken);
        return response;
    }
    public async Task<ProfitAndLossResponse> GetFinancialStatementProfitAndLossAsync(string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFinancialStatementProfitAndLossAsync(accessToken, xeroExtendedConfiguration.TenantId, startDate, endDate, cancellationToken);
    }

    public async Task<ProfitAndLossResponse> GetFinancialStatementProfitAndLossAsync(string accessToken, string xeroTenantId, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ProfitAndLossResponse> response = await GetFinancialStatementProfitAndLossAsyncWithHttpInfo(accessToken, xeroTenantId, startDate, endDate, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<ProfitAndLossResponse>> GetFinancialStatementProfitAndLossAsyncWithHttpInfo(string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFinancialStatementProfitAndLossAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, startDate, endDate, cancellationToken);
    }

    public async Task<ApiResponse<ProfitAndLossResponse>> GetFinancialStatementProfitAndLossAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ProfitAndLossResponse> response = await financeXeroClient.GetFinancialStatementProfitAndLossAsyncWithHttpInfo(accessToken, xeroTenantId, startDate, endDate, cancellationToken);
        return response;
    }
    public async Task<TrialBalanceResponse> GetFinancialStatementTrialBalanceAsync(string? endDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFinancialStatementTrialBalanceAsync(accessToken, xeroExtendedConfiguration.TenantId, endDate, cancellationToken);
    }

    public async Task<TrialBalanceResponse> GetFinancialStatementTrialBalanceAsync(string accessToken, string xeroTenantId, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TrialBalanceResponse> response = await GetFinancialStatementTrialBalanceAsyncWithHttpInfo(accessToken, xeroTenantId, endDate, cancellationToken);
        return response.Data;
    }
    public async Task<ApiResponse<TrialBalanceResponse>> GetFinancialStatementTrialBalanceAsyncWithHttpInfo(string? endDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetFinancialStatementTrialBalanceAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, endDate, cancellationToken);
    }

    public async Task<ApiResponse<TrialBalanceResponse>> GetFinancialStatementTrialBalanceAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? endDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TrialBalanceResponse> response = await financeXeroClient.GetFinancialStatementTrialBalanceAsyncWithHttpInfo(accessToken, xeroTenantId, endDate, cancellationToken);
        return response;
    }
}

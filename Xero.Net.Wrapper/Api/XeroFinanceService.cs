using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Finance;

public partial class XeroService : IFinanceApi
{
    public Task<AccountUsageResponse> GetAccountingActivityAccountUsageAsync(string accessToken, string xeroTenantId, string? startMonth = null, string? endMonth = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<AccountUsageResponse>> GetAccountingActivityAccountUsageAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? startMonth = null, string? endMonth = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<LockHistoryResponse> GetAccountingActivityLockHistoryAsync(string accessToken, string xeroTenantId, string? endDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<LockHistoryResponse>> GetAccountingActivityLockHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? endDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ReportHistoryResponse> GetAccountingActivityReportHistoryAsync(string accessToken, string xeroTenantId, string? endDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ReportHistoryResponse>> GetAccountingActivityReportHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? endDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<UserActivitiesResponse> GetAccountingActivityUserActivitiesAsync(string accessToken, string xeroTenantId, string? dataMonth = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<UserActivitiesResponse>> GetAccountingActivityUserActivitiesAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? dataMonth = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<BankStatementAccountingResponse> GetBankStatementAccountingAsync(string accessToken, string xeroTenantId, Guid bankAccountID, string fromDate, string toDate, bool? summaryOnly = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BankStatementAccountingResponse>> GetBankStatementAccountingAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankAccountID, string fromDate, string toDate, bool? summaryOnly = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<List<CashValidationResponse>> GetCashValidationAsync(string accessToken, string xeroTenantId, string? balanceDate = null, string? asAtSystemDate = null, string? beginDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<List<CashValidationResponse>>> GetCashValidationAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? balanceDate = null, string? asAtSystemDate = null, string? beginDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<BalanceSheetResponse> GetFinancialStatementBalanceSheetAsync(string accessToken, string xeroTenantId, string? balanceDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BalanceSheetResponse>> GetFinancialStatementBalanceSheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? balanceDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<CashflowResponse> GetFinancialStatementCashflowAsync(string accessToken, string xeroTenantId, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<CashflowResponse>> GetFinancialStatementCashflowAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IncomeByContactResponse> GetFinancialStatementContactsExpenseAsync(string accessToken, string xeroTenantId, List<Guid>? contactIds = null, bool? includeManualJournals = null, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<IncomeByContactResponse>> GetFinancialStatementContactsExpenseAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<Guid>? contactIds = null, bool? includeManualJournals = null, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IncomeByContactResponse> GetFinancialStatementContactsRevenueAsync(string accessToken, string xeroTenantId, List<Guid>? contactIds = null, bool? includeManualJournals = null, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<IncomeByContactResponse>> GetFinancialStatementContactsRevenueAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<Guid>? contactIds = null, bool? includeManualJournals = null, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ProfitAndLossResponse> GetFinancialStatementProfitAndLossAsync(string accessToken, string xeroTenantId, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ProfitAndLossResponse>> GetFinancialStatementProfitAndLossAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TrialBalanceResponse> GetFinancialStatementTrialBalanceAsync(string accessToken, string xeroTenantId, string? endDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TrialBalanceResponse>> GetFinancialStatementTrialBalanceAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? endDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}

using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Accounting;

namespace Xero.Net.Wrapper.Api;
public partial class XeroService : IAccountingApi
{
    public IReadableConfiguration Configuration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public ExceptionFactory ExceptionFactory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public async Task<Accounts> CreateAccountAsync(Account account, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateAccountAsync(accessToken, xeroExtendedConfiguration.TenantId, account, idempotencyKey, cancellationToken);
    }

    public async Task<Accounts> CreateAccountAsync(string accessToken, string xeroTenantId, Account account, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Accounts> response = await CreateAccountAsyncWithHttpInfo(accessToken, xeroTenantId, account, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Accounts>> CreateAccountAsyncWithHttpInfo(Account account, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await accountingXeroClient.CreateAccountAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, account, idempotencyKey, cancellationToken);
    }

    public Task<ApiResponse<Accounts>> CreateAccountAsyncWithHttpInfo(string accessToken, string xeroTenantId, Account account, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateAccountAsyncWithHttpInfo(accessToken, xeroTenantId, account, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateAccountAttachmentByFileNameAsync(Guid accountID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateAccountAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, accountID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateAccountAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid accountID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await CreateAccountAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, accountID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Attachments>> CreateAccountAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid accountID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateAccountAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, accountID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateBankTransactionAttachmentByFileNameAsync(Guid bankTransactionID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateBankTransactionAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransactionID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateBankTransactionAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid bankTransactionID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await CreateBankTransactionAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactionID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Attachments>> CreateBankTransactionAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransactionID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateBankTransactionAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactionID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateBankTransactionHistoryRecordAsync(Guid bankTransactionID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateBankTransactionHistoryRecordAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransactionID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateBankTransactionHistoryRecordAsync(string accessToken, string xeroTenantId, Guid bankTransactionID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await CreateBankTransactionHistoryRecordAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactionID, historyRecords, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<HistoryRecords>> CreateBankTransactionHistoryRecordAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransactionID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateBankTransactionHistoryRecordAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactionID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<BankTransactions> CreateBankTransactionsAsync(BankTransactions bankTransactions, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateBankTransactionsAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransactions, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<BankTransactions> CreateBankTransactionsAsync(string accessToken, string xeroTenantId, BankTransactions bankTransactions, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BankTransactions> response = await CreateBankTransactionsAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactions, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<BankTransactions>> CreateBankTransactionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, BankTransactions bankTransactions, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateBankTransactionsAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactions, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<BankTransfers> CreateBankTransferAsync(BankTransfers bankTransfers, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateBankTransferAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransfers, idempotencyKey, cancellationToken);
    }

    public async Task<BankTransfers> CreateBankTransferAsync(string accessToken, string xeroTenantId, BankTransfers bankTransfers, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BankTransfers> response = await CreateBankTransferAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransfers, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<BankTransfers>> CreateBankTransferAsyncWithHttpInfo(string accessToken, string xeroTenantId, BankTransfers bankTransfers, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateBankTransferAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransfers, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateBankTransferAttachmentByFileNameAsync(Guid bankTransferID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateBankTransferAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransferID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateBankTransferAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid bankTransferID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await CreateBankTransferAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransferID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Attachments>> CreateBankTransferAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransferID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateBankTransferAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransferID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateBankTransferHistoryRecordAsync(Guid bankTransferID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateBankTransferHistoryRecordAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransferID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateBankTransferHistoryRecordAsync(string accessToken, string xeroTenantId, Guid bankTransferID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await CreateBankTransferHistoryRecordAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransferID, historyRecords, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<HistoryRecords>> CreateBankTransferHistoryRecordAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransferID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateBankTransferHistoryRecordAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransferID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<BatchPayments> CreateBatchPaymentAsync(BatchPayments batchPayments, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateBatchPaymentAsync(accessToken, xeroExtendedConfiguration.TenantId, batchPayments, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<BatchPayments> CreateBatchPaymentAsync(string accessToken, string xeroTenantId, BatchPayments batchPayments, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BatchPayments> response = await CreateBatchPaymentAsyncWithHttpInfo(accessToken, xeroTenantId, batchPayments, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<BatchPayments>> CreateBatchPaymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, BatchPayments batchPayments, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateBatchPaymentAsyncWithHttpInfo(accessToken, xeroTenantId, batchPayments, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateBatchPaymentHistoryRecordAsync(Guid batchPaymentID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateBatchPaymentHistoryRecordAsync(accessToken, xeroExtendedConfiguration.TenantId, batchPaymentID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateBatchPaymentHistoryRecordAsync(string accessToken, string xeroTenantId, Guid batchPaymentID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await CreateBatchPaymentHistoryRecordAsyncWithHttpInfo(accessToken, xeroTenantId, batchPaymentID, historyRecords, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<HistoryRecords>> CreateBatchPaymentHistoryRecordAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid batchPaymentID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateBatchPaymentHistoryRecordAsyncWithHttpInfo(accessToken, xeroTenantId, batchPaymentID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<PaymentServices> CreateBrandingThemePaymentServicesAsync(Guid brandingThemeID, PaymentServices paymentServices, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateBrandingThemePaymentServicesAsync(accessToken, xeroExtendedConfiguration.TenantId, brandingThemeID, paymentServices, idempotencyKey, cancellationToken);
    }

    public async Task<PaymentServices> CreateBrandingThemePaymentServicesAsync(string accessToken, string xeroTenantId, Guid brandingThemeID, PaymentServices paymentServices, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PaymentServices> response = await CreateBrandingThemePaymentServicesAsyncWithHttpInfo(accessToken, xeroTenantId, brandingThemeID, paymentServices, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<PaymentServices>> CreateBrandingThemePaymentServicesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid brandingThemeID, PaymentServices paymentServices, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateBrandingThemePaymentServicesAsyncWithHttpInfo(accessToken, xeroTenantId, brandingThemeID, paymentServices, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateContactAttachmentByFileNameAsync(Guid contactID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateContactAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, contactID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateContactAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid contactID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await CreateContactAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Attachments>> CreateContactAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateContactAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<ContactGroups> CreateContactGroupAsync(ContactGroups contactGroups, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateContactGroupAsync(accessToken, xeroExtendedConfiguration.TenantId, contactGroups, idempotencyKey, cancellationToken);
    }

    public async Task<ContactGroups> CreateContactGroupAsync(string accessToken, string xeroTenantId, ContactGroups contactGroups, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ContactGroups> response = await CreateContactGroupAsyncWithHttpInfo(accessToken, xeroTenantId, contactGroups, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<ContactGroups>> CreateContactGroupAsyncWithHttpInfo(string accessToken, string xeroTenantId, ContactGroups contactGroups, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateContactGroupAsyncWithHttpInfo(accessToken, xeroTenantId, contactGroups, idempotencyKey, cancellationToken);
    }

    public async Task<Contacts> CreateContactGroupContactsAsync(Guid contactGroupID, Contacts contacts, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateContactGroupContactsAsync(accessToken, xeroExtendedConfiguration.TenantId, contactGroupID, contacts, idempotencyKey, cancellationToken);
    }

    public async Task<Contacts> CreateContactGroupContactsAsync(string accessToken, string xeroTenantId, Guid contactGroupID, Contacts contacts, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Contacts> response = await CreateContactGroupContactsAsyncWithHttpInfo(accessToken, xeroTenantId, contactGroupID, contacts, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Contacts>> CreateContactGroupContactsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactGroupID, Contacts contacts, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateContactGroupContactsAsyncWithHttpInfo(accessToken, xeroTenantId, contactGroupID, contacts, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateContactHistoryAsync(Guid contactID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateContactHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, contactID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateContactHistoryAsync(string accessToken, string xeroTenantId, Guid contactID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await CreateContactHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, historyRecords, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<HistoryRecords>> CreateContactHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateContactHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<Contacts> CreateContactsAsync(Contacts contacts, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateContactsAsync(accessToken, xeroExtendedConfiguration.TenantId, contacts, summarizeErrors, idempotencyKey, cancellationToken);
    }
    public async Task<Contacts> CreateContactsAsync(string accessToken, string xeroTenantId, Contacts contacts, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Contacts> response = await CreateContactsAsyncWithHttpInfo(accessToken, xeroTenantId, contacts, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Contacts>> CreateContactsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Contacts contacts, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateContactsAsyncWithHttpInfo(accessToken, xeroTenantId, contacts, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<Allocations> CreateCreditNoteAllocationAsync(Guid creditNoteID, Allocations allocations, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateCreditNoteAllocationAsync(accessToken, xeroExtendedConfiguration.TenantId, creditNoteID, allocations, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<Allocations> CreateCreditNoteAllocationAsync(string accessToken, string xeroTenantId, Guid creditNoteID, Allocations allocations, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Allocations> response = await CreateCreditNoteAllocationAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, allocations, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Allocations>> CreateCreditNoteAllocationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, Allocations allocations, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateCreditNoteAllocationAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, allocations, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateCreditNoteAttachmentByFileNameAsync(Guid creditNoteID, string fileName, byte[] body, bool? includeOnline = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateCreditNoteAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, creditNoteID, fileName, body, includeOnline, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateCreditNoteAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid creditNoteID, string fileName, byte[] body, bool? includeOnline = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await CreateCreditNoteAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, fileName, body, includeOnline, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Attachments>> CreateCreditNoteAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, string fileName, byte[] body, bool? includeOnline = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateCreditNoteAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, fileName, body, includeOnline, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateCreditNoteHistoryAsync(Guid creditNoteID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateCreditNoteHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, creditNoteID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateCreditNoteHistoryAsync(string accessToken, string xeroTenantId, Guid creditNoteID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await CreateCreditNoteHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, historyRecords, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<HistoryRecords>> CreateCreditNoteHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateCreditNoteHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<CreditNotes> CreateCreditNotesAsync(CreditNotes creditNotes, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateCreditNotesAsync(accessToken, xeroExtendedConfiguration.TenantId, creditNotes, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<CreditNotes> CreateCreditNotesAsync(string accessToken, string xeroTenantId, CreditNotes creditNotes, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<CreditNotes> response = await CreateCreditNotesAsyncWithHttpInfo(accessToken, xeroTenantId, creditNotes, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<CreditNotes>> CreateCreditNotesAsyncWithHttpInfo(string accessToken, string xeroTenantId, CreditNotes creditNotes, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateCreditNotesAsyncWithHttpInfo(accessToken, xeroTenantId, creditNotes, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<Currencies> CreateCurrencyAsync(Currency currency, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateCurrencyAsync(accessToken, xeroExtendedConfiguration.TenantId, currency, idempotencyKey, cancellationToken);
    }

    public async Task<Currencies> CreateCurrencyAsync(string accessToken, string xeroTenantId, Currency currency, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Currencies> response = await CreateCurrencyAsyncWithHttpInfo(accessToken, xeroTenantId, currency, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Currencies>> CreateCurrencyAsyncWithHttpInfo(string accessToken, string xeroTenantId, Currency currency, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateCurrencyAsyncWithHttpInfo(accessToken, xeroTenantId, currency, idempotencyKey, cancellationToken);
    }

    public async Task<Employees> CreateEmployeesAsync(Employees employees, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateEmployeesAsync(accessToken, xeroExtendedConfiguration.TenantId, employees, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<Employees> CreateEmployeesAsync(string accessToken, string xeroTenantId, Employees employees, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await CreateEmployeesAsyncWithHttpInfo(accessToken, xeroTenantId, employees, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Employees>> CreateEmployeesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Employees employees, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateEmployeesAsyncWithHttpInfo(accessToken, xeroTenantId, employees, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateExpenseClaimHistoryAsync(Guid expenseClaimID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateExpenseClaimHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, expenseClaimID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateExpenseClaimHistoryAsync(string accessToken, string xeroTenantId, Guid expenseClaimID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await CreateExpenseClaimHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, expenseClaimID, historyRecords, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<HistoryRecords>> CreateExpenseClaimHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid expenseClaimID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateExpenseClaimHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, expenseClaimID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<ExpenseClaims> CreateExpenseClaimsAsync(ExpenseClaims expenseClaims, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateExpenseClaimsAsync(accessToken, xeroExtendedConfiguration.TenantId, expenseClaims, idempotencyKey, cancellationToken);
    }

    public async Task<ExpenseClaims> CreateExpenseClaimsAsync(string accessToken, string xeroTenantId, ExpenseClaims expenseClaims, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ExpenseClaims> response = await CreateExpenseClaimsAsyncWithHttpInfo(accessToken, xeroTenantId, expenseClaims, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<ExpenseClaims>> CreateExpenseClaimsAsyncWithHttpInfo(string accessToken, string xeroTenantId, ExpenseClaims expenseClaims, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateExpenseClaimsAsyncWithHttpInfo(accessToken, xeroTenantId, expenseClaims, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateInvoiceAttachmentByFileNameAsync(Guid invoiceID, string fileName, byte[] body, bool? includeOnline = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateInvoiceAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, invoiceID, fileName, body, includeOnline, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateInvoiceAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid invoiceID, string fileName, byte[] body, bool? includeOnline = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await CreateInvoiceAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, fileName, body, includeOnline, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Attachments>> CreateInvoiceAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, string fileName, byte[] body, bool? includeOnline = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateInvoiceAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, fileName, body, includeOnline, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateInvoiceHistoryAsync(Guid invoiceID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateInvoiceHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, invoiceID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateInvoiceHistoryAsync(string accessToken, string xeroTenantId, Guid invoiceID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await CreateInvoiceHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, historyRecords, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<HistoryRecords>> CreateInvoiceHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateInvoiceHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<Invoices> CreateInvoicesAsync(Invoices invoices, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateInvoicesAsync(accessToken, xeroExtendedConfiguration.TenantId, invoices, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<Invoices> CreateInvoicesAsync(string accessToken, string xeroTenantId, Invoices invoices, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Invoices> response = await CreateInvoicesAsyncWithHttpInfo(accessToken, xeroTenantId, invoices, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Invoices>> CreateInvoicesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Invoices invoices, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Invoices> response = await accountingXeroClient.CreateInvoicesAsyncWithHttpInfo(accessToken, xeroTenantId, invoices, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<HistoryRecords> CreateItemHistoryAsync(Guid itemID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateItemHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, itemID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateItemHistoryAsync(string accessToken, string xeroTenantId, Guid itemID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await CreateItemHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, itemID, historyRecords, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<HistoryRecords>> CreateItemHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid itemID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateItemHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, itemID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<Items> CreateItemsAsync(Items items, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateItemsAsync(accessToken, xeroExtendedConfiguration.TenantId, items, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<Items> CreateItemsAsync(string accessToken, string xeroTenantId, Items items, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Items> response = await CreateItemsAsyncWithHttpInfo(accessToken, xeroTenantId, items, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Items>> CreateItemsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Items items, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateItemsAsyncWithHttpInfo(accessToken, xeroTenantId, items, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<LinkedTransactions> CreateLinkedTransactionAsync(LinkedTransaction linkedTransaction, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateLinkedTransactionAsync(accessToken, xeroExtendedConfiguration.TenantId, linkedTransaction, idempotencyKey, cancellationToken);
    }

    public async Task<LinkedTransactions> CreateLinkedTransactionAsync(string accessToken, string xeroTenantId, LinkedTransaction linkedTransaction, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LinkedTransactions> response = await CreateLinkedTransactionAsyncWithHttpInfo(accessToken, xeroTenantId, linkedTransaction, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<LinkedTransactions>> CreateLinkedTransactionAsyncWithHttpInfo(string accessToken, string xeroTenantId, LinkedTransaction linkedTransaction, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateLinkedTransactionAsyncWithHttpInfo(accessToken, xeroTenantId, linkedTransaction, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateManualJournalAttachmentByFileNameAsync(Guid manualJournalID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateManualJournalAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, manualJournalID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateManualJournalAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid manualJournalID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await CreateManualJournalAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournalID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Attachments>> CreateManualJournalAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid manualJournalID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateManualJournalAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournalID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateManualJournalHistoryRecordAsync(Guid manualJournalID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateManualJournalHistoryRecordAsync(accessToken, xeroExtendedConfiguration.TenantId, manualJournalID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateManualJournalHistoryRecordAsync(string accessToken, string xeroTenantId, Guid manualJournalID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await CreateManualJournalHistoryRecordAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournalID, historyRecords, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<HistoryRecords>> CreateManualJournalHistoryRecordAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid manualJournalID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateManualJournalHistoryRecordAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournalID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<ManualJournals> CreateManualJournalsAsync(ManualJournals manualJournals, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateManualJournalsAsync(accessToken, xeroExtendedConfiguration.TenantId, manualJournals, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<ManualJournals> CreateManualJournalsAsync(string accessToken, string xeroTenantId, ManualJournals manualJournals, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ManualJournals> response = await CreateManualJournalsAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournals, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<ManualJournals>> CreateManualJournalsAsyncWithHttpInfo(string accessToken, string xeroTenantId, ManualJournals manualJournals, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateManualJournalsAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournals, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<Allocations> CreateOverpaymentAllocationsAsync(Guid overpaymentID, Allocations allocations, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateOverpaymentAllocationsAsync(accessToken, xeroExtendedConfiguration.TenantId, overpaymentID, allocations, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<Allocations> CreateOverpaymentAllocationsAsync(string accessToken, string xeroTenantId, Guid overpaymentID, Allocations allocations, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Allocations> response = await CreateOverpaymentAllocationsAsyncWithHttpInfo(accessToken, xeroTenantId, overpaymentID, allocations, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Allocations>> CreateOverpaymentAllocationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid overpaymentID, Allocations allocations, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateOverpaymentAllocationsAsyncWithHttpInfo(accessToken, xeroTenantId, overpaymentID, allocations, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateOverpaymentHistoryAsync(Guid overpaymentID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateOverpaymentHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, overpaymentID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateOverpaymentHistoryAsync(string accessToken, string xeroTenantId, Guid overpaymentID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await CreateOverpaymentHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, overpaymentID, historyRecords, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<HistoryRecords>> CreateOverpaymentHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid overpaymentID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateOverpaymentHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, overpaymentID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<Payments> CreatePaymentAsync(Payment payment, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreatePaymentAsync(accessToken, xeroExtendedConfiguration.TenantId, payment, idempotencyKey, cancellationToken);
    }

    public async Task<Payments> CreatePaymentAsync(string accessToken, string xeroTenantId, Payment payment, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Payments> response = await CreatePaymentAsyncWithHttpInfo(accessToken, xeroTenantId, payment, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Payments>> CreatePaymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, Payment payment, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreatePaymentAsyncWithHttpInfo(accessToken, xeroTenantId, payment, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreatePaymentHistoryAsync(Guid paymentID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreatePaymentHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, paymentID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreatePaymentHistoryAsync(string accessToken, string xeroTenantId, Guid paymentID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await CreatePaymentHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, paymentID, historyRecords, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<HistoryRecords>> CreatePaymentHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid paymentID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreatePaymentHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, paymentID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<Payments> CreatePaymentsAsync(Payments payments, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreatePaymentsAsync(accessToken, xeroExtendedConfiguration.TenantId, payments, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<Payments> CreatePaymentsAsync(string accessToken, string xeroTenantId, Payments payments, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Payments> response = await CreatePaymentsAsyncWithHttpInfo(accessToken, xeroTenantId, payments, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Payments>> CreatePaymentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Payments payments, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreatePaymentsAsyncWithHttpInfo(accessToken, xeroTenantId, payments, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<PaymentServices> CreatePaymentServiceAsync(PaymentServices paymentServices, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreatePaymentServiceAsync(accessToken, xeroExtendedConfiguration.TenantId, paymentServices, idempotencyKey, cancellationToken);
    }

    public async Task<PaymentServices> CreatePaymentServiceAsync(string accessToken, string xeroTenantId, PaymentServices paymentServices, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PaymentServices> response = await CreatePaymentServiceAsyncWithHttpInfo(accessToken, xeroTenantId, paymentServices, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<PaymentServices>> CreatePaymentServiceAsyncWithHttpInfo(string accessToken, string xeroTenantId, PaymentServices paymentServices, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreatePaymentServiceAsyncWithHttpInfo(accessToken, xeroTenantId, paymentServices, idempotencyKey, cancellationToken);
    }

    public async Task<Allocations> CreatePrepaymentAllocationsAsync(Guid prepaymentID, Allocations allocations, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreatePrepaymentAllocationsAsync(accessToken, xeroExtendedConfiguration.TenantId, prepaymentID, allocations, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<Allocations> CreatePrepaymentAllocationsAsync(string accessToken, string xeroTenantId, Guid prepaymentID, Allocations allocations, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Allocations> response = await CreatePrepaymentAllocationsAsyncWithHttpInfo(accessToken, xeroTenantId, prepaymentID, allocations, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Allocations>> CreatePrepaymentAllocationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid prepaymentID, Allocations allocations, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreatePrepaymentAllocationsAsyncWithHttpInfo(accessToken, xeroTenantId, prepaymentID, allocations, summarizeErrors, idempotencyKey, cancellationToken);
    }
    public async Task<HistoryRecords> CreatePrepaymentHistoryAsync(Guid prepaymentID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreatePrepaymentHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, prepaymentID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreatePrepaymentHistoryAsync(string accessToken, string xeroTenantId, Guid prepaymentID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await CreatePrepaymentHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, prepaymentID, historyRecords, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<HistoryRecords>> CreatePrepaymentHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid prepaymentID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreatePrepaymentHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, prepaymentID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreatePurchaseOrderAttachmentByFileNameAsync(Guid purchaseOrderID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreatePurchaseOrderAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, purchaseOrderID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreatePurchaseOrderAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid purchaseOrderID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await CreatePurchaseOrderAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Attachments>> CreatePurchaseOrderAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid purchaseOrderID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreatePurchaseOrderAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreatePurchaseOrderHistoryAsync(Guid purchaseOrderID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreatePurchaseOrderHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, purchaseOrderID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreatePurchaseOrderHistoryAsync(string accessToken, string xeroTenantId, Guid purchaseOrderID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await CreatePurchaseOrderHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, historyRecords, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<HistoryRecords>> CreatePurchaseOrderHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid purchaseOrderID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreatePurchaseOrderHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<PurchaseOrders> CreatePurchaseOrdersAsync(PurchaseOrders purchaseOrders, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreatePurchaseOrdersAsync(accessToken, xeroExtendedConfiguration.TenantId, purchaseOrders, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<PurchaseOrders> CreatePurchaseOrdersAsync(string accessToken, string xeroTenantId, PurchaseOrders purchaseOrders, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PurchaseOrders> response = await CreatePurchaseOrdersAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrders, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PurchaseOrders>> CreatePurchaseOrdersAsyncWithHttpInfo(string accessToken, string xeroTenantId, PurchaseOrders purchaseOrders, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PurchaseOrders> response = await accountingXeroClient.CreatePurchaseOrdersAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrders, summarizeErrors, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<Attachments> CreateQuoteAttachmentByFileNameAsync(Guid quoteID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateQuoteAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, quoteID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateQuoteAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid quoteID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await CreateQuoteAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Attachments>> CreateQuoteAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateQuoteAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateQuoteHistoryAsync(Guid quoteID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateQuoteHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, quoteID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateQuoteHistoryAsync(string accessToken, string xeroTenantId, Guid quoteID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await CreateQuoteHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, historyRecords, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<HistoryRecords>> CreateQuoteHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateQuoteHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<Quotes> CreateQuotesAsync(Quotes quotes, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateQuotesAsync(accessToken, xeroExtendedConfiguration.TenantId, quotes, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<Quotes> CreateQuotesAsync(string accessToken, string xeroTenantId, Quotes quotes, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Quotes> response = await CreateQuotesAsyncWithHttpInfo(accessToken, xeroTenantId, quotes, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Quotes>> CreateQuotesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Quotes quotes, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateQuotesAsyncWithHttpInfo(accessToken, xeroTenantId, quotes, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<Receipts> CreateReceiptAsync(string xeroTenantId, Receipts receipts, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateReceiptAsync(accessToken, xeroTenantId, receipts, unitdp, idempotencyKey, cancellationToken);
    }
    public async Task<Receipts> CreateReceiptAsync(string accessToken, string xeroTenantId, Receipts receipts, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Receipts> response = await CreateReceiptAsyncWithHttpInfo(accessToken, xeroTenantId, receipts, unitdp, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Receipts>> CreateReceiptAsyncWithHttpInfo(string accessToken, string xeroTenantId, Receipts receipts, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateReceiptAsyncWithHttpInfo(accessToken, xeroTenantId, receipts, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateReceiptAttachmentByFileNameAsync(Guid receiptID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateReceiptAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, receiptID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateReceiptAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid receiptID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await CreateReceiptAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, receiptID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Attachments>> CreateReceiptAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid receiptID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateReceiptAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, receiptID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateReceiptHistoryAsync(Guid receiptID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateReceiptHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, receiptID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateReceiptHistoryAsync(string accessToken, string xeroTenantId, Guid receiptID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await CreateReceiptHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, receiptID, historyRecords, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<HistoryRecords>> CreateReceiptHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid receiptID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateReceiptHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, receiptID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateRepeatingInvoiceAttachmentByFileNameAsync(Guid repeatingInvoiceID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateRepeatingInvoiceAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, repeatingInvoiceID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> CreateRepeatingInvoiceAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await CreateRepeatingInvoiceAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoiceID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Attachments>> CreateRepeatingInvoiceAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateRepeatingInvoiceAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoiceID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateRepeatingInvoiceHistoryAsync(Guid repeatingInvoiceID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateRepeatingInvoiceHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, repeatingInvoiceID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<HistoryRecords> CreateRepeatingInvoiceHistoryAsync(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await CreateRepeatingInvoiceHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoiceID, historyRecords, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<HistoryRecords>> CreateRepeatingInvoiceHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, HistoryRecords historyRecords, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateRepeatingInvoiceHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoiceID, historyRecords, idempotencyKey, cancellationToken);
    }

    public async Task<RepeatingInvoices> CreateRepeatingInvoicesAsync(RepeatingInvoices repeatingInvoices, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateRepeatingInvoicesAsync(accessToken, xeroExtendedConfiguration.TenantId, repeatingInvoices, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<RepeatingInvoices> CreateRepeatingInvoicesAsync(string accessToken, string xeroTenantId, RepeatingInvoices repeatingInvoices, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<RepeatingInvoices> response = await CreateRepeatingInvoicesAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoices, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<RepeatingInvoices>> CreateRepeatingInvoicesAsyncWithHttpInfo(string accessToken, string xeroTenantId, RepeatingInvoices repeatingInvoices, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateRepeatingInvoicesAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoices, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<TaxRates> CreateTaxRatesAsync(TaxRates taxRates, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateTaxRatesAsync(accessToken, xeroExtendedConfiguration.TenantId, taxRates, idempotencyKey, cancellationToken);
    }

    public async Task<TaxRates> CreateTaxRatesAsync(string accessToken, string xeroTenantId, TaxRates taxRates, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TaxRates> response = await CreateTaxRatesAsyncWithHttpInfo(accessToken, xeroTenantId, taxRates, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<TaxRates>> CreateTaxRatesAsyncWithHttpInfo(string accessToken, string xeroTenantId, TaxRates taxRates, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateTaxRatesAsyncWithHttpInfo(accessToken, xeroTenantId, taxRates, idempotencyKey, cancellationToken);
    }

    public async Task<TrackingCategories> CreateTrackingCategoryAsync(TrackingCategory trackingCategory, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateTrackingCategoryAsync(accessToken, xeroExtendedConfiguration.TenantId, trackingCategory, idempotencyKey, cancellationToken);
    }

    public async Task<TrackingCategories> CreateTrackingCategoryAsync(string accessToken, string xeroTenantId, TrackingCategory trackingCategory, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TrackingCategories> response = await CreateTrackingCategoryAsyncWithHttpInfo(accessToken, xeroTenantId, trackingCategory, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<TrackingCategories>> CreateTrackingCategoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, TrackingCategory trackingCategory, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateTrackingCategoryAsyncWithHttpInfo(accessToken, xeroTenantId, trackingCategory, idempotencyKey, cancellationToken);
    }

    public async Task<TrackingOptions> CreateTrackingOptionsAsync(Guid trackingCategoryID, TrackingOption trackingOption, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateTrackingOptionsAsync(accessToken, xeroExtendedConfiguration.TenantId, trackingCategoryID, trackingOption, idempotencyKey, cancellationToken);
    }

    public async Task<TrackingOptions> CreateTrackingOptionsAsync(string accessToken, string xeroTenantId, Guid trackingCategoryID, TrackingOption trackingOption, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TrackingOptions> response = await CreateTrackingOptionsAsyncWithHttpInfo(accessToken, xeroTenantId, trackingCategoryID, trackingOption, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<TrackingOptions>> CreateTrackingOptionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid trackingCategoryID, TrackingOption trackingOption, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateTrackingOptionsAsyncWithHttpInfo(accessToken, xeroTenantId, trackingCategoryID, trackingOption, idempotencyKey, cancellationToken);
    }

    public async Task<Accounts> DeleteAccountAsync(Guid accountID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteAccountAsync(accessToken, xeroExtendedConfiguration.TenantId, accountID, cancellationToken);
    }

    public async Task<Accounts> DeleteAccountAsync(string accessToken, string xeroTenantId, Guid accountID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Accounts> response = await DeleteAccountAsyncWithHttpInfo(accessToken, xeroTenantId, accountID, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Accounts>> DeleteAccountAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid accountID, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.DeleteAccountAsyncWithHttpInfo(accessToken, xeroTenantId, accountID, cancellationToken);
    }

    public async Task<BatchPayments> DeleteBatchPaymentAsync(BatchPaymentDelete batchPaymentDelete, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteBatchPaymentAsync(accessToken, xeroExtendedConfiguration.TenantId, batchPaymentDelete, idempotencyKey, cancellationToken);
    }

    public async Task<BatchPayments> DeleteBatchPaymentAsync(string accessToken, string xeroTenantId, BatchPaymentDelete batchPaymentDelete, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BatchPayments> response = await DeleteBatchPaymentAsyncWithHttpInfo(accessToken, xeroTenantId, batchPaymentDelete, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<BatchPayments>> DeleteBatchPaymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, BatchPaymentDelete batchPaymentDelete, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.DeleteBatchPaymentAsyncWithHttpInfo(accessToken, xeroTenantId, batchPaymentDelete, idempotencyKey, cancellationToken);
    }

    public async Task<BatchPayments> DeleteBatchPaymentByUrlParamAsync(Guid batchPaymentID, BatchPaymentDeleteByUrlParam batchPaymentDeleteByUrlParam, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteBatchPaymentByUrlParamAsync(accessToken, xeroExtendedConfiguration.TenantId, batchPaymentID, batchPaymentDeleteByUrlParam, idempotencyKey, cancellationToken);
    }

    public async Task<BatchPayments> DeleteBatchPaymentByUrlParamAsync(string accessToken, string xeroTenantId, Guid batchPaymentID, BatchPaymentDeleteByUrlParam batchPaymentDeleteByUrlParam, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BatchPayments> response = await DeleteBatchPaymentByUrlParamAsyncWithHttpInfo(accessToken, xeroTenantId, batchPaymentID, batchPaymentDeleteByUrlParam, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<BatchPayments>> DeleteBatchPaymentByUrlParamAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid batchPaymentID, BatchPaymentDeleteByUrlParam batchPaymentDeleteByUrlParam, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.DeleteBatchPaymentByUrlParamAsyncWithHttpInfo(accessToken, xeroTenantId, batchPaymentID, batchPaymentDeleteByUrlParam, idempotencyKey, cancellationToken);
    }

    public async Task DeleteContactGroupContactAsync(Guid contactGroupID, Guid contactID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        await DeleteContactGroupContactAsync(accessToken, xeroExtendedConfiguration.TenantId, contactGroupID, contactID, cancellationToken);
    }

    public async Task DeleteContactGroupContactAsync(string accessToken, string xeroTenantId, Guid contactGroupID, Guid contactID, CancellationToken cancellationToken = default)
    {
        await DeleteContactGroupContactAsyncWithHttpInfo(accessToken, xeroTenantId, contactGroupID, contactID, cancellationToken);
    }

    public Task<ApiResponse<object>> DeleteContactGroupContactAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactGroupID, Guid contactID, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.DeleteContactGroupContactAsyncWithHttpInfo(accessToken, xeroTenantId, contactGroupID, contactID, cancellationToken);
    }

    public async Task DeleteContactGroupContactsAsync(Guid contactGroupID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        await DeleteContactGroupContactsAsync(accessToken, xeroExtendedConfiguration.TenantId, contactGroupID, cancellationToken);
    }

    public async Task DeleteContactGroupContactsAsync(string accessToken, string xeroTenantId, Guid contactGroupID, CancellationToken cancellationToken = default)
    {
        await DeleteContactGroupContactsAsyncWithHttpInfo(accessToken, xeroTenantId, contactGroupID, cancellationToken);
    }

    public Task<ApiResponse<object>> DeleteContactGroupContactsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactGroupID, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.DeleteContactGroupContactsAsyncWithHttpInfo(accessToken, xeroTenantId, contactGroupID, cancellationToken);
    }

    public async Task<Allocation> DeleteCreditNoteAllocationsAsync(Guid creditNoteID, Guid allocationID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteCreditNoteAllocationsAsync(accessToken, xeroExtendedConfiguration.TenantId, creditNoteID, allocationID, cancellationToken);
    }

    public async Task<Allocation> DeleteCreditNoteAllocationsAsync(string accessToken, string xeroTenantId, Guid creditNoteID, Guid allocationID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Allocation> response = await DeleteCreditNoteAllocationsAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, allocationID, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Allocation>> DeleteCreditNoteAllocationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, Guid allocationID, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.DeleteCreditNoteAllocationsAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, allocationID, cancellationToken);
    }

    public async Task DeleteItemAsync(Guid itemID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        await DeleteItemAsync(accessToken, xeroExtendedConfiguration.TenantId, itemID, cancellationToken);
    }

    public async Task DeleteItemAsync(string accessToken, string xeroTenantId, Guid itemID, CancellationToken cancellationToken = default)
    {
        await DeleteItemAsyncWithHttpInfo(accessToken, xeroTenantId, itemID, cancellationToken);
    }

    public Task<ApiResponse<object>> DeleteItemAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid itemID, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.DeleteItemAsyncWithHttpInfo(accessToken, xeroTenantId, itemID, cancellationToken);
    }

    public async Task DeleteLinkedTransactionAsync(Guid linkedTransactionID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        await DeleteLinkedTransactionAsync(accessToken, xeroExtendedConfiguration.TenantId, linkedTransactionID, cancellationToken);
    }

    public async Task DeleteLinkedTransactionAsync(string accessToken, string xeroTenantId, Guid linkedTransactionID, CancellationToken cancellationToken = default)
    {
        await DeleteLinkedTransactionAsyncWithHttpInfo(accessToken, xeroTenantId, linkedTransactionID, cancellationToken);
    }

    public Task<ApiResponse<object>> DeleteLinkedTransactionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid linkedTransactionID, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.DeleteLinkedTransactionAsyncWithHttpInfo(accessToken, xeroTenantId, linkedTransactionID, cancellationToken);
    }

    public async Task<Allocation> DeleteOverpaymentAllocationsAsync(Guid overpaymentID, Guid allocationID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteOverpaymentAllocationsAsync(accessToken, xeroExtendedConfiguration.TenantId, overpaymentID, allocationID, cancellationToken);
    }

    public async Task<Allocation> DeleteOverpaymentAllocationsAsync(string accessToken, string xeroTenantId, Guid overpaymentID, Guid allocationID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Allocation> response = await DeleteOverpaymentAllocationsAsyncWithHttpInfo(accessToken, xeroTenantId, overpaymentID, allocationID, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Allocation>> DeleteOverpaymentAllocationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid overpaymentID, Guid allocationID, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.DeleteOverpaymentAllocationsAsyncWithHttpInfo(accessToken, xeroTenantId, overpaymentID, allocationID, cancellationToken);
    }
    public async Task<Payments> DeletePaymentAsync(Guid paymentID, PaymentDelete paymentDelete, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeletePaymentAsync(accessToken, xeroExtendedConfiguration.TenantId, paymentID, paymentDelete, idempotencyKey, cancellationToken);
    }

    public async Task<Payments> DeletePaymentAsync(string accessToken, string xeroTenantId, Guid paymentID, PaymentDelete paymentDelete, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Payments> response = await DeletePaymentAsyncWithHttpInfo(accessToken, xeroTenantId, paymentID, paymentDelete, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Payments>> DeletePaymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid paymentID, PaymentDelete paymentDelete, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Payments> response = await accountingXeroClient.DeletePaymentAsyncWithHttpInfo(accessToken, xeroTenantId, paymentID, paymentDelete, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Allocation> DeletePrepaymentAllocationsAsync(Guid prepaymentID, Guid allocationID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeletePrepaymentAllocationsAsync(accessToken, xeroExtendedConfiguration.TenantId, prepaymentID, allocationID, cancellationToken);
    }

    public async Task<Allocation> DeletePrepaymentAllocationsAsync(string accessToken, string xeroTenantId, Guid prepaymentID, Guid allocationID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Allocation> response = await DeletePrepaymentAllocationsAsyncWithHttpInfo(accessToken, xeroTenantId, prepaymentID, allocationID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Allocation>> DeletePrepaymentAllocationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid prepaymentID, Guid allocationID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Allocation> response = await accountingXeroClient.DeletePrepaymentAllocationsAsyncWithHttpInfo(accessToken, xeroTenantId, prepaymentID, allocationID, cancellationToken);
        return response;
    }
    public async Task<TrackingCategories> DeleteTrackingCategoryAsync(Guid trackingCategoryID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteTrackingCategoryAsync(accessToken, xeroExtendedConfiguration.TenantId, trackingCategoryID, cancellationToken);
    }

    public async Task<TrackingCategories> DeleteTrackingCategoryAsync(string accessToken, string xeroTenantId, Guid trackingCategoryID, CancellationToken cancellationToken = default)
    {
        ApiResponse<TrackingCategories> response = await DeleteTrackingCategoryAsyncWithHttpInfo(accessToken, xeroTenantId, trackingCategoryID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TrackingCategories>> DeleteTrackingCategoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid trackingCategoryID, CancellationToken cancellationToken = default)
    {
        ApiResponse<TrackingCategories> response = await accountingXeroClient.DeleteTrackingCategoryAsyncWithHttpInfo(accessToken, xeroTenantId, trackingCategoryID, cancellationToken);
        return response;
    }
    public async Task<TrackingOptions> DeleteTrackingOptionsAsync(Guid trackingCategoryID, Guid trackingOptionID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await DeleteTrackingOptionsAsync(accessToken, xeroExtendedConfiguration.TenantId, trackingCategoryID, trackingOptionID, cancellationToken);
    }

    public async Task<TrackingOptions> DeleteTrackingOptionsAsync(string accessToken, string xeroTenantId, Guid trackingCategoryID, Guid trackingOptionID, CancellationToken cancellationToken = default)
    {
        ApiResponse<TrackingOptions> response = await DeleteTrackingOptionsAsyncWithHttpInfo(accessToken, xeroTenantId, trackingCategoryID, trackingOptionID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TrackingOptions>> DeleteTrackingOptionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid trackingCategoryID, Guid trackingOptionID, CancellationToken cancellationToken = default)
    {
        ApiResponse<TrackingOptions> response = await accountingXeroClient.DeleteTrackingOptionsAsyncWithHttpInfo(accessToken, xeroTenantId, trackingCategoryID, trackingOptionID, cancellationToken);
        return response;
    }

    public Task EmailInvoiceAsync(string accessToken, string xeroTenantId, Guid invoiceID, RequestEmpty requestEmpty, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<object>> EmailInvoiceAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, RequestEmpty requestEmpty, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
    public async Task<Accounts> GetAccountAsync(Guid accountID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAccountAsync(accessToken, xeroExtendedConfiguration.TenantId, accountID, cancellationToken);
    }

    public async Task<Accounts> GetAccountAsync(string accessToken, string xeroTenantId, Guid accountID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Accounts> response = await GetAccountAsyncWithHttpInfo(accessToken, xeroTenantId, accountID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Accounts>> GetAccountAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid accountID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Accounts> response = await accountingXeroClient.GetAccountAsyncWithHttpInfo(accessToken, xeroTenantId, accountID, cancellationToken);
        return response;
    }
    public async Task<Stream> GetAccountAttachmentByFileNameAsync(Guid accountID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAccountAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, accountID, fileName, contentType, cancellationToken);
    }

    public async Task<Stream> GetAccountAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid accountID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetAccountAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, accountID, fileName, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetAccountAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid accountID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetAccountAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, accountID, fileName, contentType, cancellationToken);
        return response;
    }
    public async Task<Stream> GetAccountAttachmentByIdAsync(Guid accountID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAccountAttachmentByIdAsync(accessToken, xeroExtendedConfiguration.TenantId, accountID, attachmentID, contentType, cancellationToken);
    }

    public async Task<Stream> GetAccountAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid accountID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetAccountAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, accountID, attachmentID, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetAccountAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid accountID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetAccountAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, accountID, attachmentID, contentType, cancellationToken);
        return response;
    }
    public async Task<Attachments> GetAccountAttachmentsAsync(Guid accountID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAccountAttachmentsAsync(accessToken, xeroExtendedConfiguration.TenantId, accountID, cancellationToken);
    }

    public async Task<Attachments> GetAccountAttachmentsAsync(string accessToken, string xeroTenantId, Guid accountID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await GetAccountAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, accountID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> GetAccountAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid accountID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.GetAccountAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, accountID, cancellationToken);
        return response;
    }
    public async Task<Accounts> GetAccountsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetAccountsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, cancellationToken);
    }

    public async Task<Accounts> GetAccountsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Accounts> response = await GetAccountsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Accounts>> GetAccountsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Accounts> response = await accountingXeroClient.GetAccountsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, cancellationToken);
        return response;
    }
    public async Task<BankTransactions> GetBankTransactionAsync(Guid bankTransactionID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBankTransactionAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransactionID, unitdp, cancellationToken);
    }

    public async Task<BankTransactions> GetBankTransactionAsync(string accessToken, string xeroTenantId, Guid bankTransactionID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BankTransactions> response = await GetBankTransactionAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactionID, unitdp, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<BankTransactions>> GetBankTransactionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransactionID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BankTransactions> response = await accountingXeroClient.GetBankTransactionAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactionID, unitdp, cancellationToken);
        return response;
    }
    public async Task<Stream> GetBankTransactionAttachmentByFileNameAsync(Guid bankTransactionID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBankTransactionAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransactionID, fileName, contentType, cancellationToken);
    }

    public async Task<Stream> GetBankTransactionAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid bankTransactionID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetBankTransactionAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactionID, fileName, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetBankTransactionAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransactionID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetBankTransactionAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactionID, fileName, contentType, cancellationToken);
        return response;
    }
    public async Task<Stream> GetBankTransactionAttachmentByIdAsync(Guid bankTransactionID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBankTransactionAttachmentByIdAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransactionID, attachmentID, contentType, cancellationToken);
    }

    public async Task<Stream> GetBankTransactionAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid bankTransactionID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetBankTransactionAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactionID, attachmentID, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetBankTransactionAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransactionID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetBankTransactionAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactionID, attachmentID, contentType, cancellationToken);
        return response;
    }
    public async Task<Attachments> GetBankTransactionAttachmentsAsync(Guid bankTransactionID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBankTransactionAttachmentsAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransactionID, cancellationToken);
    }

    public async Task<Attachments> GetBankTransactionAttachmentsAsync(string accessToken, string xeroTenantId, Guid bankTransactionID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await GetBankTransactionAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactionID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> GetBankTransactionAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransactionID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.GetBankTransactionAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactionID, cancellationToken);
        return response;
    }
    public async Task<BankTransactions> GetBankTransactionsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBankTransactionsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, unitdp, pageSize, cancellationToken);
    }

    public async Task<BankTransactions> GetBankTransactionsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BankTransactions> response = await GetBankTransactionsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, unitdp, pageSize, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<BankTransactions>> GetBankTransactionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BankTransactions> response = await accountingXeroClient.GetBankTransactionsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, unitdp, pageSize, cancellationToken);
        return response;
    }
    public async Task<HistoryRecords> GetBankTransactionsHistoryAsync(Guid bankTransactionID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBankTransactionsHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransactionID, cancellationToken);
    }

    public async Task<HistoryRecords> GetBankTransactionsHistoryAsync(string accessToken, string xeroTenantId, Guid bankTransactionID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await GetBankTransactionsHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactionID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<HistoryRecords>> GetBankTransactionsHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransactionID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await accountingXeroClient.GetBankTransactionsHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactionID, cancellationToken);
        return response;
    }
    public async Task<BankTransfers> GetBankTransferAsync(Guid bankTransferID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBankTransferAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransferID, cancellationToken);
    }

    public async Task<BankTransfers> GetBankTransferAsync(string accessToken, string xeroTenantId, Guid bankTransferID, CancellationToken cancellationToken = default)
    {
        ApiResponse<BankTransfers> response = await GetBankTransferAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransferID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<BankTransfers>> GetBankTransferAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransferID, CancellationToken cancellationToken = default)
    {
        ApiResponse<BankTransfers> response = await accountingXeroClient.GetBankTransferAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransferID, cancellationToken);
        return response;
    }
    public async Task<Stream> GetBankTransferAttachmentByFileNameAsync(Guid bankTransferID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBankTransferAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransferID, fileName, contentType, cancellationToken);
    }

    public async Task<Stream> GetBankTransferAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid bankTransferID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetBankTransferAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransferID, fileName, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetBankTransferAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransferID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetBankTransferAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransferID, fileName, contentType, cancellationToken);
        return response;
    }
    public async Task<Stream> GetBankTransferAttachmentByIdAsync(Guid bankTransferID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBankTransferAttachmentByIdAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransferID, attachmentID, contentType, cancellationToken);
    }

    public async Task<Stream> GetBankTransferAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid bankTransferID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetBankTransferAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransferID, attachmentID, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetBankTransferAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransferID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetBankTransferAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransferID, attachmentID, contentType, cancellationToken);
        return response;
    }
    public async Task<Attachments> GetBankTransferAttachmentsAsync(Guid bankTransferID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBankTransferAttachmentsAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransferID, cancellationToken);
    }

    public async Task<Attachments> GetBankTransferAttachmentsAsync(string accessToken, string xeroTenantId, Guid bankTransferID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await GetBankTransferAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransferID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> GetBankTransferAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransferID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.GetBankTransferAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransferID, cancellationToken);
        return response;
    }
    public async Task<HistoryRecords> GetBankTransferHistoryAsync(Guid bankTransferID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBankTransferHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransferID, cancellationToken);
    }

    public async Task<HistoryRecords> GetBankTransferHistoryAsync(string accessToken, string xeroTenantId, Guid bankTransferID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await GetBankTransferHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransferID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<HistoryRecords>> GetBankTransferHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransferID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await accountingXeroClient.GetBankTransferHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransferID, cancellationToken);
        return response;
    }
    public async Task<BankTransfers> GetBankTransfersAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBankTransfersAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, cancellationToken);
    }

    public async Task<BankTransfers> GetBankTransfersAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BankTransfers> response = await GetBankTransfersAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<BankTransfers>> GetBankTransfersAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BankTransfers> response = await accountingXeroClient.GetBankTransfersAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, cancellationToken);
        return response;
    }

    public string GetBasePath()
    {
        return fileXeroClient.GetBasePath();
    }
    public async Task<BatchPayments> GetBatchPaymentAsync(Guid batchPaymentID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBatchPaymentAsync(accessToken, xeroExtendedConfiguration.TenantId, batchPaymentID, cancellationToken);
    }

    public async Task<BatchPayments> GetBatchPaymentAsync(string accessToken, string xeroTenantId, Guid batchPaymentID, CancellationToken cancellationToken = default)
    {
        ApiResponse<BatchPayments> response = await GetBatchPaymentAsyncWithHttpInfo(accessToken, xeroTenantId, batchPaymentID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<BatchPayments>> GetBatchPaymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid batchPaymentID, CancellationToken cancellationToken = default)
    {
        ApiResponse<BatchPayments> response = await accountingXeroClient.GetBatchPaymentAsyncWithHttpInfo(accessToken, xeroTenantId, batchPaymentID, cancellationToken);
        return response;
    }
    public async Task<HistoryRecords> GetBatchPaymentHistoryAsync(Guid batchPaymentID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBatchPaymentHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, batchPaymentID, cancellationToken);
    }

    public async Task<HistoryRecords> GetBatchPaymentHistoryAsync(string accessToken, string xeroTenantId, Guid batchPaymentID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await GetBatchPaymentHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, batchPaymentID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<HistoryRecords>> GetBatchPaymentHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid batchPaymentID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await accountingXeroClient.GetBatchPaymentHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, batchPaymentID, cancellationToken);
        return response;
    }
    public async Task<BatchPayments> GetBatchPaymentsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBatchPaymentsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, cancellationToken);
    }

    public async Task<BatchPayments> GetBatchPaymentsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BatchPayments> response = await GetBatchPaymentsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<BatchPayments>> GetBatchPaymentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BatchPayments> response = await accountingXeroClient.GetBatchPaymentsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, cancellationToken);
        return response;
    }
    public async Task<BrandingThemes> GetBrandingThemeAsync(Guid brandingThemeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBrandingThemeAsync(accessToken, xeroExtendedConfiguration.TenantId, brandingThemeID, cancellationToken);
    }

    public async Task<BrandingThemes> GetBrandingThemeAsync(string accessToken, string xeroTenantId, Guid brandingThemeID, CancellationToken cancellationToken = default)
    {
        ApiResponse<BrandingThemes> response = await GetBrandingThemeAsyncWithHttpInfo(accessToken, xeroTenantId, brandingThemeID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<BrandingThemes>> GetBrandingThemeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid brandingThemeID, CancellationToken cancellationToken = default)
    {
        ApiResponse<BrandingThemes> response = await accountingXeroClient.GetBrandingThemeAsyncWithHttpInfo(accessToken, xeroTenantId, brandingThemeID, cancellationToken);
        return response;
    }
    public async Task<PaymentServices> GetBrandingThemePaymentServicesAsync(Guid brandingThemeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBrandingThemePaymentServicesAsync(accessToken, xeroExtendedConfiguration.TenantId, brandingThemeID, cancellationToken);
    }

    public async Task<PaymentServices> GetBrandingThemePaymentServicesAsync(string accessToken, string xeroTenantId, Guid brandingThemeID, CancellationToken cancellationToken = default)
    {
        ApiResponse<PaymentServices> response = await GetBrandingThemePaymentServicesAsyncWithHttpInfo(accessToken, xeroTenantId, brandingThemeID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PaymentServices>> GetBrandingThemePaymentServicesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid brandingThemeID, CancellationToken cancellationToken = default)
    {
        ApiResponse<PaymentServices> response = await accountingXeroClient.GetBrandingThemePaymentServicesAsyncWithHttpInfo(accessToken, xeroTenantId, brandingThemeID, cancellationToken);
        return response;
    }
    public async Task<BrandingThemes> GetBrandingThemesAsync(CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBrandingThemesAsync(accessToken, xeroExtendedConfiguration.TenantId, cancellationToken);
    }

    public async Task<BrandingThemes> GetBrandingThemesAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        ApiResponse<BrandingThemes> response = await GetBrandingThemesAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<BrandingThemes>> GetBrandingThemesAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        ApiResponse<BrandingThemes> response = await accountingXeroClient.GetBrandingThemesAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response;
    }
    public async Task<Budgets> GetBudgetAsync(Guid budgetID, DateTime? dateTo = null, DateTime? dateFrom = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBudgetAsync(accessToken, xeroExtendedConfiguration.TenantId, budgetID, dateTo, dateFrom, cancellationToken);
    }

    public async Task<Budgets> GetBudgetAsync(string accessToken, string xeroTenantId, Guid budgetID, DateTime? dateTo = null, DateTime? dateFrom = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Budgets> response = await GetBudgetAsyncWithHttpInfo(accessToken, xeroTenantId, budgetID, dateTo, dateFrom, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Budgets>> GetBudgetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid budgetID, DateTime? dateTo = null, DateTime? dateFrom = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Budgets> response = await accountingXeroClient.GetBudgetAsyncWithHttpInfo(accessToken, xeroTenantId, budgetID, dateTo, dateFrom, cancellationToken);
        return response;
    }
    public async Task<Budgets> GetBudgetsAsync(List<Guid>? iDs = null, DateTime? dateTo = null, DateTime? dateFrom = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetBudgetsAsync(accessToken, xeroExtendedConfiguration.TenantId, iDs, dateTo, dateFrom, cancellationToken);
    }

    public async Task<Budgets> GetBudgetsAsync(string accessToken, string xeroTenantId, List<Guid>? iDs = null, DateTime? dateTo = null, DateTime? dateFrom = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Budgets> response = await GetBudgetsAsyncWithHttpInfo(accessToken, xeroTenantId, iDs, dateTo, dateFrom, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Budgets>> GetBudgetsAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<Guid>? iDs = null, DateTime? dateTo = null, DateTime? dateFrom = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Budgets> response = await accountingXeroClient.GetBudgetsAsyncWithHttpInfo(accessToken, xeroTenantId, iDs, dateTo, dateFrom, cancellationToken);
        return response;
    }
    public async Task<Contacts> GetContactAsync(Guid contactID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetContactAsync(accessToken, xeroExtendedConfiguration.TenantId, contactID, cancellationToken);
    }

    public async Task<Contacts> GetContactAsync(string accessToken, string xeroTenantId, Guid contactID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Contacts> response = await GetContactAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Contacts>> GetContactAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Contacts> response = await accountingXeroClient.GetContactAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, cancellationToken);
        return response;
    }
    public async Task<Stream> GetContactAttachmentByFileNameAsync(Guid contactID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetContactAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, contactID, fileName, contentType, cancellationToken);
    }

    public async Task<Stream> GetContactAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid contactID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetContactAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, fileName, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetContactAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetContactAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, fileName, contentType, cancellationToken);
        return response;
    }
    public async Task<Stream> GetContactAttachmentByIdAsync(Guid contactID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetContactAttachmentByIdAsync(accessToken, xeroExtendedConfiguration.TenantId, contactID, attachmentID, contentType, cancellationToken);
    }

    public async Task<Stream> GetContactAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid contactID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetContactAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, attachmentID, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetContactAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetContactAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, attachmentID, contentType, cancellationToken);
        return response;
    }
    public async Task<Attachments> GetContactAttachmentsAsync(Guid contactID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetContactAttachmentsAsync(accessToken, xeroExtendedConfiguration.TenantId, contactID, cancellationToken);
    }

    public async Task<Attachments> GetContactAttachmentsAsync(string accessToken, string xeroTenantId, Guid contactID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await GetContactAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> GetContactAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.GetContactAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, cancellationToken);
        return response;
    }
    public async Task<Contacts> GetContactByContactNumberAsync(string contactNumber, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetContactByContactNumberAsync(accessToken, xeroExtendedConfiguration.TenantId, contactNumber, cancellationToken);
    }

    public async Task<Contacts> GetContactByContactNumberAsync(string accessToken, string xeroTenantId, string contactNumber, CancellationToken cancellationToken = default)
    {
        ApiResponse<Contacts> response = await GetContactByContactNumberAsyncWithHttpInfo(accessToken, xeroTenantId, contactNumber, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Contacts>> GetContactByContactNumberAsyncWithHttpInfo(string accessToken, string xeroTenantId, string contactNumber, CancellationToken cancellationToken = default)
    {
        ApiResponse<Contacts> response = await accountingXeroClient.GetContactByContactNumberAsyncWithHttpInfo(accessToken, xeroTenantId, contactNumber, cancellationToken);
        return response;
    }
    public async Task<CISSettings> GetContactCISSettingsAsync(Guid contactID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetContactCISSettingsAsync(accessToken, xeroExtendedConfiguration.TenantId, contactID, cancellationToken);
    }

    public async Task<CISSettings> GetContactCISSettingsAsync(string accessToken, string xeroTenantId, Guid contactID, CancellationToken cancellationToken = default)
    {
        ApiResponse<CISSettings> response = await GetContactCISSettingsAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<CISSettings>> GetContactCISSettingsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, CancellationToken cancellationToken = default)
    {
        ApiResponse<CISSettings> response = await accountingXeroClient.GetContactCISSettingsAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, cancellationToken);
        return response;
    }
    public async Task<ContactGroups> GetContactGroupAsync(Guid contactGroupID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetContactGroupAsync(accessToken, xeroExtendedConfiguration.TenantId, contactGroupID, cancellationToken);
    }

    public async Task<ContactGroups> GetContactGroupAsync(string accessToken, string xeroTenantId, Guid contactGroupID, CancellationToken cancellationToken = default)
    {
        ApiResponse<ContactGroups> response = await GetContactGroupAsyncWithHttpInfo(accessToken, xeroTenantId, contactGroupID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ContactGroups>> GetContactGroupAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactGroupID, CancellationToken cancellationToken = default)
    {
        ApiResponse<ContactGroups> response = await accountingXeroClient.GetContactGroupAsyncWithHttpInfo(accessToken, xeroTenantId, contactGroupID, cancellationToken);
        return response;
    }
    public async Task<ContactGroups> GetContactGroupsAsync(string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetContactGroupsAsync(accessToken, xeroExtendedConfiguration.TenantId, where, order, cancellationToken);
    }

    public async Task<ContactGroups> GetContactGroupsAsync(string accessToken, string xeroTenantId, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ContactGroups> response = await GetContactGroupsAsyncWithHttpInfo(accessToken, xeroTenantId, where, order, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ContactGroups>> GetContactGroupsAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ContactGroups> response = await accountingXeroClient.GetContactGroupsAsyncWithHttpInfo(accessToken, xeroTenantId, where, order, cancellationToken);
        return response;
    }
    public async Task<HistoryRecords> GetContactHistoryAsync(Guid contactID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetContactHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, contactID, cancellationToken);
    }

    public async Task<HistoryRecords> GetContactHistoryAsync(string accessToken, string xeroTenantId, Guid contactID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await GetContactHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<HistoryRecords>> GetContactHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await accountingXeroClient.GetContactHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, cancellationToken);
        return response;
    }

    public async Task<Contacts> GetContactsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, List<Guid>? iDs = null, int? page = null, bool? includeArchived = null, bool? summaryOnly = null, string? searchTerm = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        ApiResponse<Contacts> response = await GetContactsAsyncWithHttpInfo(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, iDs, page, includeArchived, summaryOnly, searchTerm, pageSize, cancellationToken);
        return response.Data;
    }
    public async Task<Contacts> GetContactsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, List<Guid>? iDs = null, int? page = null, bool? includeArchived = null, bool? summaryOnly = null, string? searchTerm = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Contacts> response = await GetContactsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, iDs, page, includeArchived, summaryOnly, searchTerm, pageSize, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Contacts>> GetContactsAsyncWithHttpInfo(string? accessToken, string? xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, List<Guid>? iDs = null, int? page = null, bool? includeArchived = null, bool? summaryOnly = null, string? searchTerm = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Contacts> response = await accountingXeroClient.GetContactsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, iDs, page, includeArchived, summaryOnly, searchTerm, pageSize, cancellationToken);
        return response;
    }

    public async Task<Stream> GetCreditNoteAsPdfAsync(Guid creditNoteID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetCreditNoteAsPdfAsync(accessToken, xeroExtendedConfiguration.TenantId, creditNoteID, cancellationToken);
    }

    public async Task<Stream> GetCreditNoteAsPdfAsync(string accessToken, string xeroTenantId, Guid creditNoteID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetCreditNoteAsPdfAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetCreditNoteAsPdfAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetCreditNoteAsPdfAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, cancellationToken);
        return response;
    }
    public async Task<CreditNotes> GetCreditNoteAsync(Guid creditNoteID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetCreditNoteAsync(accessToken, xeroExtendedConfiguration.TenantId, creditNoteID, unitdp, cancellationToken);
    }

    public async Task<CreditNotes> GetCreditNoteAsync(string accessToken, string xeroTenantId, Guid creditNoteID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<CreditNotes> response = await GetCreditNoteAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, unitdp, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<CreditNotes>> GetCreditNoteAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<CreditNotes> response = await accountingXeroClient.GetCreditNoteAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, unitdp, cancellationToken);
        return response;
    }
    public async Task<Stream> GetCreditNoteAttachmentByFileNameAsync(Guid creditNoteID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetCreditNoteAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, creditNoteID, fileName, contentType, cancellationToken);
    }

    public async Task<Stream> GetCreditNoteAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid creditNoteID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetCreditNoteAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, fileName, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetCreditNoteAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetCreditNoteAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, fileName, contentType, cancellationToken);
        return response;
    }
    public async Task<Stream> GetCreditNoteAttachmentByIdAsync(Guid creditNoteID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetCreditNoteAttachmentByIdAsync(accessToken, xeroExtendedConfiguration.TenantId, creditNoteID, attachmentID, contentType, cancellationToken);
    }

    public async Task<Stream> GetCreditNoteAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid creditNoteID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetCreditNoteAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, attachmentID, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetCreditNoteAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetCreditNoteAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, attachmentID, contentType, cancellationToken);
        return response;
    }
    public async Task<Attachments> GetCreditNoteAttachmentsAsync(Guid creditNoteID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetCreditNoteAttachmentsAsync(accessToken, xeroExtendedConfiguration.TenantId, creditNoteID, cancellationToken);
    }

    public async Task<Attachments> GetCreditNoteAttachmentsAsync(string accessToken, string xeroTenantId, Guid creditNoteID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await GetCreditNoteAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> GetCreditNoteAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.GetCreditNoteAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, cancellationToken);
        return response;
    }
    public async Task<HistoryRecords> GetCreditNoteHistoryAsync(Guid creditNoteID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetCreditNoteHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, creditNoteID, cancellationToken);
    }

    public async Task<HistoryRecords> GetCreditNoteHistoryAsync(string accessToken, string xeroTenantId, Guid creditNoteID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await GetCreditNoteHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<HistoryRecords>> GetCreditNoteHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await accountingXeroClient.GetCreditNoteHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, cancellationToken);
        return response;
    }
    public async Task<CreditNotes> GetCreditNotesAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetCreditNotesAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, unitdp, pageSize, cancellationToken);
    }

    public async Task<CreditNotes> GetCreditNotesAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<CreditNotes> response = await GetCreditNotesAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, unitdp, pageSize, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<CreditNotes>> GetCreditNotesAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<CreditNotes> response = await accountingXeroClient.GetCreditNotesAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, unitdp, pageSize, cancellationToken);
        return response;
    }
    public async Task<Currencies> GetCurrenciesAsync(string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetCurrenciesAsync(accessToken, xeroExtendedConfiguration.TenantId, where, order, cancellationToken);
    }

    public async Task<Currencies> GetCurrenciesAsync(string accessToken, string xeroTenantId, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Currencies> response = await GetCurrenciesAsyncWithHttpInfo(accessToken, xeroTenantId, where, order, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Currencies>> GetCurrenciesAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Currencies> response = await accountingXeroClient.GetCurrenciesAsyncWithHttpInfo(accessToken, xeroTenantId, where, order, cancellationToken);
        return response;
    }
    public async Task<Employees> GetEmployeeAsync(Guid employeeID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeeAsync(accessToken, xeroExtendedConfiguration.TenantId, employeeID, cancellationToken);
    }

    public async Task<Employees> GetEmployeeAsync(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await GetEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Employees>> GetEmployeeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid employeeID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await accountingXeroClient.GetEmployeeAsyncWithHttpInfo(accessToken, xeroTenantId, employeeID, cancellationToken);
        return response;
    }
    public async Task<Employees> GetEmployeesAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetEmployeesAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, cancellationToken);
    }

    public async Task<Employees> GetEmployeesAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await GetEmployeesAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Employees>> GetEmployeesAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await accountingXeroClient.GetEmployeesAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, cancellationToken);
        return response;
    }
    public async Task<ExpenseClaims> GetExpenseClaimAsync(Guid expenseClaimID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetExpenseClaimAsync(accessToken, xeroExtendedConfiguration.TenantId, expenseClaimID, cancellationToken);
    }

    public async Task<ExpenseClaims> GetExpenseClaimAsync(string accessToken, string xeroTenantId, Guid expenseClaimID, CancellationToken cancellationToken = default)
    {
        ApiResponse<ExpenseClaims> response = await GetExpenseClaimAsyncWithHttpInfo(accessToken, xeroTenantId, expenseClaimID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ExpenseClaims>> GetExpenseClaimAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid expenseClaimID, CancellationToken cancellationToken = default)
    {
        ApiResponse<ExpenseClaims> response = await accountingXeroClient.GetExpenseClaimAsyncWithHttpInfo(accessToken, xeroTenantId, expenseClaimID, cancellationToken);
        return response;
    }
    public async Task<HistoryRecords> GetExpenseClaimHistoryAsync(Guid expenseClaimID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetExpenseClaimHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, expenseClaimID, cancellationToken);
    }

    public async Task<HistoryRecords> GetExpenseClaimHistoryAsync(string accessToken, string xeroTenantId, Guid expenseClaimID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await GetExpenseClaimHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, expenseClaimID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<HistoryRecords>> GetExpenseClaimHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid expenseClaimID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await accountingXeroClient.GetExpenseClaimHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, expenseClaimID, cancellationToken);
        return response;
    }
    public async Task<ExpenseClaims> GetExpenseClaimsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetExpenseClaimsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, cancellationToken);
    }

    public async Task<ExpenseClaims> GetExpenseClaimsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ExpenseClaims> response = await GetExpenseClaimsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ExpenseClaims>> GetExpenseClaimsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ExpenseClaims> response = await accountingXeroClient.GetExpenseClaimsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, cancellationToken);
        return response;
    }

    public async Task<Stream> GetInvoiceAsPdfAsync(Guid invoiceID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetInvoiceAsPdfAsync(accessToken, xeroExtendedConfiguration.TenantId, invoiceID, cancellationToken);
    }

    public async Task<Stream> GetInvoiceAsPdfAsync(string accessToken, string xeroTenantId, Guid invoiceID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetInvoiceAsPdfAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetInvoiceAsPdfAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetInvoiceAsPdfAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, cancellationToken);
        return response;
    }
    public async Task<Invoices> GetInvoiceAsync(Guid invoiceID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetInvoiceAsync(accessToken, xeroExtendedConfiguration.TenantId, invoiceID, unitdp, cancellationToken);
    }

    public async Task<Invoices> GetInvoiceAsync(string accessToken, string xeroTenantId, Guid invoiceID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Invoices> response = await GetInvoiceAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, unitdp, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Invoices>> GetInvoiceAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Invoices> response = await accountingXeroClient.GetInvoiceAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, unitdp, cancellationToken);
        return response;
    }
    public async Task<Stream> GetInvoiceAttachmentByFileNameAsync(Guid invoiceID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetInvoiceAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, invoiceID, fileName, contentType, cancellationToken);
    }

    public async Task<Stream> GetInvoiceAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid invoiceID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetInvoiceAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, fileName, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetInvoiceAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetInvoiceAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, fileName, contentType, cancellationToken);
        return response;
    }
    public async Task<Stream> GetInvoiceAttachmentByIdAsync(Guid invoiceID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetInvoiceAttachmentByIdAsync(accessToken, xeroExtendedConfiguration.TenantId, invoiceID, attachmentID, contentType, cancellationToken);
    }

    public async Task<Stream> GetInvoiceAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid invoiceID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetInvoiceAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, attachmentID, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetInvoiceAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetInvoiceAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, attachmentID, contentType, cancellationToken);
        return response;
    }
    public async Task<Attachments> GetInvoiceAttachmentsAsync(Guid invoiceID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetInvoiceAttachmentsAsync(accessToken, xeroExtendedConfiguration.TenantId, invoiceID, cancellationToken);
    }

    public async Task<Attachments> GetInvoiceAttachmentsAsync(string accessToken, string xeroTenantId, Guid invoiceID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await GetInvoiceAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> GetInvoiceAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.GetInvoiceAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, cancellationToken);
        return response;
    }
    public async Task<HistoryRecords> GetInvoiceHistoryAsync(Guid invoiceID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetInvoiceHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, invoiceID, cancellationToken);
    }

    public async Task<HistoryRecords> GetInvoiceHistoryAsync(string accessToken, string xeroTenantId, Guid invoiceID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await GetInvoiceHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<HistoryRecords>> GetInvoiceHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await accountingXeroClient.GetInvoiceHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, cancellationToken);
        return response;
    }
    public async Task<InvoiceReminders> GetInvoiceRemindersAsync(CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetInvoiceRemindersAsync(accessToken, xeroExtendedConfiguration.TenantId, cancellationToken);
    }

    public async Task<InvoiceReminders> GetInvoiceRemindersAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        ApiResponse<InvoiceReminders> response = await GetInvoiceRemindersAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<InvoiceReminders>> GetInvoiceRemindersAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        ApiResponse<InvoiceReminders> response = await accountingXeroClient.GetInvoiceRemindersAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response;
    }
    public async Task<Invoices> GetInvoicesAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, List<Guid>? iDs = null, List<string>? invoiceNumbers = null, List<Guid>? contactIDs = null, List<string>? statuses = null, int? page = null, bool? includeArchived = null, bool? createdByMyApp = null, int? unitdp = null, bool? summaryOnly = null, int? pageSize = null, string? searchTerm = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetInvoicesAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, iDs, invoiceNumbers, contactIDs, statuses, page, includeArchived, createdByMyApp, unitdp, summaryOnly, pageSize, searchTerm, cancellationToken);
    }

    public async Task<Invoices> GetInvoicesAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, List<Guid>? iDs = null, List<string>? invoiceNumbers = null, List<Guid>? contactIDs = null, List<string>? statuses = null, int? page = null, bool? includeArchived = null, bool? createdByMyApp = null, int? unitdp = null, bool? summaryOnly = null, int? pageSize = null, string? searchTerm = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Invoices> response = await GetInvoicesAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, iDs, invoiceNumbers, contactIDs, statuses, page, includeArchived, createdByMyApp, unitdp, summaryOnly, pageSize, searchTerm, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Invoices>> GetInvoicesAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, List<Guid>? iDs = null, List<string>? invoiceNumbers = null, List<Guid>? contactIDs = null, List<string>? statuses = null, int? page = null, bool? includeArchived = null, bool? createdByMyApp = null, int? unitdp = null, bool? summaryOnly = null, int? pageSize = null, string? searchTerm = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Invoices> response = await accountingXeroClient.GetInvoicesAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, iDs, invoiceNumbers, contactIDs, statuses, page, includeArchived, createdByMyApp, unitdp, summaryOnly, pageSize, searchTerm, cancellationToken);
        return response;
    }
    public async Task<Items> GetItemAsync(Guid itemID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetItemAsync(accessToken, xeroExtendedConfiguration.TenantId, itemID, unitdp, cancellationToken);
    }

    public async Task<Items> GetItemAsync(string accessToken, string xeroTenantId, Guid itemID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Items> response = await GetItemAsyncWithHttpInfo(accessToken, xeroTenantId, itemID, unitdp, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Items>> GetItemAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid itemID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Items> response = await accountingXeroClient.GetItemAsyncWithHttpInfo(accessToken, xeroTenantId, itemID, unitdp, cancellationToken);
        return response;
    }
    public async Task<HistoryRecords> GetItemHistoryAsync(Guid itemID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetItemHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, itemID, cancellationToken);
    }

    public async Task<HistoryRecords> GetItemHistoryAsync(string accessToken, string xeroTenantId, Guid itemID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await GetItemHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, itemID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<HistoryRecords>> GetItemHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid itemID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await accountingXeroClient.GetItemHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, itemID, cancellationToken);
        return response;
    }
    public async Task<Items> GetItemsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetItemsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, unitdp, cancellationToken);
    }

    public async Task<Items> GetItemsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Items> response = await GetItemsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, unitdp, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Items>> GetItemsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Items> response = await accountingXeroClient.GetItemsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, unitdp, cancellationToken);
        return response;
    }
    public async Task<Journals> GetJournalAsync(Guid journalID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetJournalAsync(accessToken, xeroExtendedConfiguration.TenantId, journalID, cancellationToken);
    }

    public async Task<Journals> GetJournalAsync(string accessToken, string xeroTenantId, Guid journalID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Journals> response = await GetJournalAsyncWithHttpInfo(accessToken, xeroTenantId, journalID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Journals>> GetJournalAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid journalID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Journals> response = await accountingXeroClient.GetJournalAsyncWithHttpInfo(accessToken, xeroTenantId, journalID, cancellationToken);
        return response;
    }
    public async Task<Journals> GetJournalByNumberAsync(int journalNumber, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetJournalByNumberAsync(accessToken, xeroExtendedConfiguration.TenantId, journalNumber, cancellationToken);
    }

    public async Task<Journals> GetJournalByNumberAsync(string accessToken, string xeroTenantId, int journalNumber, CancellationToken cancellationToken = default)
    {
        ApiResponse<Journals> response = await GetJournalByNumberAsyncWithHttpInfo(accessToken, xeroTenantId, journalNumber, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Journals>> GetJournalByNumberAsyncWithHttpInfo(string accessToken, string xeroTenantId, int journalNumber, CancellationToken cancellationToken = default)
    {
        ApiResponse<Journals> response = await accountingXeroClient.GetJournalByNumberAsyncWithHttpInfo(accessToken, xeroTenantId, journalNumber, cancellationToken);
        return response;
    }
    public async Task<Journals> GetJournalsAsync(DateTime? ifModifiedSince = null, int? offset = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetJournalsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, offset, paymentsOnly, cancellationToken);
    }

    public async Task<Journals> GetJournalsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, int? offset = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Journals> response = await GetJournalsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, offset, paymentsOnly, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Journals>> GetJournalsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, int? offset = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Journals> response = await accountingXeroClient.GetJournalsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, offset, paymentsOnly, cancellationToken);
        return response;
    }
    public async Task<LinkedTransactions> GetLinkedTransactionAsync(Guid linkedTransactionID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetLinkedTransactionAsync(accessToken, xeroExtendedConfiguration.TenantId, linkedTransactionID, cancellationToken);
    }

    public async Task<LinkedTransactions> GetLinkedTransactionAsync(string accessToken, string xeroTenantId, Guid linkedTransactionID, CancellationToken cancellationToken = default)
    {
        ApiResponse<LinkedTransactions> response = await GetLinkedTransactionAsyncWithHttpInfo(accessToken, xeroTenantId, linkedTransactionID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LinkedTransactions>> GetLinkedTransactionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid linkedTransactionID, CancellationToken cancellationToken = default)
    {
        ApiResponse<LinkedTransactions> response = await accountingXeroClient.GetLinkedTransactionAsyncWithHttpInfo(accessToken, xeroTenantId, linkedTransactionID, cancellationToken);
        return response;
    }
    public async Task<LinkedTransactions> GetLinkedTransactionsAsync(int? page = null, Guid? linkedTransactionID = null, Guid? sourceTransactionID = null, Guid? contactID = null, string? status = null, Guid? targetTransactionID = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetLinkedTransactionsAsync(accessToken, xeroExtendedConfiguration.TenantId, page, linkedTransactionID, sourceTransactionID, contactID, status, targetTransactionID, cancellationToken);
    }

    public async Task<LinkedTransactions> GetLinkedTransactionsAsync(string accessToken, string xeroTenantId, int? page = null, Guid? linkedTransactionID = null, Guid? sourceTransactionID = null, Guid? contactID = null, string? status = null, Guid? targetTransactionID = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LinkedTransactions> response = await GetLinkedTransactionsAsyncWithHttpInfo(accessToken, xeroTenantId, page, linkedTransactionID, sourceTransactionID, contactID, status, targetTransactionID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LinkedTransactions>> GetLinkedTransactionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, Guid? linkedTransactionID = null, Guid? sourceTransactionID = null, Guid? contactID = null, string? status = null, Guid? targetTransactionID = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LinkedTransactions> response = await accountingXeroClient.GetLinkedTransactionsAsyncWithHttpInfo(accessToken, xeroTenantId, page, linkedTransactionID, sourceTransactionID, contactID, status, targetTransactionID, cancellationToken);
        return response;
    }
    public async Task<ManualJournals> GetManualJournalAsync(Guid manualJournalID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetManualJournalAsync(accessToken, xeroExtendedConfiguration.TenantId, manualJournalID, cancellationToken);
    }

    public async Task<ManualJournals> GetManualJournalAsync(string accessToken, string xeroTenantId, Guid manualJournalID, CancellationToken cancellationToken = default)
    {
        ApiResponse<ManualJournals> response = await GetManualJournalAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournalID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ManualJournals>> GetManualJournalAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid manualJournalID, CancellationToken cancellationToken = default)
    {
        ApiResponse<ManualJournals> response = await accountingXeroClient.GetManualJournalAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournalID, cancellationToken);
        return response;
    }
    public async Task<Stream> GetManualJournalAttachmentByFileNameAsync(Guid manualJournalID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetManualJournalAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, manualJournalID, fileName, contentType, cancellationToken);
    }

    public async Task<Stream> GetManualJournalAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid manualJournalID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetManualJournalAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournalID, fileName, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetManualJournalAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid manualJournalID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetManualJournalAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournalID, fileName, contentType, cancellationToken);
        return response;
    }
    public async Task<Stream> GetManualJournalAttachmentByIdAsync(Guid manualJournalID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetManualJournalAttachmentByIdAsync(accessToken, xeroExtendedConfiguration.TenantId, manualJournalID, attachmentID, contentType, cancellationToken);
    }

    public async Task<Stream> GetManualJournalAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid manualJournalID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetManualJournalAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournalID, attachmentID, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetManualJournalAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid manualJournalID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetManualJournalAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournalID, attachmentID, contentType, cancellationToken);
        return response;
    }
    public async Task<Attachments> GetManualJournalAttachmentsAsync(Guid manualJournalID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetManualJournalAttachmentsAsync(accessToken, xeroExtendedConfiguration.TenantId, manualJournalID, cancellationToken);
    }

    public async Task<Attachments> GetManualJournalAttachmentsAsync(string accessToken, string xeroTenantId, Guid manualJournalID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await GetManualJournalAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournalID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> GetManualJournalAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid manualJournalID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.GetManualJournalAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournalID, cancellationToken);
        return response;
    }
    public async Task<ManualJournals> GetManualJournalsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetManualJournalsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, pageSize, cancellationToken);
    }

    public async Task<ManualJournals> GetManualJournalsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ManualJournals> response = await GetManualJournalsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, pageSize, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ManualJournals>> GetManualJournalsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ManualJournals> response = await accountingXeroClient.GetManualJournalsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, pageSize, cancellationToken);
        return response;
    }
    public async Task<HistoryRecords> GetManualJournalsHistoryAsync(Guid manualJournalID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetManualJournalsHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, manualJournalID, cancellationToken);
    }

    public async Task<HistoryRecords> GetManualJournalsHistoryAsync(string accessToken, string xeroTenantId, Guid manualJournalID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await GetManualJournalsHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournalID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<HistoryRecords>> GetManualJournalsHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid manualJournalID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await accountingXeroClient.GetManualJournalsHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournalID, cancellationToken);
        return response;
    }
    public async Task<OnlineInvoices> GetOnlineInvoiceAsync(Guid invoiceID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetOnlineInvoiceAsync(accessToken, xeroExtendedConfiguration.TenantId, invoiceID, cancellationToken);
    }

    public async Task<OnlineInvoices> GetOnlineInvoiceAsync(string accessToken, string xeroTenantId, Guid invoiceID, CancellationToken cancellationToken = default)
    {
        ApiResponse<OnlineInvoices> response = await GetOnlineInvoiceAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<OnlineInvoices>> GetOnlineInvoiceAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, CancellationToken cancellationToken = default)
    {
        ApiResponse<OnlineInvoices> response = await accountingXeroClient.GetOnlineInvoiceAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, cancellationToken);
        return response;
    }
    public async Task<Actions> GetOrganisationActionsAsync(CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetOrganisationActionsAsync(accessToken, xeroExtendedConfiguration.TenantId, cancellationToken);
    }

    public async Task<Actions> GetOrganisationActionsAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        ApiResponse<Actions> response = await GetOrganisationActionsAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Actions>> GetOrganisationActionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        ApiResponse<Actions> response = await accountingXeroClient.GetOrganisationActionsAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response;
    }
    public async Task<CISOrgSettings> GetOrganisationCISSettingsAsync(Guid organisationID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetOrganisationCISSettingsAsync(accessToken, xeroExtendedConfiguration.TenantId, organisationID, cancellationToken);
    }

    public async Task<CISOrgSettings> GetOrganisationCISSettingsAsync(string accessToken, string xeroTenantId, Guid organisationID, CancellationToken cancellationToken = default)
    {
        ApiResponse<CISOrgSettings> response = await GetOrganisationCISSettingsAsyncWithHttpInfo(accessToken, xeroTenantId, organisationID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<CISOrgSettings>> GetOrganisationCISSettingsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid organisationID, CancellationToken cancellationToken = default)
    {
        ApiResponse<CISOrgSettings> response = await accountingXeroClient.GetOrganisationCISSettingsAsyncWithHttpInfo(accessToken, xeroTenantId, organisationID, cancellationToken);
        return response;
    }
    public async Task<Organisations> GetOrganisationsAsync(CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetOrganisationsAsync(accessToken, xeroExtendedConfiguration.TenantId, cancellationToken);
    }

    public async Task<Organisations> GetOrganisationsAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        ApiResponse<Organisations> response = await GetOrganisationsAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Organisations>> GetOrganisationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        ApiResponse<Organisations> response = await accountingXeroClient.GetOrganisationsAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response;
    }
    public async Task<Overpayments> GetOverpaymentAsync(Guid overpaymentID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetOverpaymentAsync(accessToken, xeroExtendedConfiguration.TenantId, overpaymentID, cancellationToken);
    }

    public async Task<Overpayments> GetOverpaymentAsync(string accessToken, string xeroTenantId, Guid overpaymentID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Overpayments> response = await GetOverpaymentAsyncWithHttpInfo(accessToken, xeroTenantId, overpaymentID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Overpayments>> GetOverpaymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid overpaymentID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Overpayments> response = await accountingXeroClient.GetOverpaymentAsyncWithHttpInfo(accessToken, xeroTenantId, overpaymentID, cancellationToken);
        return response;
    }
    public async Task<HistoryRecords> GetOverpaymentHistoryAsync(Guid overpaymentID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetOverpaymentHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, overpaymentID, cancellationToken);
    }

    public async Task<HistoryRecords> GetOverpaymentHistoryAsync(string accessToken, string xeroTenantId, Guid overpaymentID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await GetOverpaymentHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, overpaymentID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<HistoryRecords>> GetOverpaymentHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid overpaymentID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await accountingXeroClient.GetOverpaymentHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, overpaymentID, cancellationToken);
        return response;
    }
    public async Task<Overpayments> GetOverpaymentsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetOverpaymentsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, unitdp, pageSize, cancellationToken);
    }

    public async Task<Overpayments> GetOverpaymentsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Overpayments> response = await GetOverpaymentsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, unitdp, pageSize, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Overpayments>> GetOverpaymentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Overpayments> response = await accountingXeroClient.GetOverpaymentsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, unitdp, pageSize, cancellationToken);
        return response;
    }
    public async Task<Payments> GetPaymentAsync(Guid paymentID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPaymentAsync(accessToken, xeroExtendedConfiguration.TenantId, paymentID, cancellationToken);
    }

    public async Task<Payments> GetPaymentAsync(string accessToken, string xeroTenantId, Guid paymentID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Payments> response = await GetPaymentAsyncWithHttpInfo(accessToken, xeroTenantId, paymentID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Payments>> GetPaymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid paymentID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Payments> response = await accountingXeroClient.GetPaymentAsyncWithHttpInfo(accessToken, xeroTenantId, paymentID, cancellationToken);
        return response;
    }
    public async Task<HistoryRecords> GetPaymentHistoryAsync(Guid paymentID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPaymentHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, paymentID, cancellationToken);
    }

    public async Task<HistoryRecords> GetPaymentHistoryAsync(string accessToken, string xeroTenantId, Guid paymentID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await GetPaymentHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, paymentID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<HistoryRecords>> GetPaymentHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid paymentID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await accountingXeroClient.GetPaymentHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, paymentID, cancellationToken);
        return response;
    }
    public async Task<Payments> GetPaymentsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPaymentsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, pageSize, cancellationToken);
    }

    public async Task<Payments> GetPaymentsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Payments> response = await GetPaymentsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, pageSize, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Payments>> GetPaymentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Payments> response = await accountingXeroClient.GetPaymentsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, pageSize, cancellationToken);
        return response;
    }
    public async Task<PaymentServices> GetPaymentServicesAsync(CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPaymentServicesAsync(accessToken, xeroExtendedConfiguration.TenantId, cancellationToken);
    }

    public async Task<PaymentServices> GetPaymentServicesAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        ApiResponse<PaymentServices> response = await GetPaymentServicesAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PaymentServices>> GetPaymentServicesAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        ApiResponse<PaymentServices> response = await accountingXeroClient.GetPaymentServicesAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response;
    }
    public async Task<Prepayments> GetPrepaymentAsync(Guid prepaymentID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPrepaymentAsync(accessToken, xeroExtendedConfiguration.TenantId, prepaymentID, cancellationToken);
    }

    public async Task<Prepayments> GetPrepaymentAsync(string accessToken, string xeroTenantId, Guid prepaymentID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Prepayments> response = await GetPrepaymentAsyncWithHttpInfo(accessToken, xeroTenantId, prepaymentID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Prepayments>> GetPrepaymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid prepaymentID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Prepayments> response = await accountingXeroClient.GetPrepaymentAsyncWithHttpInfo(accessToken, xeroTenantId, prepaymentID, cancellationToken);
        return response;
    }
    public async Task<HistoryRecords> GetPrepaymentHistoryAsync(Guid prepaymentID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPrepaymentHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, prepaymentID, cancellationToken);
    }

    public async Task<HistoryRecords> GetPrepaymentHistoryAsync(string accessToken, string xeroTenantId, Guid prepaymentID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await GetPrepaymentHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, prepaymentID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<HistoryRecords>> GetPrepaymentHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid prepaymentID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await accountingXeroClient.GetPrepaymentHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, prepaymentID, cancellationToken);
        return response;
    }
    public async Task<Prepayments> GetPrepaymentsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPrepaymentsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, page, unitdp, pageSize, cancellationToken);
    }

    public async Task<Prepayments> GetPrepaymentsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Prepayments> response = await GetPrepaymentsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, unitdp, pageSize, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Prepayments>> GetPrepaymentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Prepayments> response = await accountingXeroClient.GetPrepaymentsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, page, unitdp, pageSize, cancellationToken);
        return response;
    }

    public async Task<Stream> GetPurchaseOrderAsPdfAsync(Guid purchaseOrderID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPurchaseOrderAsPdfAsync(accessToken, xeroExtendedConfiguration.TenantId, purchaseOrderID, cancellationToken);
    }

    public async Task<Stream> GetPurchaseOrderAsPdfAsync(string accessToken, string xeroTenantId, Guid purchaseOrderID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetPurchaseOrderAsPdfAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetPurchaseOrderAsPdfAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid purchaseOrderID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetPurchaseOrderAsPdfAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, cancellationToken);
        return response;
    }

    public async Task<PurchaseOrders> GetPurchaseOrderAsync(Guid purchaseOrderID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPurchaseOrderAsync(accessToken, xeroExtendedConfiguration.TenantId, purchaseOrderID, cancellationToken);
    }

    public async Task<PurchaseOrders> GetPurchaseOrderAsync(string accessToken, string xeroTenantId, Guid purchaseOrderID, CancellationToken cancellationToken = default)
    {
        ApiResponse<PurchaseOrders> response = await GetPurchaseOrderAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PurchaseOrders>> GetPurchaseOrderAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid purchaseOrderID, CancellationToken cancellationToken = default)
    {
        ApiResponse<PurchaseOrders> response = await accountingXeroClient.GetPurchaseOrderAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, cancellationToken);
        return response;
    }
    public async Task<Stream> GetPurchaseOrderAttachmentByFileNameAsync(Guid purchaseOrderID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPurchaseOrderAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, purchaseOrderID, fileName, contentType, cancellationToken);
    }

    public async Task<Stream> GetPurchaseOrderAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid purchaseOrderID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetPurchaseOrderAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, fileName, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetPurchaseOrderAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid purchaseOrderID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetPurchaseOrderAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, fileName, contentType, cancellationToken);
        return response;
    }
    public async Task<Stream> GetPurchaseOrderAttachmentByIdAsync(Guid purchaseOrderID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPurchaseOrderAttachmentByIdAsync(accessToken, xeroExtendedConfiguration.TenantId, purchaseOrderID, attachmentID, contentType, cancellationToken);
    }

    public async Task<Stream> GetPurchaseOrderAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid purchaseOrderID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetPurchaseOrderAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, attachmentID, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetPurchaseOrderAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid purchaseOrderID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetPurchaseOrderAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, attachmentID, contentType, cancellationToken);
        return response;
    }
    public async Task<Attachments> GetPurchaseOrderAttachmentsAsync(Guid purchaseOrderID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPurchaseOrderAttachmentsAsync(accessToken, xeroExtendedConfiguration.TenantId, purchaseOrderID, cancellationToken);
    }

    public async Task<Attachments> GetPurchaseOrderAttachmentsAsync(string accessToken, string xeroTenantId, Guid purchaseOrderID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await GetPurchaseOrderAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> GetPurchaseOrderAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid purchaseOrderID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.GetPurchaseOrderAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, cancellationToken);
        return response;
    }
    public async Task<PurchaseOrders> GetPurchaseOrderByNumberAsync(string purchaseOrderNumber, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPurchaseOrderByNumberAsync(accessToken, xeroExtendedConfiguration.TenantId, purchaseOrderNumber, cancellationToken);
    }

    public async Task<PurchaseOrders> GetPurchaseOrderByNumberAsync(string accessToken, string xeroTenantId, string purchaseOrderNumber, CancellationToken cancellationToken = default)
    {
        ApiResponse<PurchaseOrders> response = await GetPurchaseOrderByNumberAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderNumber, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PurchaseOrders>> GetPurchaseOrderByNumberAsyncWithHttpInfo(string accessToken, string xeroTenantId, string purchaseOrderNumber, CancellationToken cancellationToken = default)
    {
        ApiResponse<PurchaseOrders> response = await accountingXeroClient.GetPurchaseOrderByNumberAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderNumber, cancellationToken);
        return response;
    }
    public async Task<HistoryRecords> GetPurchaseOrderHistoryAsync(Guid purchaseOrderID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPurchaseOrderHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, purchaseOrderID, cancellationToken);
    }

    public async Task<HistoryRecords> GetPurchaseOrderHistoryAsync(string accessToken, string xeroTenantId, Guid purchaseOrderID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await GetPurchaseOrderHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<HistoryRecords>> GetPurchaseOrderHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid purchaseOrderID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await accountingXeroClient.GetPurchaseOrderHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, cancellationToken);
        return response;
    }
    public async Task<PurchaseOrders> GetPurchaseOrdersAsync(DateTime? ifModifiedSince = null, string? status = null, string? dateFrom = null, string? dateTo = null, string? order = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetPurchaseOrdersAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, status, dateFrom, dateTo, order, page, pageSize, cancellationToken);
    }

    public async Task<PurchaseOrders> GetPurchaseOrdersAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? status = null, string? dateFrom = null, string? dateTo = null, string? order = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PurchaseOrders> response = await GetPurchaseOrdersAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, status, dateFrom, dateTo, order, page, pageSize, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PurchaseOrders>> GetPurchaseOrdersAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? status = null, string? dateFrom = null, string? dateTo = null, string? order = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PurchaseOrders> response = await accountingXeroClient.GetPurchaseOrdersAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, status, dateFrom, dateTo, order, page, pageSize, cancellationToken);
        return response;
    }
    public async Task<Stream> GetQuoteAsPdfAsync(Guid quoteID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetQuoteAsPdfAsync(accessToken, xeroExtendedConfiguration.TenantId, quoteID, cancellationToken);
    }

    public async Task<Stream> GetQuoteAsPdfAsync(string accessToken, string xeroTenantId, Guid quoteID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetQuoteAsPdfAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetQuoteAsPdfAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetQuoteAsPdfAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, cancellationToken);
        return response;
    }
    public async Task<Quotes> GetQuoteAsync(Guid quoteID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetQuoteAsync(accessToken, xeroExtendedConfiguration.TenantId, quoteID, cancellationToken);
    }

    public async Task<Quotes> GetQuoteAsync(string accessToken, string xeroTenantId, Guid quoteID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Quotes> response = await GetQuoteAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Quotes>> GetQuoteAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Quotes> response = await accountingXeroClient.GetQuoteAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, cancellationToken);
        return response;
    }
    public async Task<Stream> GetQuoteAttachmentByFileNameAsync(Guid quoteID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetQuoteAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, quoteID, fileName, contentType, cancellationToken);
    }

    public async Task<Stream> GetQuoteAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid quoteID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetQuoteAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, fileName, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetQuoteAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetQuoteAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, fileName, contentType, cancellationToken);
        return response;
    }
    public async Task<Stream> GetQuoteAttachmentByIdAsync(Guid quoteID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetQuoteAttachmentByIdAsync(accessToken, xeroExtendedConfiguration.TenantId, quoteID, attachmentID, contentType, cancellationToken);
    }

    public async Task<Stream> GetQuoteAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid quoteID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetQuoteAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, attachmentID, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetQuoteAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetQuoteAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, attachmentID, contentType, cancellationToken);
        return response;
    }
    public async Task<Attachments> GetQuoteAttachmentsAsync(Guid quoteID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetQuoteAttachmentsAsync(accessToken, xeroExtendedConfiguration.TenantId, quoteID, cancellationToken);
    }

    public async Task<Attachments> GetQuoteAttachmentsAsync(string accessToken, string xeroTenantId, Guid quoteID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await GetQuoteAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> GetQuoteAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.GetQuoteAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, cancellationToken);
        return response;
    }
    public async Task<HistoryRecords> GetQuoteHistoryAsync(Guid quoteID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetQuoteHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, quoteID, cancellationToken);
    }

    public async Task<HistoryRecords> GetQuoteHistoryAsync(string accessToken, string xeroTenantId, Guid quoteID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await GetQuoteHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<HistoryRecords>> GetQuoteHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await accountingXeroClient.GetQuoteHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, cancellationToken);
        return response;
    }
    public async Task<Quotes> GetQuotesAsync(DateTime? ifModifiedSince = null, DateTime? dateFrom = null, DateTime? dateTo = null, DateTime? expiryDateFrom = null, DateTime? expiryDateTo = null, Guid? contactID = null, string? status = null, int? page = null, string? order = null, string? quoteNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetQuotesAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, dateFrom, dateTo, expiryDateFrom, expiryDateTo, contactID, status, page, order, quoteNumber, cancellationToken);
    }

    public async Task<Quotes> GetQuotesAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, DateTime? dateFrom = null, DateTime? dateTo = null, DateTime? expiryDateFrom = null, DateTime? expiryDateTo = null, Guid? contactID = null, string? status = null, int? page = null, string? order = null, string? quoteNumber = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Quotes> response = await GetQuotesAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, dateFrom, dateTo, expiryDateFrom, expiryDateTo, contactID, status, page, order, quoteNumber, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Quotes>> GetQuotesAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, DateTime? dateFrom = null, DateTime? dateTo = null, DateTime? expiryDateFrom = null, DateTime? expiryDateTo = null, Guid? contactID = null, string? status = null, int? page = null, string? order = null, string? quoteNumber = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Quotes> response = await accountingXeroClient.GetQuotesAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, dateFrom, dateTo, expiryDateFrom, expiryDateTo, contactID, status, page, order, quoteNumber, cancellationToken);
        return response;
    }
    public async Task<Receipts> GetReceiptAsync(Guid receiptID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReceiptAsync(accessToken, xeroExtendedConfiguration.TenantId, receiptID, unitdp, cancellationToken);
    }

    public async Task<Receipts> GetReceiptAsync(string accessToken, string xeroTenantId, Guid receiptID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Receipts> response = await GetReceiptAsyncWithHttpInfo(accessToken, xeroTenantId, receiptID, unitdp, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Receipts>> GetReceiptAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid receiptID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Receipts> response = await accountingXeroClient.GetReceiptAsyncWithHttpInfo(accessToken, xeroTenantId, receiptID, unitdp, cancellationToken);
        return response;
    }
    public async Task<Stream> GetReceiptAttachmentByFileNameAsync(Guid receiptID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReceiptAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, receiptID, fileName, contentType, cancellationToken);
    }

    public async Task<Stream> GetReceiptAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid receiptID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetReceiptAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, receiptID, fileName, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetReceiptAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid receiptID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetReceiptAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, receiptID, fileName, contentType, cancellationToken);
        return response;
    }
    public async Task<Stream> GetReceiptAttachmentByIdAsync(Guid receiptID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReceiptAttachmentByIdAsync(accessToken, xeroExtendedConfiguration.TenantId, receiptID, attachmentID, contentType, cancellationToken);
    }

    public async Task<Stream> GetReceiptAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid receiptID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetReceiptAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, receiptID, attachmentID, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetReceiptAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid receiptID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetReceiptAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, receiptID, attachmentID, contentType, cancellationToken);
        return response;
    }
    public async Task<Attachments> GetReceiptAttachmentsAsync(Guid receiptID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReceiptAttachmentsAsync(accessToken, xeroExtendedConfiguration.TenantId, receiptID, cancellationToken);
    }

    public async Task<Attachments> GetReceiptAttachmentsAsync(string accessToken, string xeroTenantId, Guid receiptID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await GetReceiptAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, receiptID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> GetReceiptAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid receiptID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.GetReceiptAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, receiptID, cancellationToken);
        return response;
    }
    public async Task<HistoryRecords> GetReceiptHistoryAsync(Guid receiptID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReceiptHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, receiptID, cancellationToken);
    }

    public async Task<HistoryRecords> GetReceiptHistoryAsync(string accessToken, string xeroTenantId, Guid receiptID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await GetReceiptHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, receiptID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<HistoryRecords>> GetReceiptHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid receiptID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await accountingXeroClient.GetReceiptHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, receiptID, cancellationToken);
        return response;
    }
    public async Task<Receipts> GetReceiptsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReceiptsAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, unitdp, cancellationToken);
    }

    public async Task<Receipts> GetReceiptsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Receipts> response = await GetReceiptsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, unitdp, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Receipts>> GetReceiptsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Receipts> response = await accountingXeroClient.GetReceiptsAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, unitdp, cancellationToken);
        return response;
    }
    public async Task<RepeatingInvoices> GetRepeatingInvoiceAsync(Guid repeatingInvoiceID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetRepeatingInvoiceAsync(accessToken, xeroExtendedConfiguration.TenantId, repeatingInvoiceID, cancellationToken);
    }

    public async Task<RepeatingInvoices> GetRepeatingInvoiceAsync(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, CancellationToken cancellationToken = default)
    {
        ApiResponse<RepeatingInvoices> response = await GetRepeatingInvoiceAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoiceID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<RepeatingInvoices>> GetRepeatingInvoiceAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, CancellationToken cancellationToken = default)
    {
        ApiResponse<RepeatingInvoices> response = await accountingXeroClient.GetRepeatingInvoiceAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoiceID, cancellationToken);
        return response;
    }
    public async Task<Stream> GetRepeatingInvoiceAttachmentByFileNameAsync(Guid repeatingInvoiceID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetRepeatingInvoiceAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, repeatingInvoiceID, fileName, contentType, cancellationToken);
    }

    public async Task<Stream> GetRepeatingInvoiceAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetRepeatingInvoiceAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoiceID, fileName, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetRepeatingInvoiceAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetRepeatingInvoiceAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoiceID, fileName, contentType, cancellationToken);
        return response;
    }
    public async Task<Stream> GetRepeatingInvoiceAttachmentByIdAsync(Guid repeatingInvoiceID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetRepeatingInvoiceAttachmentByIdAsync(accessToken, xeroExtendedConfiguration.TenantId, repeatingInvoiceID, attachmentID, contentType, cancellationToken);
    }

    public async Task<Stream> GetRepeatingInvoiceAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await GetRepeatingInvoiceAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoiceID, attachmentID, contentType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Stream>> GetRepeatingInvoiceAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        ApiResponse<Stream> response = await accountingXeroClient.GetRepeatingInvoiceAttachmentByIdAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoiceID, attachmentID, contentType, cancellationToken);
        return response;
    }
    public async Task<Attachments> GetRepeatingInvoiceAttachmentsAsync(Guid repeatingInvoiceID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetRepeatingInvoiceAttachmentsAsync(accessToken, xeroExtendedConfiguration.TenantId, repeatingInvoiceID, cancellationToken);
    }

    public async Task<Attachments> GetRepeatingInvoiceAttachmentsAsync(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await GetRepeatingInvoiceAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoiceID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> GetRepeatingInvoiceAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.GetRepeatingInvoiceAttachmentsAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoiceID, cancellationToken);
        return response;
    }
    public async Task<HistoryRecords> GetRepeatingInvoiceHistoryAsync(Guid repeatingInvoiceID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetRepeatingInvoiceHistoryAsync(accessToken, xeroExtendedConfiguration.TenantId, repeatingInvoiceID, cancellationToken);
    }

    public async Task<HistoryRecords> GetRepeatingInvoiceHistoryAsync(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await GetRepeatingInvoiceHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoiceID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<HistoryRecords>> GetRepeatingInvoiceHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, CancellationToken cancellationToken = default)
    {
        ApiResponse<HistoryRecords> response = await accountingXeroClient.GetRepeatingInvoiceHistoryAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoiceID, cancellationToken);
        return response;
    }
    public async Task<RepeatingInvoices> GetRepeatingInvoicesAsync(string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetRepeatingInvoicesAsync(accessToken, xeroExtendedConfiguration.TenantId, where, order, cancellationToken);
    }

    public async Task<RepeatingInvoices> GetRepeatingInvoicesAsync(string accessToken, string xeroTenantId, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<RepeatingInvoices> response = await GetRepeatingInvoicesAsyncWithHttpInfo(accessToken, xeroTenantId, where, order, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<RepeatingInvoices>> GetRepeatingInvoicesAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<RepeatingInvoices> response = await accountingXeroClient.GetRepeatingInvoicesAsyncWithHttpInfo(accessToken, xeroTenantId, where, order, cancellationToken);
        return response;
    }
    public async Task<ReportWithRows> GetReportAgedPayablesByContactAsync(Guid contactId, DateTime? date = null, DateTime? fromDate = null, DateTime? toDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReportAgedPayablesByContactAsync(accessToken, xeroExtendedConfiguration.TenantId, contactId, date, fromDate, toDate, cancellationToken);
    }

    public async Task<ReportWithRows> GetReportAgedPayablesByContactAsync(string accessToken, string xeroTenantId, Guid contactId, DateTime? date = null, DateTime? fromDate = null, DateTime? toDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await GetReportAgedPayablesByContactAsyncWithHttpInfo(accessToken, xeroTenantId, contactId, date, fromDate, toDate, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ReportWithRows>> GetReportAgedPayablesByContactAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactId, DateTime? date = null, DateTime? fromDate = null, DateTime? toDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await accountingXeroClient.GetReportAgedPayablesByContactAsyncWithHttpInfo(accessToken, xeroTenantId, contactId, date, fromDate, toDate, cancellationToken);
        return response;
    }
    public async Task<ReportWithRows> GetReportAgedReceivablesByContactAsync(Guid contactId, DateTime? date = null, DateTime? fromDate = null, DateTime? toDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReportAgedReceivablesByContactAsync(accessToken, xeroExtendedConfiguration.TenantId, contactId, date, fromDate, toDate, cancellationToken);
    }

    public async Task<ReportWithRows> GetReportAgedReceivablesByContactAsync(string accessToken, string xeroTenantId, Guid contactId, DateTime? date = null, DateTime? fromDate = null, DateTime? toDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await GetReportAgedReceivablesByContactAsyncWithHttpInfo(accessToken, xeroTenantId, contactId, date, fromDate, toDate, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ReportWithRows>> GetReportAgedReceivablesByContactAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactId, DateTime? date = null, DateTime? fromDate = null, DateTime? toDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await accountingXeroClient.GetReportAgedReceivablesByContactAsyncWithHttpInfo(accessToken, xeroTenantId, contactId, date, fromDate, toDate, cancellationToken);
        return response;
    }
    public async Task<ReportWithRows> GetReportBalanceSheetAsync(DateTime? date = null, int? periods = null, string? timeframe = null, string? trackingOptionID1 = null, string? trackingOptionID2 = null, bool? standardLayout = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReportBalanceSheetAsync(accessToken, xeroExtendedConfiguration.TenantId, date, periods, timeframe, trackingOptionID1, trackingOptionID2, standardLayout, paymentsOnly, cancellationToken);
    }

    public async Task<ReportWithRows> GetReportBalanceSheetAsync(string accessToken, string xeroTenantId, DateTime? date = null, int? periods = null, string? timeframe = null, string? trackingOptionID1 = null, string? trackingOptionID2 = null, bool? standardLayout = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await GetReportBalanceSheetAsyncWithHttpInfo(accessToken, xeroTenantId, date, periods, timeframe, trackingOptionID1, trackingOptionID2, standardLayout, paymentsOnly, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ReportWithRows>> GetReportBalanceSheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? date = null, int? periods = null, string? timeframe = null, string? trackingOptionID1 = null, string? trackingOptionID2 = null, bool? standardLayout = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await accountingXeroClient.GetReportBalanceSheetAsyncWithHttpInfo(accessToken, xeroTenantId, date, periods, timeframe, trackingOptionID1, trackingOptionID2, standardLayout, paymentsOnly, cancellationToken);
        return response;
    }
    public async Task<ReportWithRows> GetReportBankSummaryAsync(DateTime? fromDate = null, DateTime? toDate = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReportBankSummaryAsync(accessToken, xeroExtendedConfiguration.TenantId, fromDate, toDate, cancellationToken);
    }

    public async Task<ReportWithRows> GetReportBankSummaryAsync(string accessToken, string xeroTenantId, DateTime? fromDate = null, DateTime? toDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await GetReportBankSummaryAsyncWithHttpInfo(accessToken, xeroTenantId, fromDate, toDate, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ReportWithRows>> GetReportBankSummaryAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? fromDate = null, DateTime? toDate = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await accountingXeroClient.GetReportBankSummaryAsyncWithHttpInfo(accessToken, xeroTenantId, fromDate, toDate, cancellationToken);
        return response;
    }
    public async Task<ReportWithRows> GetReportBudgetSummaryAsync(DateTime? date = null, int? periods = null, int? timeframe = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReportBudgetSummaryAsync(accessToken, xeroExtendedConfiguration.TenantId, date, periods, timeframe, cancellationToken);
    }

    public async Task<ReportWithRows> GetReportBudgetSummaryAsync(string accessToken, string xeroTenantId, DateTime? date = null, int? periods = null, int? timeframe = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await GetReportBudgetSummaryAsyncWithHttpInfo(accessToken, xeroTenantId, date, periods, timeframe, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ReportWithRows>> GetReportBudgetSummaryAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? date = null, int? periods = null, int? timeframe = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await accountingXeroClient.GetReportBudgetSummaryAsyncWithHttpInfo(accessToken, xeroTenantId, date, periods, timeframe, cancellationToken);
        return response;
    }
    public async Task<ReportWithRows> GetReportExecutiveSummaryAsync(DateTime? date = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReportExecutiveSummaryAsync(accessToken, xeroExtendedConfiguration.TenantId, date, cancellationToken);
    }

    public async Task<ReportWithRows> GetReportExecutiveSummaryAsync(string accessToken, string xeroTenantId, DateTime? date = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await GetReportExecutiveSummaryAsyncWithHttpInfo(accessToken, xeroTenantId, date, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ReportWithRows>> GetReportExecutiveSummaryAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? date = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await accountingXeroClient.GetReportExecutiveSummaryAsyncWithHttpInfo(accessToken, xeroTenantId, date, cancellationToken);
        return response;
    }
    public async Task<ReportWithRows> GetReportFromIdAsync(string reportID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReportFromIdAsync(accessToken, xeroExtendedConfiguration.TenantId, reportID, cancellationToken);
    }

    public async Task<ReportWithRows> GetReportFromIdAsync(string accessToken, string xeroTenantId, string reportID, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await GetReportFromIdAsyncWithHttpInfo(accessToken, xeroTenantId, reportID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ReportWithRows>> GetReportFromIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, string reportID, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await accountingXeroClient.GetReportFromIdAsyncWithHttpInfo(accessToken, xeroTenantId, reportID, cancellationToken);
        return response;
    }
    public async Task<ReportWithRows> GetReportProfitAndLossAsync(DateTime? fromDate = null, DateTime? toDate = null, int? periods = null, string? timeframe = null, string? trackingCategoryID = null, string? trackingCategoryID2 = null, string? trackingOptionID = null, string? trackingOptionID2 = null, bool? standardLayout = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReportProfitAndLossAsync(accessToken, xeroExtendedConfiguration.TenantId, fromDate, toDate, periods, timeframe, trackingCategoryID, trackingCategoryID2, trackingOptionID, trackingOptionID2, standardLayout, paymentsOnly, cancellationToken);
    }

    public async Task<ReportWithRows> GetReportProfitAndLossAsync(string accessToken, string xeroTenantId, DateTime? fromDate = null, DateTime? toDate = null, int? periods = null, string? timeframe = null, string? trackingCategoryID = null, string? trackingCategoryID2 = null, string? trackingOptionID = null, string? trackingOptionID2 = null, bool? standardLayout = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await GetReportProfitAndLossAsyncWithHttpInfo(accessToken, xeroTenantId, fromDate, toDate, periods, timeframe, trackingCategoryID, trackingCategoryID2, trackingOptionID, trackingOptionID2, standardLayout, paymentsOnly, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ReportWithRows>> GetReportProfitAndLossAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? fromDate = null, DateTime? toDate = null, int? periods = null, string? timeframe = null, string? trackingCategoryID = null, string? trackingCategoryID2 = null, string? trackingOptionID = null, string? trackingOptionID2 = null, bool? standardLayout = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await accountingXeroClient.GetReportProfitAndLossAsyncWithHttpInfo(accessToken, xeroTenantId, fromDate, toDate, periods, timeframe, trackingCategoryID, trackingCategoryID2, trackingOptionID, trackingOptionID2, standardLayout, paymentsOnly, cancellationToken);
        return response;
    }
    public async Task<ReportWithRows> GetReportsListAsync(CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReportsListAsync(accessToken, xeroExtendedConfiguration.TenantId, cancellationToken);
    }

    public async Task<ReportWithRows> GetReportsListAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await GetReportsListAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ReportWithRows>> GetReportsListAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await accountingXeroClient.GetReportsListAsyncWithHttpInfo(accessToken, xeroTenantId, cancellationToken);
        return response;
    }
    public async Task<Reports> GetReportTenNinetyNineAsync(string? reportYear = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReportTenNinetyNineAsync(accessToken, xeroExtendedConfiguration.TenantId, reportYear, cancellationToken);
    }

    public async Task<Reports> GetReportTenNinetyNineAsync(string accessToken, string xeroTenantId, string? reportYear = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Reports> response = await GetReportTenNinetyNineAsyncWithHttpInfo(accessToken, xeroTenantId, reportYear, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Reports>> GetReportTenNinetyNineAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? reportYear = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Reports> response = await accountingXeroClient.GetReportTenNinetyNineAsyncWithHttpInfo(accessToken, xeroTenantId, reportYear, cancellationToken);
        return response;
    }
    public async Task<ReportWithRows> GetReportTrialBalanceAsync(DateTime? date = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetReportTrialBalanceAsync(accessToken, xeroExtendedConfiguration.TenantId, date, paymentsOnly, cancellationToken);
    }

    public async Task<ReportWithRows> GetReportTrialBalanceAsync(string accessToken, string xeroTenantId, DateTime? date = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await GetReportTrialBalanceAsyncWithHttpInfo(accessToken, xeroTenantId, date, paymentsOnly, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ReportWithRows>> GetReportTrialBalanceAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? date = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ReportWithRows> response = await accountingXeroClient.GetReportTrialBalanceAsyncWithHttpInfo(accessToken, xeroTenantId, date, paymentsOnly, cancellationToken);
        return response;
    }
    public async Task<TaxRates> GetTaxRateByTaxTypeAsync(string taxType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetTaxRateByTaxTypeAsync(accessToken, xeroExtendedConfiguration.TenantId, taxType, cancellationToken);
    }

    public async Task<TaxRates> GetTaxRateByTaxTypeAsync(string accessToken, string xeroTenantId, string taxType, CancellationToken cancellationToken = default)
    {
        ApiResponse<TaxRates> response = await GetTaxRateByTaxTypeAsyncWithHttpInfo(accessToken, xeroTenantId, taxType, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TaxRates>> GetTaxRateByTaxTypeAsyncWithHttpInfo(string accessToken, string xeroTenantId, string taxType, CancellationToken cancellationToken = default)
    {
        ApiResponse<TaxRates> response = await accountingXeroClient.GetTaxRateByTaxTypeAsyncWithHttpInfo(accessToken, xeroTenantId, taxType, cancellationToken);
        return response;
    }
    public async Task<TaxRates> GetTaxRatesAsync(string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetTaxRatesAsync(accessToken, xeroExtendedConfiguration.TenantId, where, order, cancellationToken);
    }

    public async Task<TaxRates> GetTaxRatesAsync(string accessToken, string xeroTenantId, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TaxRates> response = await GetTaxRatesAsyncWithHttpInfo(accessToken, xeroTenantId, where, order, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TaxRates>> GetTaxRatesAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TaxRates> response = await accountingXeroClient.GetTaxRatesAsyncWithHttpInfo(accessToken, xeroTenantId, where, order, cancellationToken);
        return response;
    }
    public async Task<TrackingCategories> GetTrackingCategoriesAsync(string? where = null, string? order = null, bool? includeArchived = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetTrackingCategoriesAsync(accessToken, xeroExtendedConfiguration.TenantId, where, order, includeArchived, cancellationToken);
    }

    public async Task<TrackingCategories> GetTrackingCategoriesAsync(string accessToken, string xeroTenantId, string? where = null, string? order = null, bool? includeArchived = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TrackingCategories> response = await GetTrackingCategoriesAsyncWithHttpInfo(accessToken, xeroTenantId, where, order, includeArchived, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TrackingCategories>> GetTrackingCategoriesAsyncWithHttpInfo(string accessToken, string xeroTenantId, string? where = null, string? order = null, bool? includeArchived = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TrackingCategories> response = await accountingXeroClient.GetTrackingCategoriesAsyncWithHttpInfo(accessToken, xeroTenantId, where, order, includeArchived, cancellationToken);
        return response;
    }
    public async Task<TrackingCategories> GetTrackingCategoryAsync(Guid trackingCategoryID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetTrackingCategoryAsync(accessToken, xeroExtendedConfiguration.TenantId, trackingCategoryID, cancellationToken);
    }

    public async Task<TrackingCategories> GetTrackingCategoryAsync(string accessToken, string xeroTenantId, Guid trackingCategoryID, CancellationToken cancellationToken = default)
    {
        ApiResponse<TrackingCategories> response = await GetTrackingCategoryAsyncWithHttpInfo(accessToken, xeroTenantId, trackingCategoryID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TrackingCategories>> GetTrackingCategoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid trackingCategoryID, CancellationToken cancellationToken = default)
    {
        ApiResponse<TrackingCategories> response = await accountingXeroClient.GetTrackingCategoryAsyncWithHttpInfo(accessToken, xeroTenantId, trackingCategoryID, cancellationToken);
        return response;
    }
    public async Task<Users> GetUserAsync(Guid userID, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetUserAsync(accessToken, xeroExtendedConfiguration.TenantId, userID, cancellationToken);
    }

    public async Task<Users> GetUserAsync(string accessToken, string xeroTenantId, Guid userID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Users> response = await GetUserAsyncWithHttpInfo(accessToken, xeroTenantId, userID, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Users>> GetUserAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid userID, CancellationToken cancellationToken = default)
    {
        ApiResponse<Users> response = await accountingXeroClient.GetUserAsyncWithHttpInfo(accessToken, xeroTenantId, userID, cancellationToken);
        return response;
    }
    public async Task<Users> GetUsersAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await GetUsersAsync(accessToken, xeroExtendedConfiguration.TenantId, ifModifiedSince, where, order, cancellationToken);
    }

    public async Task<Users> GetUsersAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Users> response = await GetUsersAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Users>> GetUsersAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string? where = null, string? order = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Users> response = await accountingXeroClient.GetUsersAsyncWithHttpInfo(accessToken, xeroTenantId, ifModifiedSince, where, order, cancellationToken);
        return response;
    }
    public async Task<ImportSummaryObject> PostSetupAsync(Setup setup, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await PostSetupAsync(accessToken, xeroExtendedConfiguration.TenantId, setup, idempotencyKey, cancellationToken);
    }

    public async Task<ImportSummaryObject> PostSetupAsync(string accessToken, string xeroTenantId, Setup setup, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ImportSummaryObject> response = await PostSetupAsyncWithHttpInfo(accessToken, xeroTenantId, setup, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ImportSummaryObject>> PostSetupAsyncWithHttpInfo(string accessToken, string xeroTenantId, Setup setup, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ImportSummaryObject> response = await accountingXeroClient.PostSetupAsyncWithHttpInfo(accessToken, xeroTenantId, setup, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Accounts> UpdateAccountAsync(Guid accountID, Accounts accounts, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateAccountAsync(accessToken, xeroExtendedConfiguration.TenantId, accountID, accounts, idempotencyKey, cancellationToken);
    }

    public async Task<Accounts> UpdateAccountAsync(string accessToken, string xeroTenantId, Guid accountID, Accounts accounts, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Accounts> response = await UpdateAccountAsyncWithHttpInfo(accessToken, xeroTenantId, accountID, accounts, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Accounts>> UpdateAccountAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid accountID, Accounts accounts, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Accounts> response = await accountingXeroClient.UpdateAccountAsyncWithHttpInfo(accessToken, xeroTenantId, accountID, accounts, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Attachments> UpdateAccountAttachmentByFileNameAsync(Guid accountID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateAccountAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, accountID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> UpdateAccountAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid accountID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await UpdateAccountAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, accountID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> UpdateAccountAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid accountID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.UpdateAccountAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, accountID, fileName, body, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<BankTransactions> UpdateBankTransactionAsync(Guid bankTransactionID, BankTransactions bankTransactions, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateBankTransactionAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransactionID, bankTransactions, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<BankTransactions> UpdateBankTransactionAsync(string accessToken, string xeroTenantId, Guid bankTransactionID, BankTransactions bankTransactions, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BankTransactions> response = await UpdateBankTransactionAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactionID, bankTransactions, unitdp, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<BankTransactions>> UpdateBankTransactionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransactionID, BankTransactions bankTransactions, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BankTransactions> response = await accountingXeroClient.UpdateBankTransactionAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactionID, bankTransactions, unitdp, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Attachments> UpdateBankTransactionAttachmentByFileNameAsync(Guid bankTransactionID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateBankTransactionAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransactionID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> UpdateBankTransactionAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid bankTransactionID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await UpdateBankTransactionAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactionID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> UpdateBankTransactionAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransactionID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.UpdateBankTransactionAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactionID, fileName, body, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Attachments> UpdateBankTransferAttachmentByFileNameAsync(Guid bankTransferID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateBankTransferAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransferID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> UpdateBankTransferAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid bankTransferID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await UpdateBankTransferAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransferID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> UpdateBankTransferAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransferID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.UpdateBankTransferAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransferID, fileName, body, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<Contacts> UpdateContactAsync(Guid contactID, Contacts contacts, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateContactAsync(accessToken, xeroExtendedConfiguration.TenantId, contactID, contacts, idempotencyKey, cancellationToken);
    }

    public async Task<Contacts> UpdateContactAsync(string accessToken, string xeroTenantId, Guid contactID, Contacts contacts, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Contacts> response = await UpdateContactAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, contacts, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Contacts>> UpdateContactAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, Contacts contacts, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Contacts> response = await accountingXeroClient.UpdateContactAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, contacts, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Attachments> UpdateContactAttachmentByFileNameAsync(Guid contactID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateContactAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, contactID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> UpdateContactAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid contactID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await UpdateContactAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> UpdateContactAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.UpdateContactAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, fileName, body, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<ContactGroups> UpdateContactGroupAsync(Guid contactGroupID, ContactGroups contactGroups, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateContactGroupAsync(accessToken, xeroExtendedConfiguration.TenantId, contactGroupID, contactGroups, idempotencyKey, cancellationToken);
    }

    public async Task<ContactGroups> UpdateContactGroupAsync(string accessToken, string xeroTenantId, Guid contactGroupID, ContactGroups contactGroups, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ContactGroups> response = await UpdateContactGroupAsyncWithHttpInfo(accessToken, xeroTenantId, contactGroupID, contactGroups, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ContactGroups>> UpdateContactGroupAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactGroupID, ContactGroups contactGroups, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ContactGroups> response = await accountingXeroClient.UpdateContactGroupAsyncWithHttpInfo(accessToken, xeroTenantId, contactGroupID, contactGroups, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<CreditNotes> UpdateCreditNoteAsync(Guid creditNoteID, CreditNotes creditNotes, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateCreditNoteAsync(accessToken, xeroExtendedConfiguration.TenantId, creditNoteID, creditNotes, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<CreditNotes> UpdateCreditNoteAsync(string accessToken, string xeroTenantId, Guid creditNoteID, CreditNotes creditNotes, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<CreditNotes> response = await UpdateCreditNoteAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, creditNotes, unitdp, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<CreditNotes>> UpdateCreditNoteAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, CreditNotes creditNotes, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<CreditNotes> response = await accountingXeroClient.UpdateCreditNoteAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, creditNotes, unitdp, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Attachments> UpdateCreditNoteAttachmentByFileNameAsync(Guid creditNoteID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateCreditNoteAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, creditNoteID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> UpdateCreditNoteAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid creditNoteID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await UpdateCreditNoteAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> UpdateCreditNoteAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.UpdateCreditNoteAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, creditNoteID, fileName, body, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<ExpenseClaims> UpdateExpenseClaimAsync(Guid expenseClaimID, ExpenseClaims expenseClaims, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateExpenseClaimAsync(accessToken, xeroExtendedConfiguration.TenantId, expenseClaimID, expenseClaims, idempotencyKey, cancellationToken);
    }

    public async Task<ExpenseClaims> UpdateExpenseClaimAsync(string accessToken, string xeroTenantId, Guid expenseClaimID, ExpenseClaims expenseClaims, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ExpenseClaims> response = await UpdateExpenseClaimAsyncWithHttpInfo(accessToken, xeroTenantId, expenseClaimID, expenseClaims, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ExpenseClaims>> UpdateExpenseClaimAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid expenseClaimID, ExpenseClaims expenseClaims, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ExpenseClaims> response = await accountingXeroClient.UpdateExpenseClaimAsyncWithHttpInfo(accessToken, xeroTenantId, expenseClaimID, expenseClaims, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<Invoices> UpdateInvoiceAsync(Guid invoiceID, Invoices invoices, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateInvoiceAsync(accessToken, xeroExtendedConfiguration.TenantId, invoiceID, invoices, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<Invoices> UpdateInvoiceAsync(string accessToken, string xeroTenantId, Guid invoiceID, Invoices invoices, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Invoices> response = await UpdateInvoiceAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, invoices, unitdp, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Invoices>> UpdateInvoiceAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, Invoices invoices, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Invoices> response = await accountingXeroClient.UpdateInvoiceAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, invoices, unitdp, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<Attachments> UpdateInvoiceAttachmentByFileNameAsync(Guid invoiceID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateInvoiceAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, invoiceID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> UpdateInvoiceAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid invoiceID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await UpdateInvoiceAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> UpdateInvoiceAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.UpdateInvoiceAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, fileName, body, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Items> UpdateItemAsync(Guid itemID, Items items, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateItemAsync(accessToken, xeroExtendedConfiguration.TenantId, itemID, items, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<Items> UpdateItemAsync(string accessToken, string xeroTenantId, Guid itemID, Items items, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Items> response = await UpdateItemAsyncWithHttpInfo(accessToken, xeroTenantId, itemID, items, unitdp, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Items>> UpdateItemAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid itemID, Items items, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Items> response = await accountingXeroClient.UpdateItemAsyncWithHttpInfo(accessToken, xeroTenantId, itemID, items, unitdp, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<LinkedTransactions> UpdateLinkedTransactionAsync(Guid linkedTransactionID, LinkedTransactions linkedTransactions, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateLinkedTransactionAsync(accessToken, xeroExtendedConfiguration.TenantId, linkedTransactionID, linkedTransactions, idempotencyKey, cancellationToken);
    }

    public async Task<LinkedTransactions> UpdateLinkedTransactionAsync(string accessToken, string xeroTenantId, Guid linkedTransactionID, LinkedTransactions linkedTransactions, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LinkedTransactions> response = await UpdateLinkedTransactionAsyncWithHttpInfo(accessToken, xeroTenantId, linkedTransactionID, linkedTransactions, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<LinkedTransactions>> UpdateLinkedTransactionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid linkedTransactionID, LinkedTransactions linkedTransactions, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<LinkedTransactions> response = await accountingXeroClient.UpdateLinkedTransactionAsyncWithHttpInfo(accessToken, xeroTenantId, linkedTransactionID, linkedTransactions, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<ManualJournals> UpdateManualJournalAsync(Guid manualJournalID, ManualJournals manualJournals, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateManualJournalAsync(accessToken, xeroExtendedConfiguration.TenantId, manualJournalID, manualJournals, idempotencyKey, cancellationToken);
    }

    public async Task<ManualJournals> UpdateManualJournalAsync(string accessToken, string xeroTenantId, Guid manualJournalID, ManualJournals manualJournals, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ManualJournals> response = await UpdateManualJournalAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournalID, manualJournals, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ManualJournals>> UpdateManualJournalAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid manualJournalID, ManualJournals manualJournals, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ManualJournals> response = await accountingXeroClient.UpdateManualJournalAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournalID, manualJournals, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Attachments> UpdateManualJournalAttachmentByFileNameAsync(Guid manualJournalID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateManualJournalAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, manualJournalID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> UpdateManualJournalAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid manualJournalID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await UpdateManualJournalAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournalID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> UpdateManualJournalAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid manualJournalID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.UpdateManualJournalAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournalID, fileName, body, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<BankTransactions> UpdateOrCreateBankTransactionsAsync(BankTransactions bankTransactions, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateOrCreateBankTransactionsAsync(accessToken, xeroExtendedConfiguration.TenantId, bankTransactions, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<BankTransactions> UpdateOrCreateBankTransactionsAsync(string accessToken, string xeroTenantId, BankTransactions bankTransactions, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BankTransactions> response = await UpdateOrCreateBankTransactionsAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactions, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<BankTransactions>> UpdateOrCreateBankTransactionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, BankTransactions bankTransactions, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<BankTransactions> response = await accountingXeroClient.UpdateOrCreateBankTransactionsAsyncWithHttpInfo(accessToken, xeroTenantId, bankTransactions, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Contacts> UpdateOrCreateContactsAsync(Contacts contacts, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateOrCreateContactsAsync(accessToken, xeroExtendedConfiguration.TenantId, contacts, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<Contacts> UpdateOrCreateContactsAsync(string accessToken, string xeroTenantId, Contacts contacts, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Contacts> response = await UpdateOrCreateContactsAsyncWithHttpInfo(accessToken, xeroTenantId, contacts, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Contacts>> UpdateOrCreateContactsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Contacts contacts, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Contacts> response = await accountingXeroClient.UpdateOrCreateContactsAsyncWithHttpInfo(accessToken, xeroTenantId, contacts, summarizeErrors, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<CreditNotes> UpdateOrCreateCreditNotesAsync(CreditNotes creditNotes, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateOrCreateCreditNotesAsync(accessToken, xeroExtendedConfiguration.TenantId, creditNotes, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<CreditNotes> UpdateOrCreateCreditNotesAsync(string accessToken, string xeroTenantId, CreditNotes creditNotes, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<CreditNotes> response = await UpdateOrCreateCreditNotesAsyncWithHttpInfo(accessToken, xeroTenantId, creditNotes, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<CreditNotes>> UpdateOrCreateCreditNotesAsyncWithHttpInfo(string accessToken, string xeroTenantId, CreditNotes creditNotes, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<CreditNotes> response = await accountingXeroClient.UpdateOrCreateCreditNotesAsyncWithHttpInfo(accessToken, xeroTenantId, creditNotes, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Employees> UpdateOrCreateEmployeesAsync(Employees employees, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateOrCreateEmployeesAsync(accessToken, xeroExtendedConfiguration.TenantId, employees, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<Employees> UpdateOrCreateEmployeesAsync(string accessToken, string xeroTenantId, Employees employees, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await UpdateOrCreateEmployeesAsyncWithHttpInfo(accessToken, xeroTenantId, employees, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Employees>> UpdateOrCreateEmployeesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Employees employees, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Employees> response = await accountingXeroClient.UpdateOrCreateEmployeesAsyncWithHttpInfo(accessToken, xeroTenantId, employees, summarizeErrors, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Invoices> UpdateOrCreateInvoicesAsync(Invoices invoices, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateOrCreateInvoicesAsync(accessToken, xeroExtendedConfiguration.TenantId, invoices, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<Invoices> UpdateOrCreateInvoicesAsync(string accessToken, string xeroTenantId, Invoices invoices, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Invoices> response = await UpdateOrCreateInvoicesAsyncWithHttpInfo(accessToken, xeroTenantId, invoices, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Invoices>> UpdateOrCreateInvoicesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Invoices invoices, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Invoices> response = await accountingXeroClient.UpdateOrCreateInvoicesAsyncWithHttpInfo(accessToken, xeroTenantId, invoices, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Items> UpdateOrCreateItemsAsync(Items items, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateOrCreateItemsAsync(accessToken, xeroExtendedConfiguration.TenantId, items, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<Items> UpdateOrCreateItemsAsync(string accessToken, string xeroTenantId, Items items, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Items> response = await UpdateOrCreateItemsAsyncWithHttpInfo(accessToken, xeroTenantId, items, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Items>> UpdateOrCreateItemsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Items items, bool? summarizeErrors = null, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Items> response = await accountingXeroClient.UpdateOrCreateItemsAsyncWithHttpInfo(accessToken, xeroTenantId, items, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<ManualJournals> UpdateOrCreateManualJournalsAsync(ManualJournals manualJournals, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateOrCreateManualJournalsAsync(accessToken, xeroExtendedConfiguration.TenantId, manualJournals, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<ManualJournals> UpdateOrCreateManualJournalsAsync(string accessToken, string xeroTenantId, ManualJournals manualJournals, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ManualJournals> response = await UpdateOrCreateManualJournalsAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournals, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ManualJournals>> UpdateOrCreateManualJournalsAsyncWithHttpInfo(string accessToken, string xeroTenantId, ManualJournals manualJournals, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ManualJournals> response = await accountingXeroClient.UpdateOrCreateManualJournalsAsyncWithHttpInfo(accessToken, xeroTenantId, manualJournals, summarizeErrors, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<PurchaseOrders> UpdateOrCreatePurchaseOrdersAsync(PurchaseOrders purchaseOrders, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateOrCreatePurchaseOrdersAsync(accessToken, xeroExtendedConfiguration.TenantId, purchaseOrders, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<PurchaseOrders> UpdateOrCreatePurchaseOrdersAsync(string accessToken, string xeroTenantId, PurchaseOrders purchaseOrders, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PurchaseOrders> response = await UpdateOrCreatePurchaseOrdersAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrders, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PurchaseOrders>> UpdateOrCreatePurchaseOrdersAsyncWithHttpInfo(string accessToken, string xeroTenantId, PurchaseOrders purchaseOrders, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PurchaseOrders> response = await accountingXeroClient.UpdateOrCreatePurchaseOrdersAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrders, summarizeErrors, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Quotes> UpdateOrCreateQuotesAsync(Quotes quotes, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateOrCreateQuotesAsync(accessToken, xeroExtendedConfiguration.TenantId, quotes, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<Quotes> UpdateOrCreateQuotesAsync(string accessToken, string xeroTenantId, Quotes quotes, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Quotes> response = await UpdateOrCreateQuotesAsyncWithHttpInfo(accessToken, xeroTenantId, quotes, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Quotes>> UpdateOrCreateQuotesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Quotes quotes, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Quotes> response = await accountingXeroClient.UpdateOrCreateQuotesAsyncWithHttpInfo(accessToken, xeroTenantId, quotes, summarizeErrors, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<RepeatingInvoices> UpdateOrCreateRepeatingInvoicesAsync(RepeatingInvoices repeatingInvoices, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateOrCreateRepeatingInvoicesAsync(accessToken, xeroExtendedConfiguration.TenantId, repeatingInvoices, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<RepeatingInvoices> UpdateOrCreateRepeatingInvoicesAsync(string accessToken, string xeroTenantId, RepeatingInvoices repeatingInvoices, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<RepeatingInvoices> response = await UpdateOrCreateRepeatingInvoicesAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoices, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<RepeatingInvoices>> UpdateOrCreateRepeatingInvoicesAsyncWithHttpInfo(string accessToken, string xeroTenantId, RepeatingInvoices repeatingInvoices, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<RepeatingInvoices> response = await accountingXeroClient.UpdateOrCreateRepeatingInvoicesAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoices, summarizeErrors, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<PurchaseOrders> UpdatePurchaseOrderAsync(Guid purchaseOrderID, PurchaseOrders purchaseOrders, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdatePurchaseOrderAsync(accessToken, xeroExtendedConfiguration.TenantId, purchaseOrderID, purchaseOrders, idempotencyKey, cancellationToken);
    }

    public async Task<PurchaseOrders> UpdatePurchaseOrderAsync(string accessToken, string xeroTenantId, Guid purchaseOrderID, PurchaseOrders purchaseOrders, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PurchaseOrders> response = await UpdatePurchaseOrderAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, purchaseOrders, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PurchaseOrders>> UpdatePurchaseOrderAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid purchaseOrderID, PurchaseOrders purchaseOrders, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PurchaseOrders> response = await accountingXeroClient.UpdatePurchaseOrderAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, purchaseOrders, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Attachments> UpdatePurchaseOrderAttachmentByFileNameAsync(Guid purchaseOrderID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdatePurchaseOrderAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, purchaseOrderID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> UpdatePurchaseOrderAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid purchaseOrderID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await UpdatePurchaseOrderAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> UpdatePurchaseOrderAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid purchaseOrderID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.UpdatePurchaseOrderAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, fileName, body, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Quotes> UpdateQuoteAsync(Guid quoteID, Quotes quotes, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateQuoteAsync(accessToken, xeroExtendedConfiguration.TenantId, quoteID, quotes, idempotencyKey, cancellationToken);
    }

    public async Task<Quotes> UpdateQuoteAsync(string accessToken, string xeroTenantId, Guid quoteID, Quotes quotes, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Quotes> response = await UpdateQuoteAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, quotes, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Quotes>> UpdateQuoteAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, Quotes quotes, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Quotes> response = await accountingXeroClient.UpdateQuoteAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, quotes, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Attachments> UpdateQuoteAttachmentByFileNameAsync(Guid quoteID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateQuoteAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, quoteID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> UpdateQuoteAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid quoteID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await UpdateQuoteAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> UpdateQuoteAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.UpdateQuoteAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, quoteID, fileName, body, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Receipts> UpdateReceiptAsync(Guid receiptID, Receipts receipts, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateReceiptAsync(accessToken, xeroExtendedConfiguration.TenantId, receiptID, receipts, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<Receipts> UpdateReceiptAsync(string accessToken, string xeroTenantId, Guid receiptID, Receipts receipts, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Receipts> response = await UpdateReceiptAsyncWithHttpInfo(accessToken, xeroTenantId, receiptID, receipts, unitdp, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Receipts>> UpdateReceiptAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid receiptID, Receipts receipts, int? unitdp = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Receipts> response = await accountingXeroClient.UpdateReceiptAsyncWithHttpInfo(accessToken, xeroTenantId, receiptID, receipts, unitdp, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Attachments> UpdateReceiptAttachmentByFileNameAsync(Guid receiptID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateReceiptAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, receiptID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> UpdateReceiptAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid receiptID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await UpdateReceiptAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, receiptID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> UpdateReceiptAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid receiptID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.UpdateReceiptAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, receiptID, fileName, body, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<RepeatingInvoices> UpdateRepeatingInvoiceAsync(Guid repeatingInvoiceID, RepeatingInvoices repeatingInvoices, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateRepeatingInvoiceAsync(accessToken, xeroExtendedConfiguration.TenantId, repeatingInvoiceID, repeatingInvoices, idempotencyKey, cancellationToken);
    }

    public async Task<RepeatingInvoices> UpdateRepeatingInvoiceAsync(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, RepeatingInvoices repeatingInvoices, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<RepeatingInvoices> response = await UpdateRepeatingInvoiceAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoiceID, repeatingInvoices, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<RepeatingInvoices>> UpdateRepeatingInvoiceAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, RepeatingInvoices repeatingInvoices, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<RepeatingInvoices> response = await accountingXeroClient.UpdateRepeatingInvoiceAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoiceID, repeatingInvoices, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Attachments> UpdateRepeatingInvoiceAttachmentByFileNameAsync(Guid repeatingInvoiceID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateRepeatingInvoiceAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, repeatingInvoiceID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> UpdateRepeatingInvoiceAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await UpdateRepeatingInvoiceAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoiceID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> UpdateRepeatingInvoiceAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, string fileName, byte[] body, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.UpdateRepeatingInvoiceAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, repeatingInvoiceID, fileName, body, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<TaxRates> UpdateTaxRateAsync(TaxRates taxRates, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateTaxRateAsync(accessToken, xeroExtendedConfiguration.TenantId, taxRates, idempotencyKey, cancellationToken);
    }

    public async Task<TaxRates> UpdateTaxRateAsync(string accessToken, string xeroTenantId, TaxRates taxRates, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TaxRates> response = await UpdateTaxRateAsyncWithHttpInfo(accessToken, xeroTenantId, taxRates, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TaxRates>> UpdateTaxRateAsyncWithHttpInfo(string accessToken, string xeroTenantId, TaxRates taxRates, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TaxRates> response = await accountingXeroClient.UpdateTaxRateAsyncWithHttpInfo(accessToken, xeroTenantId, taxRates, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<TrackingCategories> UpdateTrackingCategoryAsync(Guid trackingCategoryID, TrackingCategory trackingCategory, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateTrackingCategoryAsync(accessToken, xeroExtendedConfiguration.TenantId, trackingCategoryID, trackingCategory, idempotencyKey, cancellationToken);
    }

    public async Task<TrackingCategories> UpdateTrackingCategoryAsync(string accessToken, string xeroTenantId, Guid trackingCategoryID, TrackingCategory trackingCategory, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TrackingCategories> response = await UpdateTrackingCategoryAsyncWithHttpInfo(accessToken, xeroTenantId, trackingCategoryID, trackingCategory, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TrackingCategories>> UpdateTrackingCategoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid trackingCategoryID, TrackingCategory trackingCategory, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TrackingCategories> response = await accountingXeroClient.UpdateTrackingCategoryAsyncWithHttpInfo(accessToken, xeroTenantId, trackingCategoryID, trackingCategory, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<TrackingOptions> UpdateTrackingOptionsAsync(Guid trackingCategoryID, Guid trackingOptionID, TrackingOption trackingOption, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateTrackingOptionsAsync(accessToken, xeroExtendedConfiguration.TenantId, trackingCategoryID, trackingOptionID, trackingOption, idempotencyKey, cancellationToken);
    }

    public async Task<TrackingOptions> UpdateTrackingOptionsAsync(string accessToken, string xeroTenantId, Guid trackingCategoryID, Guid trackingOptionID, TrackingOption trackingOption, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TrackingOptions> response = await UpdateTrackingOptionsAsyncWithHttpInfo(accessToken, xeroTenantId, trackingCategoryID, trackingOptionID, trackingOption, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<TrackingOptions>> UpdateTrackingOptionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid trackingCategoryID, Guid trackingOptionID, TrackingOption trackingOption, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<TrackingOptions> response = await accountingXeroClient.UpdateTrackingOptionsAsyncWithHttpInfo(accessToken, xeroTenantId, trackingCategoryID, trackingOptionID, trackingOption, idempotencyKey, cancellationToken);
        return response;
    }
}

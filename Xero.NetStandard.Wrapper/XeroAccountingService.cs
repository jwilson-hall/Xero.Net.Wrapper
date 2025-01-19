using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Accounting;
using Xero.NetStandard.OAuth2.Model.Identity;

namespace Xero.NetStandard.Wrapper;
public partial class XeroService : IAccountingApi
{
    public IReadableConfiguration Configuration { get ; set; }
    public ExceptionFactory ExceptionFactory { get; set; }

    public Task<Accounts> CreateAccountAsync(string accessToken, string xeroTenantId, Account account, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Accounts>> CreateAccountAsyncWithHttpInfo(string accessToken, string xeroTenantId, Account account, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> CreateAccountAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid accountID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> CreateAccountAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid accountID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> CreateBankTransactionAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid bankTransactionID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> CreateBankTransactionAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransactionID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> CreateBankTransactionHistoryRecordAsync(string accessToken, string xeroTenantId, Guid bankTransactionID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> CreateBankTransactionHistoryRecordAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransactionID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<BankTransactions> CreateBankTransactionsAsync(string accessToken, string xeroTenantId, BankTransactions bankTransactions, bool? summarizeErrors = null, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BankTransactions>> CreateBankTransactionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, BankTransactions bankTransactions, bool? summarizeErrors = null, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<BankTransfers> CreateBankTransferAsync(string accessToken, string xeroTenantId, BankTransfers bankTransfers, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BankTransfers>> CreateBankTransferAsyncWithHttpInfo(string accessToken, string xeroTenantId, BankTransfers bankTransfers, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> CreateBankTransferAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid bankTransferID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> CreateBankTransferAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransferID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> CreateBankTransferHistoryRecordAsync(string accessToken, string xeroTenantId, Guid bankTransferID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> CreateBankTransferHistoryRecordAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransferID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<BatchPayments> CreateBatchPaymentAsync(string accessToken, string xeroTenantId, BatchPayments batchPayments, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BatchPayments>> CreateBatchPaymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, BatchPayments batchPayments, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> CreateBatchPaymentHistoryRecordAsync(string accessToken, string xeroTenantId, Guid batchPaymentID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> CreateBatchPaymentHistoryRecordAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid batchPaymentID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentServices> CreateBrandingThemePaymentServicesAsync(string accessToken, string xeroTenantId, Guid brandingThemeID, PaymentServices paymentServices, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PaymentServices>> CreateBrandingThemePaymentServicesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid brandingThemeID, PaymentServices paymentServices, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> CreateContactAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid contactID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> CreateContactAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ContactGroups> CreateContactGroupAsync(string accessToken, string xeroTenantId, ContactGroups contactGroups, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ContactGroups>> CreateContactGroupAsyncWithHttpInfo(string accessToken, string xeroTenantId, ContactGroups contactGroups, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Contacts> CreateContactGroupContactsAsync(string accessToken, string xeroTenantId, Guid contactGroupID, Contacts contacts, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Contacts>> CreateContactGroupContactsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactGroupID, Contacts contacts, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> CreateContactHistoryAsync(string accessToken, string xeroTenantId, Guid contactID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> CreateContactHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<Contacts> CreateContactsAsync(Contacts contacts, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateContactsAsync(accessToken, xeroExtendedConfiguration.TenantId, contacts, summarizeErrors, idempotencyKey, cancellationToken);
    }
    public async Task<Contacts> CreateContactsAsync(string accessToken, string xeroTenantId, Contacts contacts, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Contacts> response = await CreateContactsAsyncWithHttpInfo(accessToken, xeroTenantId, contacts, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public Task<ApiResponse<Contacts>> CreateContactsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Contacts contacts, bool? summarizeErrors = null, string? idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        return accountingXeroClient.CreateContactsAsyncWithHttpInfo(accessToken, xeroTenantId, contacts, summarizeErrors, idempotencyKey, cancellationToken);
    }
    #region NotImplemented
    public Task<Allocations> CreateCreditNoteAllocationAsync(string accessToken, string xeroTenantId, Guid creditNoteID, Allocations allocations, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Allocations>> CreateCreditNoteAllocationAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, Allocations allocations, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> CreateCreditNoteAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid creditNoteID, string fileName, byte[] body, bool? includeOnline = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> CreateCreditNoteAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, string fileName, byte[] body, bool? includeOnline = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> CreateCreditNoteHistoryAsync(string accessToken, string xeroTenantId, Guid creditNoteID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> CreateCreditNoteHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<CreditNotes> CreateCreditNotesAsync(string accessToken, string xeroTenantId, CreditNotes creditNotes, bool? summarizeErrors = null, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<CreditNotes>> CreateCreditNotesAsyncWithHttpInfo(string accessToken, string xeroTenantId, CreditNotes creditNotes, bool? summarizeErrors = null, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Currencies> CreateCurrencyAsync(string accessToken, string xeroTenantId, Currency currency, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Currencies>> CreateCurrencyAsyncWithHttpInfo(string accessToken, string xeroTenantId, Currency currency, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Employees> CreateEmployeesAsync(string accessToken, string xeroTenantId, Employees employees, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Employees>> CreateEmployeesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Employees employees, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> CreateExpenseClaimHistoryAsync(string accessToken, string xeroTenantId, Guid expenseClaimID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> CreateExpenseClaimHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid expenseClaimID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ExpenseClaims> CreateExpenseClaimsAsync(string accessToken, string xeroTenantId, ExpenseClaims expenseClaims, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ExpenseClaims>> CreateExpenseClaimsAsyncWithHttpInfo(string accessToken, string xeroTenantId, ExpenseClaims expenseClaims, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> CreateInvoiceAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid invoiceID, string fileName, byte[] body, bool? includeOnline = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> CreateInvoiceAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, string fileName, byte[] body, bool? includeOnline = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> CreateInvoiceHistoryAsync(string accessToken, string xeroTenantId, Guid invoiceID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> CreateInvoiceHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
    public async Task<Invoices> CreateInvoicesAsync(Invoices invoices, bool? summarizeErrors = null, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreateInvoicesAsync(accessToken, xeroExtendedConfiguration.TenantId, invoices, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<Invoices> CreateInvoicesAsync(string accessToken, string xeroTenantId, Invoices invoices, bool? summarizeErrors = null, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Invoices> response = await CreateInvoicesAsyncWithHttpInfo(accessToken, xeroTenantId, invoices, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Invoices>> CreateInvoicesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Invoices invoices, bool? summarizeErrors = null, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Invoices> response = await accountingXeroClient.CreateInvoicesAsyncWithHttpInfo(accessToken, xeroTenantId, invoices, summarizeErrors, unitdp, idempotencyKey, cancellationToken);
        return response;
    }


    public Task<HistoryRecords> CreateItemHistoryAsync(string accessToken, string xeroTenantId, Guid itemID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> CreateItemHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid itemID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Items> CreateItemsAsync(string accessToken, string xeroTenantId, Items items, bool? summarizeErrors = null, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Items>> CreateItemsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Items items, bool? summarizeErrors = null, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<LinkedTransactions> CreateLinkedTransactionAsync(string accessToken, string xeroTenantId, LinkedTransaction linkedTransaction, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<LinkedTransactions>> CreateLinkedTransactionAsyncWithHttpInfo(string accessToken, string xeroTenantId, LinkedTransaction linkedTransaction, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> CreateManualJournalAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid manualJournalID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> CreateManualJournalAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid manualJournalID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> CreateManualJournalHistoryRecordAsync(string accessToken, string xeroTenantId, Guid manualJournalID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> CreateManualJournalHistoryRecordAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid manualJournalID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ManualJournals> CreateManualJournalsAsync(string accessToken, string xeroTenantId, ManualJournals manualJournals, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ManualJournals>> CreateManualJournalsAsyncWithHttpInfo(string accessToken, string xeroTenantId, ManualJournals manualJournals, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Allocations> CreateOverpaymentAllocationsAsync(string accessToken, string xeroTenantId, Guid overpaymentID, Allocations allocations, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Allocations>> CreateOverpaymentAllocationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid overpaymentID, Allocations allocations, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> CreateOverpaymentHistoryAsync(string accessToken, string xeroTenantId, Guid overpaymentID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> CreateOverpaymentHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid overpaymentID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Payments> CreatePaymentAsync(string accessToken, string xeroTenantId, Payment payment, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Payments>> CreatePaymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, Payment payment, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> CreatePaymentHistoryAsync(string accessToken, string xeroTenantId, Guid paymentID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> CreatePaymentHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid paymentID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Payments> CreatePaymentsAsync(string accessToken, string xeroTenantId, Payments payments, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Payments>> CreatePaymentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Payments payments, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentServices> CreatePaymentServiceAsync(string accessToken, string xeroTenantId, PaymentServices paymentServices, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PaymentServices>> CreatePaymentServiceAsyncWithHttpInfo(string accessToken, string xeroTenantId, PaymentServices paymentServices, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Allocations> CreatePrepaymentAllocationsAsync(string accessToken, string xeroTenantId, Guid prepaymentID, Allocations allocations, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Allocations>> CreatePrepaymentAllocationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid prepaymentID, Allocations allocations, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> CreatePrepaymentHistoryAsync(string accessToken, string xeroTenantId, Guid prepaymentID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> CreatePrepaymentHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid prepaymentID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> CreatePurchaseOrderAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid purchaseOrderID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> CreatePurchaseOrderAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid purchaseOrderID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> CreatePurchaseOrderHistoryAsync(string accessToken, string xeroTenantId, Guid purchaseOrderID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> CreatePurchaseOrderHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid purchaseOrderID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<PurchaseOrders> CreatePurchaseOrdersAsync(PurchaseOrders purchaseOrders, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await CreatePurchaseOrdersAsync(accessToken, xeroExtendedConfiguration.TenantId, purchaseOrders, summarizeErrors, idempotencyKey, cancellationToken);
    }

    public async Task<PurchaseOrders> CreatePurchaseOrdersAsync(string accessToken, string xeroTenantId, PurchaseOrders purchaseOrders, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PurchaseOrders> response = await CreatePurchaseOrdersAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrders, summarizeErrors, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PurchaseOrders>> CreatePurchaseOrdersAsyncWithHttpInfo(string accessToken, string xeroTenantId, PurchaseOrders purchaseOrders, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PurchaseOrders> response = await accountingXeroClient.CreatePurchaseOrdersAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrders, summarizeErrors, idempotencyKey, cancellationToken);
        return response;
    }

    public Task<Attachments> CreateQuoteAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid quoteID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> CreateQuoteAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> CreateQuoteHistoryAsync(string accessToken, string xeroTenantId, Guid quoteID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> CreateQuoteHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Quotes> CreateQuotesAsync(string accessToken, string xeroTenantId, Quotes quotes, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Quotes>> CreateQuotesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Quotes quotes, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Receipts> CreateReceiptAsync(string accessToken, string xeroTenantId, Receipts receipts, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Receipts>> CreateReceiptAsyncWithHttpInfo(string accessToken, string xeroTenantId, Receipts receipts, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> CreateReceiptAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid receiptID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> CreateReceiptAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid receiptID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> CreateReceiptHistoryAsync(string accessToken, string xeroTenantId, Guid receiptID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> CreateReceiptHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid receiptID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> CreateRepeatingInvoiceAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> CreateRepeatingInvoiceAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> CreateRepeatingInvoiceHistoryAsync(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> CreateRepeatingInvoiceHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, HistoryRecords historyRecords, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<RepeatingInvoices> CreateRepeatingInvoicesAsync(string accessToken, string xeroTenantId, RepeatingInvoices repeatingInvoices, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<RepeatingInvoices>> CreateRepeatingInvoicesAsyncWithHttpInfo(string accessToken, string xeroTenantId, RepeatingInvoices repeatingInvoices, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TaxRates> CreateTaxRatesAsync(string accessToken, string xeroTenantId, TaxRates taxRates, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TaxRates>> CreateTaxRatesAsyncWithHttpInfo(string accessToken, string xeroTenantId, TaxRates taxRates, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TrackingCategories> CreateTrackingCategoryAsync(string accessToken, string xeroTenantId, TrackingCategory trackingCategory, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TrackingCategories>> CreateTrackingCategoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, TrackingCategory trackingCategory, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TrackingOptions> CreateTrackingOptionsAsync(string accessToken, string xeroTenantId, Guid trackingCategoryID, TrackingOption trackingOption, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TrackingOptions>> CreateTrackingOptionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid trackingCategoryID, TrackingOption trackingOption, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Accounts> DeleteAccountAsync(string accessToken, string xeroTenantId, Guid accountID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Accounts>> DeleteAccountAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid accountID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<BatchPayments> DeleteBatchPaymentAsync(string accessToken, string xeroTenantId, BatchPaymentDelete batchPaymentDelete, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BatchPayments>> DeleteBatchPaymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, BatchPaymentDelete batchPaymentDelete, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<BatchPayments> DeleteBatchPaymentByUrlParamAsync(string accessToken, string xeroTenantId, Guid batchPaymentID, BatchPaymentDeleteByUrlParam batchPaymentDeleteByUrlParam, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BatchPayments>> DeleteBatchPaymentByUrlParamAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid batchPaymentID, BatchPaymentDeleteByUrlParam batchPaymentDeleteByUrlParam, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteContactGroupContactAsync(string accessToken, string xeroTenantId, Guid contactGroupID, Guid contactID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<object>> DeleteContactGroupContactAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactGroupID, Guid contactID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteContactGroupContactsAsync(string accessToken, string xeroTenantId, Guid contactGroupID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<object>> DeleteContactGroupContactsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactGroupID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Allocation> DeleteCreditNoteAllocationsAsync(string accessToken, string xeroTenantId, Guid creditNoteID, Guid allocationID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Allocation>> DeleteCreditNoteAllocationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, Guid allocationID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteItemAsync(string accessToken, string xeroTenantId, Guid itemID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<object>> DeleteItemAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid itemID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteLinkedTransactionAsync(string accessToken, string xeroTenantId, Guid linkedTransactionID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<object>> DeleteLinkedTransactionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid linkedTransactionID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Allocation> DeleteOverpaymentAllocationsAsync(string accessToken, string xeroTenantId, Guid overpaymentID, Guid allocationID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Allocation>> DeleteOverpaymentAllocationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid overpaymentID, Guid allocationID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Payments> DeletePaymentAsync(string accessToken, string xeroTenantId, Guid paymentID, PaymentDelete paymentDelete, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Payments>> DeletePaymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid paymentID, PaymentDelete paymentDelete, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Allocation> DeletePrepaymentAllocationsAsync(string accessToken, string xeroTenantId, Guid prepaymentID, Guid allocationID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Allocation>> DeletePrepaymentAllocationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid prepaymentID, Guid allocationID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TrackingCategories> DeleteTrackingCategoryAsync(string accessToken, string xeroTenantId, Guid trackingCategoryID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TrackingCategories>> DeleteTrackingCategoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid trackingCategoryID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TrackingOptions> DeleteTrackingOptionsAsync(string accessToken, string xeroTenantId, Guid trackingCategoryID, Guid trackingOptionID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TrackingOptions>> DeleteTrackingOptionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid trackingCategoryID, Guid trackingOptionID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task EmailInvoiceAsync(string accessToken, string xeroTenantId, Guid invoiceID, RequestEmpty requestEmpty, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<object>> EmailInvoiceAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, RequestEmpty requestEmpty, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Accounts> GetAccountAsync(string accessToken, string xeroTenantId, Guid accountID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Accounts>> GetAccountAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid accountID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetAccountAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid accountID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetAccountAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid accountID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetAccountAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid accountID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetAccountAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid accountID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> GetAccountAttachmentsAsync(string accessToken, string xeroTenantId, Guid accountID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> GetAccountAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid accountID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Accounts> GetAccountsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Accounts>> GetAccountsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<BankTransactions> GetBankTransactionAsync(string accessToken, string xeroTenantId, Guid bankTransactionID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BankTransactions>> GetBankTransactionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransactionID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetBankTransactionAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid bankTransactionID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetBankTransactionAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransactionID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetBankTransactionAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid bankTransactionID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetBankTransactionAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransactionID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> GetBankTransactionAttachmentsAsync(string accessToken, string xeroTenantId, Guid bankTransactionID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> GetBankTransactionAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransactionID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<BankTransactions> GetBankTransactionsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BankTransactions>> GetBankTransactionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> GetBankTransactionsHistoryAsync(string accessToken, string xeroTenantId, Guid bankTransactionID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> GetBankTransactionsHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransactionID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<BankTransfers> GetBankTransferAsync(string accessToken, string xeroTenantId, Guid bankTransferID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BankTransfers>> GetBankTransferAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransferID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetBankTransferAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid bankTransferID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetBankTransferAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransferID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetBankTransferAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid bankTransferID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetBankTransferAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransferID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> GetBankTransferAttachmentsAsync(string accessToken, string xeroTenantId, Guid bankTransferID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> GetBankTransferAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransferID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> GetBankTransferHistoryAsync(string accessToken, string xeroTenantId, Guid bankTransferID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> GetBankTransferHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransferID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<BankTransfers> GetBankTransfersAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BankTransfers>> GetBankTransfersAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public string GetBasePath()
    {
        throw new NotImplementedException();
    }

    public Task<BatchPayments> GetBatchPaymentAsync(string accessToken, string xeroTenantId, Guid batchPaymentID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BatchPayments>> GetBatchPaymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid batchPaymentID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> GetBatchPaymentHistoryAsync(string accessToken, string xeroTenantId, Guid batchPaymentID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> GetBatchPaymentHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid batchPaymentID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<BatchPayments> GetBatchPaymentsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BatchPayments>> GetBatchPaymentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<BrandingThemes> GetBrandingThemeAsync(string accessToken, string xeroTenantId, Guid brandingThemeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BrandingThemes>> GetBrandingThemeAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid brandingThemeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentServices> GetBrandingThemePaymentServicesAsync(string accessToken, string xeroTenantId, Guid brandingThemeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PaymentServices>> GetBrandingThemePaymentServicesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid brandingThemeID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<BrandingThemes> GetBrandingThemesAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BrandingThemes>> GetBrandingThemesAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Budgets> GetBudgetAsync(string accessToken, string xeroTenantId, Guid budgetID, DateTime? dateTo = null, DateTime? dateFrom = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Budgets>> GetBudgetAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid budgetID, DateTime? dateTo = null, DateTime? dateFrom = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Budgets> GetBudgetsAsync(string accessToken, string xeroTenantId, List<Guid> iDs = null, DateTime? dateTo = null, DateTime? dateFrom = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Budgets>> GetBudgetsAsyncWithHttpInfo(string accessToken, string xeroTenantId, List<Guid> iDs = null, DateTime? dateTo = null, DateTime? dateFrom = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Contacts> GetContactAsync(string accessToken, string xeroTenantId, Guid contactID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Contacts>> GetContactAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetContactAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid contactID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetContactAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetContactAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid contactID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetContactAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> GetContactAttachmentsAsync(string accessToken, string xeroTenantId, Guid contactID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> GetContactAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Contacts> GetContactByContactNumberAsync(string accessToken, string xeroTenantId, string contactNumber, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Contacts>> GetContactByContactNumberAsyncWithHttpInfo(string accessToken, string xeroTenantId, string contactNumber, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<CISSettings> GetContactCISSettingsAsync(string accessToken, string xeroTenantId, Guid contactID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<CISSettings>> GetContactCISSettingsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ContactGroups> GetContactGroupAsync(string accessToken, string xeroTenantId, Guid contactGroupID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ContactGroups>> GetContactGroupAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactGroupID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ContactGroups> GetContactGroupsAsync(string accessToken, string xeroTenantId, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ContactGroups>> GetContactGroupsAsyncWithHttpInfo(string accessToken, string xeroTenantId, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> GetContactHistoryAsync(string accessToken, string xeroTenantId, Guid contactID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> GetContactHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
#endregion
    public async Task<Contacts> GetContactsAsync(DateTime? ifModifiedSince = null, string? where = null, string? order = null, List<Guid>? iDs = null, int? page = null, bool? includeArchived = null, bool? summaryOnly = null, string searchTerm = null, int? pageSize = null, CancellationToken cancellationToken = default)
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
    #region NotImplemented
    public Task<Stream> GetCreditNoteAsPdfAsync(string accessToken, string xeroTenantId, Guid creditNoteID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetCreditNoteAsPdfAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<CreditNotes> GetCreditNoteAsync(string accessToken, string xeroTenantId, Guid creditNoteID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<CreditNotes>> GetCreditNoteAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetCreditNoteAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid creditNoteID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetCreditNoteAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetCreditNoteAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid creditNoteID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetCreditNoteAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> GetCreditNoteAttachmentsAsync(string accessToken, string xeroTenantId, Guid creditNoteID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> GetCreditNoteAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> GetCreditNoteHistoryAsync(string accessToken, string xeroTenantId, Guid creditNoteID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> GetCreditNoteHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<CreditNotes> GetCreditNotesAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<CreditNotes>> GetCreditNotesAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Currencies> GetCurrenciesAsync(string accessToken, string xeroTenantId, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Currencies>> GetCurrenciesAsyncWithHttpInfo(string accessToken, string xeroTenantId, string where = null, string order = null, CancellationToken cancellationToken = default)
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

    public Task<Employees> GetEmployeesAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Employees>> GetEmployeesAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ExpenseClaims> GetExpenseClaimAsync(string accessToken, string xeroTenantId, Guid expenseClaimID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ExpenseClaims>> GetExpenseClaimAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid expenseClaimID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> GetExpenseClaimHistoryAsync(string accessToken, string xeroTenantId, Guid expenseClaimID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> GetExpenseClaimHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid expenseClaimID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ExpenseClaims> GetExpenseClaimsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ExpenseClaims>> GetExpenseClaimsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
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



    public Task<Invoices> GetInvoiceAsync(string accessToken, string xeroTenantId, Guid invoiceID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Invoices>> GetInvoiceAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetInvoiceAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid invoiceID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetInvoiceAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetInvoiceAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid invoiceID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetInvoiceAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> GetInvoiceAttachmentsAsync(string accessToken, string xeroTenantId, Guid invoiceID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> GetInvoiceAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> GetInvoiceHistoryAsync(string accessToken, string xeroTenantId, Guid invoiceID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> GetInvoiceHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<InvoiceReminders> GetInvoiceRemindersAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<InvoiceReminders>> GetInvoiceRemindersAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Invoices> GetInvoicesAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, List<Guid> iDs = null, List<string> invoiceNumbers = null, List<Guid> contactIDs = null, List<string> statuses = null, int? page = null, bool? includeArchived = null, bool? createdByMyApp = null, int? unitdp = null, bool? summaryOnly = null, int? pageSize = null, string searchTerm = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Invoices>> GetInvoicesAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, List<Guid> iDs = null, List<string> invoiceNumbers = null, List<Guid> contactIDs = null, List<string> statuses = null, int? page = null, bool? includeArchived = null, bool? createdByMyApp = null, int? unitdp = null, bool? summaryOnly = null, int? pageSize = null, string searchTerm = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Items> GetItemAsync(string accessToken, string xeroTenantId, Guid itemID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Items>> GetItemAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid itemID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> GetItemHistoryAsync(string accessToken, string xeroTenantId, Guid itemID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> GetItemHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid itemID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Items> GetItemsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Items>> GetItemsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Journals> GetJournalAsync(string accessToken, string xeroTenantId, Guid journalID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Journals>> GetJournalAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid journalID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Journals> GetJournalByNumberAsync(string accessToken, string xeroTenantId, int journalNumber, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Journals>> GetJournalByNumberAsyncWithHttpInfo(string accessToken, string xeroTenantId, int journalNumber, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Journals> GetJournalsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, int? offset = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Journals>> GetJournalsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, int? offset = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<LinkedTransactions> GetLinkedTransactionAsync(string accessToken, string xeroTenantId, Guid linkedTransactionID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<LinkedTransactions>> GetLinkedTransactionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid linkedTransactionID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<LinkedTransactions> GetLinkedTransactionsAsync(string accessToken, string xeroTenantId, int? page = null, Guid? linkedTransactionID = null, Guid? sourceTransactionID = null, Guid? contactID = null, string status = null, Guid? targetTransactionID = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<LinkedTransactions>> GetLinkedTransactionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, int? page = null, Guid? linkedTransactionID = null, Guid? sourceTransactionID = null, Guid? contactID = null, string status = null, Guid? targetTransactionID = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ManualJournals> GetManualJournalAsync(string accessToken, string xeroTenantId, Guid manualJournalID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ManualJournals>> GetManualJournalAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid manualJournalID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetManualJournalAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid manualJournalID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetManualJournalAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid manualJournalID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetManualJournalAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid manualJournalID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetManualJournalAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid manualJournalID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> GetManualJournalAttachmentsAsync(string accessToken, string xeroTenantId, Guid manualJournalID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> GetManualJournalAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid manualJournalID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ManualJournals> GetManualJournalsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ManualJournals>> GetManualJournalsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> GetManualJournalsHistoryAsync(string accessToken, string xeroTenantId, Guid manualJournalID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> GetManualJournalsHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid manualJournalID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<OnlineInvoices> GetOnlineInvoiceAsync(string accessToken, string xeroTenantId, Guid invoiceID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<OnlineInvoices>> GetOnlineInvoiceAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Actions> GetOrganisationActionsAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Actions>> GetOrganisationActionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<CISOrgSettings> GetOrganisationCISSettingsAsync(string accessToken, string xeroTenantId, Guid organisationID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<CISOrgSettings>> GetOrganisationCISSettingsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid organisationID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Organisations> GetOrganisationsAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Organisations>> GetOrganisationsAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Overpayments> GetOverpaymentAsync(string accessToken, string xeroTenantId, Guid overpaymentID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Overpayments>> GetOverpaymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid overpaymentID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> GetOverpaymentHistoryAsync(string accessToken, string xeroTenantId, Guid overpaymentID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> GetOverpaymentHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid overpaymentID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Overpayments> GetOverpaymentsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Overpayments>> GetOverpaymentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Payments> GetPaymentAsync(string accessToken, string xeroTenantId, Guid paymentID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Payments>> GetPaymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid paymentID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> GetPaymentHistoryAsync(string accessToken, string xeroTenantId, Guid paymentID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> GetPaymentHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid paymentID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Payments> GetPaymentsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Payments>> GetPaymentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentServices> GetPaymentServicesAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PaymentServices>> GetPaymentServicesAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Prepayments> GetPrepaymentAsync(string accessToken, string xeroTenantId, Guid prepaymentID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Prepayments>> GetPrepaymentAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid prepaymentID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> GetPrepaymentHistoryAsync(string accessToken, string xeroTenantId, Guid prepaymentID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> GetPrepaymentHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid prepaymentID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Prepayments> GetPrepaymentsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Prepayments>> GetPrepaymentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, int? page = null, int? unitdp = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
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

    public Task<Stream> GetPurchaseOrderAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid purchaseOrderID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetPurchaseOrderAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid purchaseOrderID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetPurchaseOrderAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid purchaseOrderID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetPurchaseOrderAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid purchaseOrderID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> GetPurchaseOrderAttachmentsAsync(string accessToken, string xeroTenantId, Guid purchaseOrderID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> GetPurchaseOrderAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid purchaseOrderID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PurchaseOrders> GetPurchaseOrderByNumberAsync(string accessToken, string xeroTenantId, string purchaseOrderNumber, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PurchaseOrders>> GetPurchaseOrderByNumberAsyncWithHttpInfo(string accessToken, string xeroTenantId, string purchaseOrderNumber, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> GetPurchaseOrderHistoryAsync(string accessToken, string xeroTenantId, Guid purchaseOrderID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> GetPurchaseOrderHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid purchaseOrderID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PurchaseOrders> GetPurchaseOrdersAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string status = null, string dateFrom = null, string dateTo = null, string order = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PurchaseOrders>> GetPurchaseOrdersAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string status = null, string dateFrom = null, string dateTo = null, string order = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetQuoteAsPdfAsync(string accessToken, string xeroTenantId, Guid quoteID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetQuoteAsPdfAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Quotes> GetQuoteAsync(string accessToken, string xeroTenantId, Guid quoteID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Quotes>> GetQuoteAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetQuoteAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid quoteID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetQuoteAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetQuoteAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid quoteID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetQuoteAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> GetQuoteAttachmentsAsync(string accessToken, string xeroTenantId, Guid quoteID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> GetQuoteAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> GetQuoteHistoryAsync(string accessToken, string xeroTenantId, Guid quoteID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> GetQuoteHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Quotes> GetQuotesAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, DateTime? dateFrom = null, DateTime? dateTo = null, DateTime? expiryDateFrom = null, DateTime? expiryDateTo = null, Guid? contactID = null, string status = null, int? page = null, string order = null, string quoteNumber = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Quotes>> GetQuotesAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, DateTime? dateFrom = null, DateTime? dateTo = null, DateTime? expiryDateFrom = null, DateTime? expiryDateTo = null, Guid? contactID = null, string status = null, int? page = null, string order = null, string quoteNumber = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Receipts> GetReceiptAsync(string accessToken, string xeroTenantId, Guid receiptID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Receipts>> GetReceiptAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid receiptID, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetReceiptAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid receiptID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetReceiptAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid receiptID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetReceiptAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid receiptID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetReceiptAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid receiptID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> GetReceiptAttachmentsAsync(string accessToken, string xeroTenantId, Guid receiptID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> GetReceiptAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid receiptID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> GetReceiptHistoryAsync(string accessToken, string xeroTenantId, Guid receiptID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> GetReceiptHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid receiptID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Receipts> GetReceiptsAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Receipts>> GetReceiptsAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, int? unitdp = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<RepeatingInvoices> GetRepeatingInvoiceAsync(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<RepeatingInvoices>> GetRepeatingInvoiceAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetRepeatingInvoiceAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetRepeatingInvoiceAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, string fileName, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetRepeatingInvoiceAttachmentByIdAsync(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Stream>> GetRepeatingInvoiceAttachmentByIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, Guid attachmentID, string contentType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> GetRepeatingInvoiceAttachmentsAsync(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> GetRepeatingInvoiceAttachmentsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<HistoryRecords> GetRepeatingInvoiceHistoryAsync(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<HistoryRecords>> GetRepeatingInvoiceHistoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<RepeatingInvoices> GetRepeatingInvoicesAsync(string accessToken, string xeroTenantId, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<RepeatingInvoices>> GetRepeatingInvoicesAsyncWithHttpInfo(string accessToken, string xeroTenantId, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ReportWithRows> GetReportAgedPayablesByContactAsync(string accessToken, string xeroTenantId, Guid contactId, DateTime? date = null, DateTime? fromDate = null, DateTime? toDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ReportWithRows>> GetReportAgedPayablesByContactAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactId, DateTime? date = null, DateTime? fromDate = null, DateTime? toDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ReportWithRows> GetReportAgedReceivablesByContactAsync(string accessToken, string xeroTenantId, Guid contactId, DateTime? date = null, DateTime? fromDate = null, DateTime? toDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ReportWithRows>> GetReportAgedReceivablesByContactAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactId, DateTime? date = null, DateTime? fromDate = null, DateTime? toDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ReportWithRows> GetReportBalanceSheetAsync(string accessToken, string xeroTenantId, DateTime? date = null, int? periods = null, string timeframe = null, string trackingOptionID1 = null, string trackingOptionID2 = null, bool? standardLayout = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ReportWithRows>> GetReportBalanceSheetAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? date = null, int? periods = null, string timeframe = null, string trackingOptionID1 = null, string trackingOptionID2 = null, bool? standardLayout = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ReportWithRows> GetReportBankSummaryAsync(string accessToken, string xeroTenantId, DateTime? fromDate = null, DateTime? toDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ReportWithRows>> GetReportBankSummaryAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? fromDate = null, DateTime? toDate = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ReportWithRows> GetReportBudgetSummaryAsync(string accessToken, string xeroTenantId, DateTime? date = null, int? periods = null, int? timeframe = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ReportWithRows>> GetReportBudgetSummaryAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? date = null, int? periods = null, int? timeframe = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ReportWithRows> GetReportExecutiveSummaryAsync(string accessToken, string xeroTenantId, DateTime? date = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ReportWithRows>> GetReportExecutiveSummaryAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? date = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ReportWithRows> GetReportFromIdAsync(string accessToken, string xeroTenantId, string reportID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ReportWithRows>> GetReportFromIdAsyncWithHttpInfo(string accessToken, string xeroTenantId, string reportID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ReportWithRows> GetReportProfitAndLossAsync(string accessToken, string xeroTenantId, DateTime? fromDate = null, DateTime? toDate = null, int? periods = null, string timeframe = null, string trackingCategoryID = null, string trackingCategoryID2 = null, string trackingOptionID = null, string trackingOptionID2 = null, bool? standardLayout = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ReportWithRows>> GetReportProfitAndLossAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? fromDate = null, DateTime? toDate = null, int? periods = null, string timeframe = null, string trackingCategoryID = null, string trackingCategoryID2 = null, string trackingOptionID = null, string trackingOptionID2 = null, bool? standardLayout = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ReportWithRows> GetReportsListAsync(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ReportWithRows>> GetReportsListAsyncWithHttpInfo(string accessToken, string xeroTenantId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Reports> GetReportTenNinetyNineAsync(string accessToken, string xeroTenantId, string reportYear = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Reports>> GetReportTenNinetyNineAsyncWithHttpInfo(string accessToken, string xeroTenantId, string reportYear = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ReportWithRows> GetReportTrialBalanceAsync(string accessToken, string xeroTenantId, DateTime? date = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ReportWithRows>> GetReportTrialBalanceAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? date = null, bool? paymentsOnly = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TaxRates> GetTaxRateByTaxTypeAsync(string accessToken, string xeroTenantId, string taxType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TaxRates>> GetTaxRateByTaxTypeAsyncWithHttpInfo(string accessToken, string xeroTenantId, string taxType, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TaxRates> GetTaxRatesAsync(string accessToken, string xeroTenantId, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TaxRates>> GetTaxRatesAsyncWithHttpInfo(string accessToken, string xeroTenantId, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TrackingCategories> GetTrackingCategoriesAsync(string accessToken, string xeroTenantId, string where = null, string order = null, bool? includeArchived = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TrackingCategories>> GetTrackingCategoriesAsyncWithHttpInfo(string accessToken, string xeroTenantId, string where = null, string order = null, bool? includeArchived = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TrackingCategories> GetTrackingCategoryAsync(string accessToken, string xeroTenantId, Guid trackingCategoryID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TrackingCategories>> GetTrackingCategoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid trackingCategoryID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Users> GetUserAsync(string accessToken, string xeroTenantId, Guid userID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Users>> GetUserAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid userID, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Users> GetUsersAsync(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Users>> GetUsersAsyncWithHttpInfo(string accessToken, string xeroTenantId, DateTime? ifModifiedSince = null, string where = null, string order = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ImportSummaryObject> PostSetupAsync(string accessToken, string xeroTenantId, Setup setup, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ImportSummaryObject>> PostSetupAsyncWithHttpInfo(string accessToken, string xeroTenantId, Setup setup, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Accounts> UpdateAccountAsync(string accessToken, string xeroTenantId, Guid accountID, Accounts accounts, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Accounts>> UpdateAccountAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid accountID, Accounts accounts, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> UpdateAccountAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid accountID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> UpdateAccountAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid accountID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<BankTransactions> UpdateBankTransactionAsync(string accessToken, string xeroTenantId, Guid bankTransactionID, BankTransactions bankTransactions, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BankTransactions>> UpdateBankTransactionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransactionID, BankTransactions bankTransactions, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> UpdateBankTransactionAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid bankTransactionID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> UpdateBankTransactionAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransactionID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> UpdateBankTransferAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid bankTransferID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> UpdateBankTransferAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid bankTransferID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<Contacts> UpdateContactAsync(Guid contactID, Contacts contacts, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateContactAsync(accessToken, xeroExtendedConfiguration.TenantId, contactID, contacts, idempotencyKey, cancellationToken);
    }

    public async Task<Contacts> UpdateContactAsync(string accessToken, string xeroTenantId, Guid contactID, Contacts contacts, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Contacts> response = await UpdateContactAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, contacts, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Contacts>> UpdateContactAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, Contacts contacts, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Contacts> response = await accountingXeroClient.UpdateContactAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, contacts, idempotencyKey, cancellationToken);
        return response;
    }
    public async Task<Attachments> UpdateContactAttachmentByFileNameAsync(Guid contactID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateContactAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, contactID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> UpdateContactAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid contactID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await UpdateContactAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> UpdateContactAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.UpdateContactAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, contactID, fileName, body, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<ContactGroups> UpdateContactGroupAsync(Guid contactGroupID, ContactGroups contactGroups, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateContactGroupAsync(accessToken, xeroExtendedConfiguration.TenantId, contactGroupID, contactGroups, idempotencyKey, cancellationToken);
    }

    public async Task<ContactGroups> UpdateContactGroupAsync(string accessToken, string xeroTenantId, Guid contactGroupID, ContactGroups contactGroups, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ContactGroups> response = await UpdateContactGroupAsyncWithHttpInfo(accessToken, xeroTenantId, contactGroupID, contactGroups, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<ContactGroups>> UpdateContactGroupAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid contactGroupID, ContactGroups contactGroups, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<ContactGroups> response = await accountingXeroClient.UpdateContactGroupAsyncWithHttpInfo(accessToken, xeroTenantId, contactGroupID, contactGroups, idempotencyKey, cancellationToken);
        return response;
    }

    public Task<CreditNotes> UpdateCreditNoteAsync(string accessToken, string xeroTenantId, Guid creditNoteID, CreditNotes creditNotes, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<CreditNotes>> UpdateCreditNoteAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, CreditNotes creditNotes, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> UpdateCreditNoteAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid creditNoteID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> UpdateCreditNoteAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid creditNoteID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ExpenseClaims> UpdateExpenseClaimAsync(string accessToken, string xeroTenantId, Guid expenseClaimID, ExpenseClaims expenseClaims, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ExpenseClaims>> UpdateExpenseClaimAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid expenseClaimID, ExpenseClaims expenseClaims, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<Invoices> UpdateInvoiceAsync(Guid invoiceID, Invoices invoices, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateInvoiceAsync(accessToken, xeroExtendedConfiguration.TenantId, invoiceID, invoices, unitdp, idempotencyKey, cancellationToken);
    }

    public async Task<Invoices> UpdateInvoiceAsync(string accessToken, string xeroTenantId, Guid invoiceID, Invoices invoices, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Invoices> response = await UpdateInvoiceAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, invoices, unitdp, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Invoices>> UpdateInvoiceAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, Invoices invoices, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Invoices> response = await accountingXeroClient.UpdateInvoiceAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, invoices, unitdp, idempotencyKey, cancellationToken);
        return response;
    }

    public async Task<Attachments> UpdateInvoiceAttachmentByFileNameAsync(Guid invoiceID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdateInvoiceAttachmentByFileNameAsync(accessToken, xeroExtendedConfiguration.TenantId, invoiceID, fileName, body, idempotencyKey, cancellationToken);
    }

    public async Task<Attachments> UpdateInvoiceAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid invoiceID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await UpdateInvoiceAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, fileName, body, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<Attachments>> UpdateInvoiceAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid invoiceID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<Attachments> response = await accountingXeroClient.UpdateInvoiceAttachmentByFileNameAsyncWithHttpInfo(accessToken, xeroTenantId, invoiceID, fileName, body, idempotencyKey, cancellationToken);
        return response;
    }

    public Task<Items> UpdateItemAsync(string accessToken, string xeroTenantId, Guid itemID, Items items, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Items>> UpdateItemAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid itemID, Items items, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<LinkedTransactions> UpdateLinkedTransactionAsync(string accessToken, string xeroTenantId, Guid linkedTransactionID, LinkedTransactions linkedTransactions, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<LinkedTransactions>> UpdateLinkedTransactionAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid linkedTransactionID, LinkedTransactions linkedTransactions, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ManualJournals> UpdateManualJournalAsync(string accessToken, string xeroTenantId, Guid manualJournalID, ManualJournals manualJournals, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ManualJournals>> UpdateManualJournalAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid manualJournalID, ManualJournals manualJournals, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> UpdateManualJournalAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid manualJournalID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> UpdateManualJournalAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid manualJournalID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<BankTransactions> UpdateOrCreateBankTransactionsAsync(string accessToken, string xeroTenantId, BankTransactions bankTransactions, bool? summarizeErrors = null, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<BankTransactions>> UpdateOrCreateBankTransactionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, BankTransactions bankTransactions, bool? summarizeErrors = null, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Contacts> UpdateOrCreateContactsAsync(string accessToken, string xeroTenantId, Contacts contacts, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Contacts>> UpdateOrCreateContactsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Contacts contacts, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<CreditNotes> UpdateOrCreateCreditNotesAsync(string accessToken, string xeroTenantId, CreditNotes creditNotes, bool? summarizeErrors = null, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<CreditNotes>> UpdateOrCreateCreditNotesAsyncWithHttpInfo(string accessToken, string xeroTenantId, CreditNotes creditNotes, bool? summarizeErrors = null, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Employees> UpdateOrCreateEmployeesAsync(string accessToken, string xeroTenantId, Employees employees, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Employees>> UpdateOrCreateEmployeesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Employees employees, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Invoices> UpdateOrCreateInvoicesAsync(string accessToken, string xeroTenantId, Invoices invoices, bool? summarizeErrors = null, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Invoices>> UpdateOrCreateInvoicesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Invoices invoices, bool? summarizeErrors = null, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Items> UpdateOrCreateItemsAsync(string accessToken, string xeroTenantId, Items items, bool? summarizeErrors = null, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Items>> UpdateOrCreateItemsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Items items, bool? summarizeErrors = null, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ManualJournals> UpdateOrCreateManualJournalsAsync(string accessToken, string xeroTenantId, ManualJournals manualJournals, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<ManualJournals>> UpdateOrCreateManualJournalsAsyncWithHttpInfo(string accessToken, string xeroTenantId, ManualJournals manualJournals, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PurchaseOrders> UpdateOrCreatePurchaseOrdersAsync(string accessToken, string xeroTenantId, PurchaseOrders purchaseOrders, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<PurchaseOrders>> UpdateOrCreatePurchaseOrdersAsyncWithHttpInfo(string accessToken, string xeroTenantId, PurchaseOrders purchaseOrders, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Quotes> UpdateOrCreateQuotesAsync(string accessToken, string xeroTenantId, Quotes quotes, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Quotes>> UpdateOrCreateQuotesAsyncWithHttpInfo(string accessToken, string xeroTenantId, Quotes quotes, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<RepeatingInvoices> UpdateOrCreateRepeatingInvoicesAsync(string accessToken, string xeroTenantId, RepeatingInvoices repeatingInvoices, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<RepeatingInvoices>> UpdateOrCreateRepeatingInvoicesAsyncWithHttpInfo(string accessToken, string xeroTenantId, RepeatingInvoices repeatingInvoices, bool? summarizeErrors = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<PurchaseOrders> UpdatePurchaseOrderAsync(Guid purchaseOrderID, PurchaseOrders purchaseOrders, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(xeroExtendedConfiguration.TenantId, nameof(xeroExtendedConfiguration.TenantId));
        string accessToken = (await RequestClientCredentialsTokenAsync()).AccessToken;

        return await UpdatePurchaseOrderAsync(accessToken, xeroExtendedConfiguration.TenantId, purchaseOrderID, purchaseOrders, idempotencyKey, cancellationToken);
    }

    public async Task<PurchaseOrders> UpdatePurchaseOrderAsync(string accessToken, string xeroTenantId, Guid purchaseOrderID, PurchaseOrders purchaseOrders, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PurchaseOrders> response = await UpdatePurchaseOrderAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, purchaseOrders, idempotencyKey, cancellationToken);
        return response.Data;
    }

    public async Task<ApiResponse<PurchaseOrders>> UpdatePurchaseOrderAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid purchaseOrderID, PurchaseOrders purchaseOrders, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        ApiResponse<PurchaseOrders> response = await accountingXeroClient.UpdatePurchaseOrderAsyncWithHttpInfo(accessToken, xeroTenantId, purchaseOrderID, purchaseOrders, idempotencyKey, cancellationToken);
        return response;
    }

    public Task<Attachments> UpdatePurchaseOrderAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid purchaseOrderID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> UpdatePurchaseOrderAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid purchaseOrderID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Quotes> UpdateQuoteAsync(string accessToken, string xeroTenantId, Guid quoteID, Quotes quotes, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Quotes>> UpdateQuoteAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, Quotes quotes, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> UpdateQuoteAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid quoteID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> UpdateQuoteAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid quoteID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Receipts> UpdateReceiptAsync(string accessToken, string xeroTenantId, Guid receiptID, Receipts receipts, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Receipts>> UpdateReceiptAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid receiptID, Receipts receipts, int? unitdp = null, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> UpdateReceiptAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid receiptID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> UpdateReceiptAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid receiptID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<RepeatingInvoices> UpdateRepeatingInvoiceAsync(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, RepeatingInvoices repeatingInvoices, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<RepeatingInvoices>> UpdateRepeatingInvoiceAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, RepeatingInvoices repeatingInvoices, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachments> UpdateRepeatingInvoiceAttachmentByFileNameAsync(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Attachments>> UpdateRepeatingInvoiceAttachmentByFileNameAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid repeatingInvoiceID, string fileName, byte[] body, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TaxRates> UpdateTaxRateAsync(string accessToken, string xeroTenantId, TaxRates taxRates, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TaxRates>> UpdateTaxRateAsyncWithHttpInfo(string accessToken, string xeroTenantId, TaxRates taxRates, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TrackingCategories> UpdateTrackingCategoryAsync(string accessToken, string xeroTenantId, Guid trackingCategoryID, TrackingCategory trackingCategory, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TrackingCategories>> UpdateTrackingCategoryAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid trackingCategoryID, TrackingCategory trackingCategory, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TrackingOptions> UpdateTrackingOptionsAsync(string accessToken, string xeroTenantId, Guid trackingCategoryID, Guid trackingOptionID, TrackingOption trackingOption, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<TrackingOptions>> UpdateTrackingOptionsAsyncWithHttpInfo(string accessToken, string xeroTenantId, Guid trackingCategoryID, Guid trackingOptionID, TrackingOption trackingOption, string idempotencyKey = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
    #endregion
}

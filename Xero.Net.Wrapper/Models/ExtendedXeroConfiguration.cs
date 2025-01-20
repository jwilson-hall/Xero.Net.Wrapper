using Xero.NetStandard.OAuth2.Config;

namespace Xero.Net.Wrapper.Models;

public class ExtendedXeroConfiguration : ExtendedXeroConfiguration<List<string>> { }

public class ExtendedXeroConfiguration<T> : XeroConfiguration
{
    public string? TenantId { get; set; }
    public T? TenantIds { get; set; }
    public bool DisableTokenCaching { get; set; }
}

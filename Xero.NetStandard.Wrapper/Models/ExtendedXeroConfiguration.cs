using Xero.NetStandard.OAuth2.Config;

namespace Xero.NetStandard.Wrapper.Models;
public class ExtendedXeroConfiguration : XeroConfiguration
{
    public string? TenantId { get; set; }
    public List<string>? TenantIds { get; set; }
}

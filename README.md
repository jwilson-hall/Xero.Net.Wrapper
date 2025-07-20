# Xero.Net.Wrapper

[![NuGet](https://img.shields.io/nuget/v/Xero.Net.Wrapper.svg)](https://www.nuget.org/packages/Xero.Net.Wrapper/)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download/dotnet/8.0)

**Xero.Net.Wrapper** is a comprehensive .NET 8 library that provides a strongly-typed, easy-to-use wrapper for the entire Xero API ecosystem. Built on top of the official Xero.NetStandard.OAuth2 library, it simplifies integration with Xero by handling authentication, token caching, request construction, and response parsing.

## 🚀 Features

- **Complete API Coverage**: Support for all Xero APIs including Accounting, Payroll (AU/NZ/UK), Files, Finance, Assets, App Store, Bank Feeds, Identity, and Projects
- **Smart Token Management**: Built-in token caching with configurable expiration and refresh handling
- **Dependency Injection Ready**: First-class support for Microsoft.Extensions.DependencyInjection
- **OAuth2 Support**: Full support for both Authorization Code and Client Credentials flows, including PKCE
- **Modern .NET**: Built for .NET 8 with nullable reference types and async/await patterns
- **Tenant Management**: Simplified multi-tenant support with automatic tenant ID handling
- **Strongly Typed**: All API responses use strongly-typed models for better development experience

## 📦 Installation

Install the package via NuGet Package Manager:

```bash
dotnet add package Xero.Net.Wrapper
```

Or via Package Manager Console:

```powershell
Install-Package Xero.Net.Wrapper
```

## 🏗️ Quick Start

### 1. Register Services

Add Xero services to your dependency injection container:

```csharp
using Xero.Net.Wrapper.Extensions;

// In your Program.cs or Startup.cs
services.AddXeroNetStandardWrapper(config =>
{
    config.ClientId = "your-xero-client-id";
    config.ClientSecret = "your-xero-client-secret";
    config.TenantId = "your-tenant-id"; // Optional: set default tenant
    config.DisableTokenCaching = false; // Optional: disable caching if needed
    
    // Standard Xero configuration options
    config.CallbackUri = "https://yourapp.com/callback";
    config.Scope = "openid profile email accounting.transactions";
    config.State = "your-state-parameter";
});
```

### 2. Use the Service

Inject and use `XeroService` in your controllers or services:

```csharp
public class AccountingController : ControllerBase
{
    private readonly XeroService _xeroService;

    public AccountingController(XeroService xeroService)
    {
        _xeroService = xeroService;
    }

    public async Task<IActionResult> GetContacts()
    {
        // Using configured tenant ID
        var contacts = await _xeroService.GetContactsAsync();
        
        // Or with explicit token and tenant
        var token = await _xeroService.RequestClientCredentialsTokenAsync();
        var contactsExplicit = await _xeroService.GetContactsAsync(token.AccessToken, "specific-tenant-id");
        
        return Ok(contacts);
    }
}
```

## 🔐 Authentication Flows

### Authorization Code Flow

```csharp
// 1. Build login URI
var loginUri = _xeroService.BuildLoginUri("your-state", "accounting.transactions");

// 2. Handle callback and exchange code for token
var token = await _xeroService.RequestAccessTokenAsync(authorizationCode);

// 3. Get available tenants
var tenants = await _xeroService.GetConnectionsAsync(token);
```

### Client Credentials Flow

```csharp
// For machine-to-machine scenarios
var token = await _xeroService.RequestClientCredentialsTokenAsync(fetchTenants: true);
```

### PKCE Flow

```csharp
var codeVerifier = "your-code-verifier";
var loginUri = _xeroService.BuildLoginUriPkce(codeVerifier, "state", "scope");
var token = await _xeroService.RequestAccessTokenPkceAsync(authorizationCode, codeVerifier);
```

## 📚 API Coverage

The library provides access to all major Xero APIs:

- **Accounting API**: Contacts, Invoices, Payments, Items, Accounts, etc.
- **Payroll APIs**: Employees, Payslips, Leave applications (AU/NZ/UK variants)
- **Files API**: File management and document storage
- **Finance API**: Financial statements and reporting
- **Assets API**: Fixed asset management
- **Bank Feeds API**: Bank transaction feeds
- **App Store API**: Marketplace and subscription management
- **Identity API**: User and organization information
- **Projects API**: Project and time tracking

## ⚙️ Configuration Options

```csharp
services.AddXeroNetStandardWrapper(config =>
{
    // Required OAuth2 settings
    config.ClientId = "your-client-id";
    config.ClientSecret = "your-client-secret";
    config.CallbackUri = "https://yourapp.com/callback";
    
    // Optional wrapper-specific settings
    config.TenantId = "default-tenant-id";           // Default tenant for API calls
    config.DisableTokenCaching = false;              // Disable automatic token caching
    
    // Optional OAuth2 settings
    config.Scope = "accounting.transactions";        // Required scopes
    config.State = "security-state";                 // CSRF protection
});
```

## 🔄 Token Caching

The library automatically caches access tokens to improve performance and reduce API calls:

- Tokens are cached with automatic expiration based on token lifetime
- Cache keys are prefixed to avoid conflicts
- Caching can be disabled via `DisableTokenCaching = true`
- Uses `IMemoryCache` for in-memory storage

## 🏗️ Architecture

The library uses a modular architecture with partial classes:

- **XeroService**: Main service implementing `IXeroClient`
- **Partial API Services**: Organized by Xero API (Accounting, Payroll, etc.)
- **ExtendedXeroConfiguration**: Enhanced configuration with caching and tenant options
- **XeroCache**: Wrapper around `IMemoryCache` with prefixed keys

## 🤝 Contributing

Contributions are welcome! Please feel free to submit issues, feature requests, or pull requests.

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 🔗 Related Links

- [Xero Developer Documentation](https://developer.xero.com/)
- [Xero.NetStandard.OAuth2](https://github.com/XeroAPI/Xero-NetStandard)
- [NuGet Package](https://www.nuget.org/packages/Xero.Net.Wrapper/)

## 📞 Support

For issues related to this wrapper library, please [open an issue](https://github.com/your-username/Xero.Net.Wrapper/issues) on GitHub.

For general Xero API questions, refer to the [Xero Developer Community](https://developer.xero.com/community/).
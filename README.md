# Xero.Net.Wrapper

[![NuGet](https://img.shields.io/nuget/v/Xero.Net.Wrapper.svg)](https://www.nuget.org/packages/Xero.Net.Wrapper/)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download/dotnet/8.0)

**Xero.Net.Wrapper** is a .NET 8 library that provides a strongly-typed wrapper for the Xero API. Built on top of the official Xero.NetStandard.OAuth2 library, it simplifies integration with Xero by handling authentication, token caching, request construction, and response parsing. Currently optimized for client credentials flow with single tenant scenarios.

## 🚀 Features

- **Client Credentials Support**: Optimized for machine-to-machine authentication scenarios
- **Single Tenant Focus**: Designed for applications working with a single Xero tenant
- **Smart Token Management**: Built-in token caching with configurable expiration and refresh handling
- **Dependency Injection Ready**: First-class support for Microsoft.Extensions.DependencyInjection
- **Modern .NET**: Built for .NET 8 with nullable reference types and async/await patterns
- **Strongly Typed**: API responses use strongly-typed models for better development experience
- **Comprehensive API Coverage**: Supports all major Xero APIs (PayrollUK and PayrollNZ excluded)

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
    config.TenantId = "your-tenant-id";
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
        // Using client credentials flow with configured tenant ID
        var contacts = await _xeroService.GetContactsAsync();
        
        return Ok(contacts);
    }
}
```

## 🔐 Authentication

### Client Credentials Flow

The library is optimized for client credentials flow, which is ideal for machine-to-machine scenarios:

```csharp
// The service will automatically handle client credentials authentication
// when you call any API method
var contacts = await _xeroService.GetContactsAsync();

// Or explicitly request a token if needed
var token = await _xeroService.RequestClientCredentialsTokenAsync();
```

## 📚 API Coverage

The library provides access to most Xero APIs:

- **Accounting API**: Contacts, Invoices, Payments, Items, Accounts, etc. ✅
- **Payroll AU API**: Employees, Payslips, Leave applications (Australia) ✅
- **Files API**: File management and document storage ✅
- **Finance API**: Financial statements and reporting ✅
- **Assets API**: Fixed asset management ✅
- **Bank Feeds API**: Bank transaction feeds ✅
- **App Store API**: Marketplace and subscription management ✅
- **Identity API**: User and organization information ✅
- **Projects API**: Project and time tracking ✅
- **Payroll UK API**: UK-specific payroll functionality ❌
- **Payroll NZ API**: New Zealand-specific payroll functionality ❌

> **Legend**: ✅ Available | ❌ Not Implemented

## ⚙️ Configuration Options

```csharp
services.AddXeroNetStandardWrapper(config =>
{
    // Required OAuth2 settings
    config.ClientId = "your-client-id";
    config.ClientSecret = "your-client-secret";
    config.TenantId = "your-tenant-id";              // Required: single tenant ID
    
    // Optional wrapper-specific settings
    config.DisableTokenCaching = false;              // Disable automatic token caching
    
    // Optional OAuth2 settings
    config.CallbackUri = "https://yourapp.com/callback";
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

## 🤝 Contributing

Contributions are welcome! Please feel free to submit issues, feature requests, or pull requests.

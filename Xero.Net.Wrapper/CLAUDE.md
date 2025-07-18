# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a .NET 8 wrapper library for the Xero API that simplifies integration with Xero's OAuth2 services. The library provides a unified service layer with built-in token caching and tenant management.

## Common Commands

### Build
```bash
dotnet build
```

### Test
```bash
dotnet test
```

### Pack for NuGet
```bash
dotnet pack
```

### Build specific configuration
```bash
dotnet build -c Release
```

## Architecture

### Core Components

- **XeroService** (`Api/XeroService.cs`) - Main service class that implements IXeroClient and provides wrapped OAuth2 functionality with caching
- **XeroAccountingService** (`Api/XeroAccountingService.cs`) - Large partial class containing all accounting API methods 
- **XeroFileService** (`Api/XeroFileService.cs`) - Partial class containing all file API methods
- **XeroCache** (`XeroCache.cs`) - Memory cache wrapper for token caching with prefixed keys
- **ExtendedXeroConfiguration** (`Models/ExtendedXeroConfiguration.cs`) - Configuration model extending XeroConfiguration with additional properties like TenantId and DisableTokenCaching

### Key Patterns

- **Partial Classes**: XeroService is split across multiple files using partial classes for better organization
- **Dependency Injection**: Uses Microsoft.Extensions.DependencyInjection with extension methods in `ServiceCollectionExtensions.cs`
- **Token Caching**: Implements automatic token caching with configurable expiration, can be disabled via configuration
- **Tenant Management**: Built-in tenant ID handling through ExtendedXeroConfiguration
- **Async/Await**: All API methods are async with proper CancellationToken support

### Service Registration

Register services using the extension method:
```csharp
services.AddXeroNetStandardWrapper(config => {
    config.ClientId = "your-client-id";
    config.ClientSecret = "your-client-secret";
    config.TenantId = "your-tenant-id";
    config.DisableTokenCaching = false;
});
```

### Dependencies

- Built on Xero.NetStandard.OAuth2 (v10.0.0)
- Uses Microsoft.Extensions.Caching.Memory for token caching
- Targets .NET 8.0 with nullable reference types enabled

## Project Structure

- `Api/` - Service layer with XeroService partial classes
- `Extensions/` - Dependency injection extensions
- `Models/` - Configuration models
- Root contains cache implementation and project files

## Development Notes

- XeroService methods typically have two overloads: one that uses the configured TenantId, and one that accepts explicit access token and tenant ID parameters
- Token caching uses a prefixed key system to avoid conflicts
- All API methods include proper null checks and throw meaningful exceptions
- The library handles both client credentials and authorization code OAuth2 flows
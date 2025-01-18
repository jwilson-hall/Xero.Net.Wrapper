using Microsoft.Extensions.Caching.Memory;
using System;
using System.Threading.Tasks;
using Xero.NetStandard.OAuth2.Token;

namespace Xero.NetStandard.Wrapper;

public class XeroCache(IMemoryCache memoryCache)
{
    private const string CacheKeyPrefix = "XeroCache_";
    public void Delete(string key)
    {
        memoryCache.Remove(GetPrefixedKey(key));
    }

    public T? Get<T>(string key)
    {
        memoryCache.TryGetValue(GetPrefixedKey(key), out T value);
        return value;
    }

    public void Set<T>(string key, T value, TimeSpan expiration)
    {
        var cacheEntryOptions = new MemoryCacheEntryOptions()
            .SetAbsoluteExpiration(expiration);

        memoryCache.Set(GetPrefixedKey(key), value, cacheEntryOptions);
    }

    public bool TryGet<T>(string key, out T value)
    {
        return memoryCache.TryGetValue(GetPrefixedKey(key), out value);
    }

    private string GetPrefixedKey(string key)
    {
        return $"{CacheKeyPrefix}{key}";
    }
}

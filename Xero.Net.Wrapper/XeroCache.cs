using Microsoft.Extensions.Caching.Memory;

namespace Xero.Net.Wrapper;

public class XeroCache(IMemoryCache memoryCache)
{
    private const string CacheKeyPrefix = "XeroCache_";
    public void Remove(string key)
    {
        memoryCache.Remove(GetPrefixedKey(key));
    }

    public T? Get<T>(string key)
    {
        memoryCache.TryGetValue(GetPrefixedKey(key), out T? value);
        return value;
    }

    public void Set<T>(string key, T value, TimeSpan expiration)
    {
        MemoryCacheEntryOptions cacheEntryOptions = new MemoryCacheEntryOptions()
            .SetAbsoluteExpiration(expiration);

        memoryCache.Set(GetPrefixedKey(key), value, cacheEntryOptions);
    }

    public bool TryGetValue<T>(string key, out T? value)
    {
        return memoryCache.TryGetValue(GetPrefixedKey(key), out value);
    }

    private string GetPrefixedKey(string key)
    {
        return $"{CacheKeyPrefix}{key}";
    }
}

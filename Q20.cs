using System;

public class CacheItem<TValue>
{
    public TValue Value { get; set; }
    public DateTime ExpirationTime { get; set; }

    public CacheItem(TValue value, TimeSpan timeToLive)
    {
        Value = value;
        ExpirationTime = DateTime.Now.Add(timeToLive);
    }

    public bool IsExpired => DateTime.Now > ExpirationTime;
}

public class Cache<TKey, TValue>
{
    private readonly Dictionary<TKey, CacheItem<TValue>> _cache = new Dictionary<TKey, CacheItem<TValue>>();

    public void Add(TKey key, TValue value, TimeSpan timeToLive)
    {
        _cache[key] = new CacheItem<TValue>(value, timeToLive);
    }

    public TValue Get(TKey key)
    {
        if (_cache.TryGetValue(key, out var item))
        {
            if (!item.IsExpired)
            {
                return item.Value;
            }

            _cache.Remove(key); 
        }
        return default;
    }

    public bool Remove(TKey key)
    {
        return _cache.Remove(key);
    }

    public bool Contains(TKey key)
    {
        if (_cache.TryGetValue(key, out var item))
        {
            if (!item.IsExpired)
                return true;

            _cache.Remove(key);
        }
        return false;
    }
}
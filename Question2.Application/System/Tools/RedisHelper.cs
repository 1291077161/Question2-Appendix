using StackExchange.Redis;

public class RedisHelper
{
    private ConnectionMultiplexer Redis { get; set; }
    private IDatabase DB { get; set; }

    public RedisHelper(string connection)
    {
        Redis = ConnectionMultiplexer.Connect(connection);
        DB = Redis.GetDatabase();
    }

    public bool SetValue(string key, string value)
    {
        return DB.StringSet(key, value);
    }

    public string? GetValue(string key)
    {
        return DB.StringGet(key);
    }

    public bool DeleteKey(string key)
    {
        return DB.KeyDelete(key);
    }
}
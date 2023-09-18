using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisDotNetFramework.Infra
{
    public interface IRedisStore
    {
        IDatabase GetRedisDatabase(int dbNumber);
        IServer RedisServer();
    }
}

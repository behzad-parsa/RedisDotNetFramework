using RedisDotNetFramework.Infra;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedisDotNetFramework.Api.App_Start.Ioc
{
    public class GlobalIocRegistry : Registry
    {
        public GlobalIocRegistry()
        {
            For<IRedisCacheService>().Use<RedisCacheService>();
            For<IRedisStore>().Use<RedisStore>();
        }
    }
}
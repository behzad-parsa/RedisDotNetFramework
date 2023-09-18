﻿using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisDotNetFramework.Infra
{
    public class RedisStore : IRedisStore
    {
        private readonly Lazy<ConnectionMultiplexer> lazyConnection;

        public RedisStore()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["RedisConnectionString"].ConnectionString;
            lazyConnection = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(connectionString));
        }
        public ConnectionMultiplexer Connection
        {
            get => lazyConnection.Value;
        }

        public IDatabase GetRedisDatabase(int dbNumber) =>
            Connection.GetDatabase(dbNumber);
        public IServer RedisServer() => Connection.GetServer(Connection.GetEndPoints().FirstOrDefault());


    }
}

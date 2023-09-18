using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisDotNetFramework.Infra
{
    public interface IRedisCacheService
    {
        T GetObject<T>(string key, int dbNumber);
        bool SetObject<T>(string key, T value, int dbNumber, TimeSpan? expireTime = null);
        bool RemoveKey(string key, int dbNumber);

        bool RemoveDatabase(int dbNumber);
        bool RemoveDatabase();
        List<T> GetList<T>(string key, int dbNumber);
        bool InsertToEndOfList<T>(string key, T value, int dbNumber);
        bool SetList<T>(string key, List<T> value, int dbNumber);
    }
}

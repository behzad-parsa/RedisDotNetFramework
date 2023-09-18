using RedisDotNetFramework.Api.Models;
using RedisDotNetFramework.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RedisDotNetFramework.Api.Controllers
{
    public class RedisController : ApiController
    {
        private readonly IRedisCacheService redisCacheService;

        public RedisController(IRedisCacheService redisCacheService)
        {
            this.redisCacheService = redisCacheService;
        }

        [HttpGet]
        public IEnumerable<User> Get(string key)
        {
            var users = redisCacheService.GetObject<List<User>>(key, 0);
            return users;
        }


        [HttpPost]
        public void Post(List<User> user,string key)
        {
            //singleOBject
            redisCacheService.SetObject(key, user.FirstOrDefault(), 0);

            //List of Object
            redisCacheService.SetObject(key, user, 0);
        }

        [HttpDelete]
        public void Delete(string key)
        {

            redisCacheService.RemoveKey(key,0);

            //Or
            //redisCacheService.RemoveDatabase(0);
        }
    }
}

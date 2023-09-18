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
    public class TestController : ApiController
    {
        private readonly IRedisCacheService redisCacheService;
        //public TestController()
        //{

        //}
        public TestController(IRedisCacheService redisCacheService)
        {
            this.redisCacheService = redisCacheService;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post(User user)
        {

        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

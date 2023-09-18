using RedisDotNetFramework.Api.App_Start.Ioc;
using RedisDotNetFramework.Api.StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace RedisDotNetFramework.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = ObjectFactory.Current;
            GlobalConfiguration.Configuration.Services.Replace(
                typeof(IHttpControllerActivator), new SmWebApiControllerActivator(container));

            //config.Services.Replace(typeof(IFilterProvider), new SmWebApiFilterProvider(container));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

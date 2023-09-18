using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedisDotNetFramework.Api.App_Start.Ioc
{
    public class ObjectFactory
    {
        private static IContainer _current;
        public static IContainer Current
        {
            get { return _current; }
        }

        static ObjectFactory()
        {
            _current = ConfigureContainer();
        }

        public static IContainer ConfigureContainer()
        {
            IContainer container = new Container();
            container.Configure(configuration => configuration.AddRegistry(new GlobalIocRegistry()));
            //GlobalContainer.SetContainer(container);
            return container;
        }
    }
}
using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;
using JSONBasedWebService.Core.Parser;

namespace JSONBasedWebService.Web.App_Start
{
    public class AutofacWebapiConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }
        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register Web API controllers
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            //Register Custom Interfaces / Classes  
            builder.RegisterType<JSONParser>()
                   .As<IParser>()
                   .InstancePerRequest();

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }
    }
}
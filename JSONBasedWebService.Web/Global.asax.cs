using JSONBasedWebService.Web.App_Start;
using System.Web.Http;
using System.Web.Mvc;

namespace JSONBasedWebService.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            Bootstrapper.Run();

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
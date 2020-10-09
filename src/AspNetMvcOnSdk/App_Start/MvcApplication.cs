using System.Web;

namespace AspNetMvcOnSdk
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes();
        }
    }
}
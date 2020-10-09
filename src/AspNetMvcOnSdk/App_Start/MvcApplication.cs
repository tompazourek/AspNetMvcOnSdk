using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI;
using AspNetMvcOnSdk;

[assembly: PreApplicationStartMethod(typeof(MvcApplication), nameof(MvcApplication.InitializeApplicationBaseType))]

namespace AspNetMvcOnSdk
{
    public class MvcApplication : HttpApplication
    {
        public static void InitializeApplicationBaseType()
        {
            PageParser.DefaultApplicationBaseType = typeof(MvcApplication);
        }

        protected void Application_Start()
        {
            RouteTable.Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            RouteTable.Routes.MapRoute("Default", "{controller}/{action}", new { controller = "Home", action = "Index" });
        }
    }
}
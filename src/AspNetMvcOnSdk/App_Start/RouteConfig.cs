using System.Web.Mvc;
using System.Web.Routing;

namespace AspNetMvcOnSdk
{
    public static class RouteConfig
    {
        private static readonly RouteCollection Routes = RouteTable.Routes;

        public static void RegisterRoutes()
        {
            Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            Routes.MapRoute
            (
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional,
                }
            );
        }
    }
}
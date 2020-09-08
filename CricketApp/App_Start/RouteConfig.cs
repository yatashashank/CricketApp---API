using System.Web.Mvc;
using System.Web.Routing;

namespace CricketApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               "Help Area",
               "",
               new { controller = "Home", action = "Index" }
            );
        }
    }
}

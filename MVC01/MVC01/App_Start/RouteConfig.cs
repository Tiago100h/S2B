using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC01
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Index2",
                url: "Index2",
                defaults: new { controller = "Hello", action = "Index2" }
            );
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}/{nome}",
                defaults: new { controller = "Hello", action = "Index", id = UrlParameter.Optional, nome = UrlParameter.Optional }
            );
        }
    }
}

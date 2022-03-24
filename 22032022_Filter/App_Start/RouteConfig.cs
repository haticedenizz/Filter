using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _22032022_Filter
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             name: "iletisim",
             url: "iletisim",
             defaults: new { controller = "Home", action = "İletisim" });

            routes.MapRoute(
                           name: "Default",
                           url: "{controller}/{action}/{id}",
                           defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                       );

            routes.MapRoute(
                name: "Default2",
                url: "{controller}/Belge/{belgeno}",
                defaults: new { controller = "Home", action = "Belge", belgeno = UrlParameter.Optional }
            );

           
        }
    }
}

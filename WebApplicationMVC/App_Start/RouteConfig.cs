using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplicationMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            // Esto es una ruta personalizada a Contacts
            // Las opciones podrían ser All contacts general o All contacts por grupo
            // Type define si es general o por grupo
            routes.MapRoute(
                name: "MyGroupsRoute",
                url: "{controller}/{action}/{type}/{id}",
                defaults: new { controller = "Contacts", action = "Index", type = UrlParameter.Optional, id = UrlParameter.Optional }
            );
        }
    }
}

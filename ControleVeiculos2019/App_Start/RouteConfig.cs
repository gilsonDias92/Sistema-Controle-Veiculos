using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControleVeiculos2019
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //it goes from the most especific to the more generic one
            routes.MapRoute("CarsByYear",
                "cars/carsbyyear/{year}",
                new { controller = "Cars", action = "CarsByYear" },
                new { year = @"\d{4}"}); // it must have 4 digits


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

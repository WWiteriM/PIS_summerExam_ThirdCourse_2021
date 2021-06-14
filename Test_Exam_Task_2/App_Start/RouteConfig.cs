using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Test_Exam_Task_2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Fit",
                url: "{controller}/{action}",
                defaults: new { controller = "Fit", action = "Index" }
            );

            routes.MapMvcAttributeRoutes();
        }
    }
}

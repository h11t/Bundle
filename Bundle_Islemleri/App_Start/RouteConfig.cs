using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Bundle_Islemleri
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name:"UrlRewrite",
                url:"anasayfa",
                defaults: new {controller="Home", action="Index"}
                );
            routes.MapRoute(
               name: "UrlRewrite2",
               url: "kisi-bilgileri",
               defaults: new { controller = "User", action = "Detail" }
               );
            routes.MapRoute(
                name:"FormatliUrl",
                url:"{haberAdi}--{id}-haberi",
                defaults:new {controller="Haber", action="Detay", id="{id}", haberAdi= "{haberAdi}" }
                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

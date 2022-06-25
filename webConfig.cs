using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramClone
{
    public static class webConfig
    {
        public static void Register(Http.HttpConfiguration config)
        {
            // for Attribute roiting
            config.MapHttpAttributeRoutes();

            //  conventon based routing
            config.Routes.MapHttpRoute(
            name: "InstagramConeApi",
            routeTemplate: "api/{controller}/{action}/{id}",
            defaults: new { id = RouteParameter.Optional }
                );
        }
    }
}
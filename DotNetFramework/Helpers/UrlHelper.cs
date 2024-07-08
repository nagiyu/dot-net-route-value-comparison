using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DotNetFramework.Helpers
{
    public static class UrlHelper
    {
        public static string GenerateUrl(RequestContext context)
        {
            // RouteValueDictionaryの使用例
            var routeValues = new RouteValueDictionary(new
            {
                controller = "Home",
                action = "Index",
                id = 123
            });

            // GetVirtualPathForAreaの使用例
            VirtualPathData vpd = RouteTable.Routes.GetVirtualPathForArea(context, routeValues);

            return vpd?.VirtualPath ?? "No path found";
        }
    }
}
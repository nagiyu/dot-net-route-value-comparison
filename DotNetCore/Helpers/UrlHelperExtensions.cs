using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace DotNetCore.Helpers
{
    public static class UrlHelperExtensions
    {
        public static string GenerateUrlForArea(this IUrlHelper urlHelper)
        {
            var values = new RouteValueDictionary(new { id = 123 })
            {
                { "controller", "Home" },
                { "action", "Index" }
            };

            return urlHelper.Action("Index", "Home", values);
        }
    }
}
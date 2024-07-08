using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DotNetFramework.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id)
        {
            ViewBag.Message = $"Admin Area Home Controller - Index Action, ID: {id}";
            return View();
        }

        public ActionResult GenerateUrl()
        {
            string url = Helpers.UrlHelper.GenerateUrl(Request.RequestContext);

            ViewBag.Url = url;
            return View();
        }
    }
}
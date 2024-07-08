using DotNetCore.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            ViewBag.Message = $"Admin Area Home Controller - Index Action, ID: {id}";
            return View();
        }

        public IActionResult GenerateUrl()
        {
            string url = Url.GenerateUrlForArea();

            ViewBag.Url = url;
            return View();
        }
    }
}

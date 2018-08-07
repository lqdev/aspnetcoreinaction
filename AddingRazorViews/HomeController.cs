using Microsoft.AspNetCore.Mvc;

namespace AddingRazorViews
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
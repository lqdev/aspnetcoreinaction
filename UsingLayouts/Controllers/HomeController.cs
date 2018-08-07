using Microsoft.AspNetCore.Mvc;

namespace UsingLayouts.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
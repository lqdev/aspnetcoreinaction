using Microsoft.AspNetCore.Mvc;
using CurrencyConverterTagHelpers.Models;

namespace CurrencyConverterTagHelpers.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View(new UserBindingModel());
        }

        [HttpPost]
        public IActionResult Index(UserBindingModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToRoute("default",new {Controller="Home"});
        }
    }
}
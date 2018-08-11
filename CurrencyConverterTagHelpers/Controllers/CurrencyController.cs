using Microsoft.AspNetCore.Mvc;
using CurrencyConverterTagHelpers.Models;

namespace CurrencyConterterTagHelpers.Controllers
{
    public class CurrencyController: Controller
    {
        public IActionResult Convert()
        {
            return View(new CurrencyConverterModel());
        }

        [HttpPost]
        public IActionResult Convert(CurrencyConverterModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index","Home");
        }
    }
}
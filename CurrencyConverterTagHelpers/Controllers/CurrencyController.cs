using Microsoft.AspNetCore.Mvc;
using CurrencyConverterTagHelpers.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace CurrencyConverterTagHelpers.Controllers
{
    public class CurrencyController : Controller
    {
        public IActionResult Convert()
        {
            
            return View(new CurrencyConverterModel());
        }
    }
}
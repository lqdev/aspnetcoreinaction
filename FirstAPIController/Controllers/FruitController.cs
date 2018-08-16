using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstAPIController.Controllers
{
    [Route("api/[controller]")]
    public class FruitController : Controller
    {
        List<string> _fruits = new List<string> {
            "Pear",
            "Lemon",
            "Peach"
        };

        [Route("/")]
        public IEnumerable<string> Index()
        {
            return _fruits;
        }

        [Route("/{id}")]
        public IActionResult View(int id)
        {
            if(id >= 0 && id < _fruits.Count)
            {
                return Ok(_fruits[id]);
            }

            return NotFound();
        }
    }
}
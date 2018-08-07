using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PassingData.ViewModels;

namespace PassingData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult ViewTodo(int id)
        {
            ViewData["Message"] = "Tasks for today";

            var viewModel = new TodoViewModel
            {
                Tasks = new List<string> {
                    "Get fuel",
                    "Check oil",
                    "Check tire pressure"
                },
                IsComplete = false
            };

            return View(viewModel);
        }
    }
}
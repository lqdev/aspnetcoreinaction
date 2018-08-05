using Microsoft.AspNetCore.Mvc;

namespace AddingMVCToEmptyProject
{
    public class HomeController : Controller    
    {
        public string Index()
        {
            return "Hello World!";
        }
    }
}
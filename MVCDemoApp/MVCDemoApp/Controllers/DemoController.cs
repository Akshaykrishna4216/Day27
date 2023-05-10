using Microsoft.AspNetCore.Mvc;

namespace MVCDemoApp.Controllers
{
   
    
    public class DemoController : Controller
    {
        public string Display()
        {
            return "MVC Core";
        }
            public IActionResult Index()
        {
            return View();
        }
    }
}

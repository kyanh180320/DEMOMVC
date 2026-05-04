using Microsoft.AspNetCore.Mvc;

namespace DEMO.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

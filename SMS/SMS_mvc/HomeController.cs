using Microsoft.AspNetCore.Mvc;

namespace SMS_mvc
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

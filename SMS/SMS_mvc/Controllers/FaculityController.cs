using Microsoft.AspNetCore.Mvc;

namespace SMS_mvc.Controllers
{
    public class FaculityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

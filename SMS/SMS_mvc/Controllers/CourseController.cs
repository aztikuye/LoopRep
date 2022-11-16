using Microsoft.AspNetCore.Mvc;

namespace SMS_mvc.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

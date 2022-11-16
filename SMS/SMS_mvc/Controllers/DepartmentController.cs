using Microsoft.AspNetCore.Mvc;

namespace SMS_mvc.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

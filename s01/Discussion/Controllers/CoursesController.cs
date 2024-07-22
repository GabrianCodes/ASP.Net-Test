using Microsoft.AspNetCore.Mvc;

namespace Discussion.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View(); // this one will render the page
        }
        public IActionResult CreateCourse()
        {
            return View();
        }

    }
}

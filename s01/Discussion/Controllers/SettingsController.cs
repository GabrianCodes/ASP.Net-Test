using Microsoft.AspNetCore.Mvc;

namespace Discussion.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

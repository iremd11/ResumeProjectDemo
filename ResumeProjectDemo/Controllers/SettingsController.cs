using Microsoft.AspNetCore.Mvc;

namespace ResumeProjectDemo.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

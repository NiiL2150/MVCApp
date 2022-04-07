using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Areas.Admin.Controllers
{
    public class SettingsController : Controller
    {
        /*
        public IActionResult Index()
        {
            return View();
        }
        */
        public string Index()
        {
            return "Admin";
        }
    }
}

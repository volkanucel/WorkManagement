using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

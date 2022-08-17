using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

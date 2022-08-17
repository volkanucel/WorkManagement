using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class TrainingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class WorkOrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

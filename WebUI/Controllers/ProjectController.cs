using BusinessLayer.Conrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ProjectController : Controller
    {
        ProjectManager pm = new ProjectManager(new EfProjectDal());
        public IActionResult Index()
        {
            ProjectModel projectModel = new ProjectModel()
            {
                Projects = pm.GetAll()
            };

            return View(projectModel);
        }
        [HttpGet]
        public IActionResult AddProject()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProject(int id)
        {
            return View();
        }
        [HttpGet]
        public IActionResult EditProject()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EditProject(int id)
        {
            return View();
        }

        public IActionResult DeleteProject()
        {
            return View();
        }
    }
}

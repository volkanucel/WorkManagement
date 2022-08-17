using BusinessLayer.Conrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class EquipmentController : Controller
    {
        EquipmentManager em = new EquipmentManager(new EfEquipmentDal());
        public IActionResult Index()
        {
            EquipmentModel equipmentModel = new EquipmentModel()
            {
                Equipments = em.GetAll(),
                
            };

            return View(equipmentModel);
        }

        [HttpGet]
        public IActionResult AddEquipment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEquipment(Equipment equipment)
        {
            equipment.ProductionDate= DateTime.Now;
            equipment.WarrantyExpireDate= DateTime.Now;
            equipment.Status = true;
            em.Add(equipment);
            return RedirectToAction("Index","Equipment");
        }
        [HttpGet]
        public IActionResult EditEquipment(int id)
        {
            Equipment equipment = em.GetById(id);
            
            return View(equipment);
        }
        [HttpPost]
        public IActionResult EditEquipment(Equipment equipment)
        {
            em.Update(equipment);
            return RedirectToAction("Index", "Equipment");
        }
        public IActionResult DeleteEquipment(int id)
        {
            Equipment equipment = em.GetById(id);
            em.Delete(equipment);
            return RedirectToAction("Index", "Equipment");
        }
    }
}

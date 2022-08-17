using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Conrete
{
    public class MaintenanceManager : IMaintenanceService
    {
        private IMaintenanceDal _maintenanceDal;

        public MaintenanceManager(IMaintenanceDal maintenanceDal)
        {
            _maintenanceDal = maintenanceDal;
        }

        public void Add(Maintenance entity)
        {
            _maintenanceDal.Add(entity);
        }

        public void Delete(Maintenance entity)
        {
            _maintenanceDal.Delete(entity);
        }

        public List<Maintenance> GetAll()
        {
            return _maintenanceDal.GetAll();
        }

        public Maintenance GetById(int id)
        {
            return _maintenanceDal.GetById(id);
        }

        public void Update(Maintenance entity)
        {
            _maintenanceDal.Update(entity);
        }
    }
}

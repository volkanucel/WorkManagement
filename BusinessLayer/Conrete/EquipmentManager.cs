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
    public class EquipmentManager : IEquipmentService
    {
        private IEquipmentDal _equipmentDal;

        public EquipmentManager(IEquipmentDal equipmentDal)
        {
            _equipmentDal = equipmentDal;
        }

        public void Add(Equipment entity)
        {
            _equipmentDal.Add(entity);
        }

        public void Delete(Equipment entity)
        {
            _equipmentDal.Delete(entity);
        }

        public List<Equipment> GetAll()
        {
            return _equipmentDal.GetAll();
        }

        public Equipment GetById(int id)
        {
            return _equipmentDal.GetById(id);
        }

        public void Update(Equipment entity)
        {
            _equipmentDal.Update(entity);
        }
    }
}

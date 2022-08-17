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
    public class EquipmentTypeManager : IEquipmentTypeService
    {
        private IEquipmentTypeDal _equipmentTypeDal;

        public EquipmentTypeManager(IEquipmentTypeDal equipmentTypeDal)
        {
            _equipmentTypeDal = equipmentTypeDal;
        }

        public void Add(EquipmentType entity)
        {
            _equipmentTypeDal.Add(entity);
        }

        public void Delete(EquipmentType entity)
        {
            _equipmentTypeDal.Delete(entity);
        }

        public List<EquipmentType> GetAll()
        {
            return _equipmentTypeDal.GetAll();
        }

        public EquipmentType GetById(int id)
        {
            return _equipmentTypeDal.GetById(id);
        }

        public void Update(EquipmentType entity)
        {
            _equipmentTypeDal.Update(entity);
        }
    }
}

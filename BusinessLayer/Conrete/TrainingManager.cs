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
    public class TrainingManager : ITrainingService
    {
        private ITrainingDal _rainingDal;

        public TrainingManager(ITrainingDal rainingDal)
        {
            _rainingDal = rainingDal;
        }

        public void Add(Training entity)
        {
            _rainingDal.Add(entity);
        }

        public void Delete(Training entity)
        {
            _rainingDal.Delete(entity);
        }

        public List<Training> GetAll()
        {
            return _rainingDal.GetAll();    
        }

        public Training GetById(int id)
        {
            return _rainingDal.GetById(id);
        }

        public void Update(Training entity)
        {
            _rainingDal.Update(entity);
        }
    }
}

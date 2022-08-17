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
    public class LocationManager : ILocationService
    {
        private ILocationDal _locationDal;

        public LocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public void Add(Location entity)
        {
            _locationDal.Add(entity);
        }

        public void Delete(Location entity)
        {
            _locationDal.Delete(entity);
        }

        public List<Location> GetAll()
        {
            return _locationDal.GetAll();
        }

        public Location GetById(int id)
        {
            return _locationDal.GetById(id);
        }

        public void Update(Location entity)
        {
            _locationDal.Update(entity);
        }
    }
}

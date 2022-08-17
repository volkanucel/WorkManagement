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
    public class GroupManager : IGroupService
    {
        private IGroupDal _groupDal;

        public GroupManager(IGroupDal groupDal)
        {
            _groupDal = groupDal;
        }

        public void Add(Group entity)
        {
            _groupDal.Add(entity);
        }

        public void Delete(Group entity)
        {
            _groupDal.Delete(entity);
        }

        public List<Group> GetAll()
        {
            return _groupDal.GetAll();
        }

        public Group GetById(int id)
        {
            return _groupDal.GetById(id);
        }

        public void Update(Group entity)
        {
            _groupDal.Update(entity);
        }
    }
}

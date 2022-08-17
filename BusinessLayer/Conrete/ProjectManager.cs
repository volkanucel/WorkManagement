using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Conrete
{
    public class ProjectManager : IProjectService
    {
        private  IProjectDal _projectDal;

        public ProjectManager(IProjectDal ProjectDal)
        {
            _projectDal = ProjectDal;
        }

        public void Add(Project project)
        {
           _projectDal.Add(project);
            
        }

        public void Delete(Project project)
        {
            _projectDal.Delete(project);
        }

        public List<Project> GetAll()
        {
            return _projectDal.GetAll();
        }

        public Project GetById(int id)
        {
            return _projectDal.GetById(id);
        }

        public void Update(Project project)
        {
            _projectDal.Update(project);
        }
    }
}

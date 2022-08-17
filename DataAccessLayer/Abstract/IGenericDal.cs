using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<TEntity> where TEntity : class
    {
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Add(TEntity entity);
        TEntity GetById(int id);
        List<TEntity> GetAll();
        
    }
}

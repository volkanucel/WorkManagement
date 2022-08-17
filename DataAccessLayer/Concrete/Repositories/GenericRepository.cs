using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<TEntity, TContext> : IGenericDal<TEntity>
        where TEntity : class, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using var c = new TContext();
            c.Add(entity);
            c.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using var c = new TContext();
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            using var c = new TContext();
            return c.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            using var c = new TContext();
            return c.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            using var c = new TContext();
            c.Update(entity);
            c.SaveChanges();
        }
    }
}

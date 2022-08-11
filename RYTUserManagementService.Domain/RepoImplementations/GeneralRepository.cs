using Microsoft.EntityFrameworkCore;
using RYTUserManagementService.Domain.RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RYTUserManagementService.Domain.RepoImplementations
{
    public class GenericRepository<T> : IGeneralRepository<T> where T : class
    {
        protected readonly UserManagementDbContext context;
        public GenericRepository(UserManagementDbContext context)
        {
            this.context = context;
        }
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            context.Set<T>().AddRange(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Where(expression);
        }
        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }
        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            context.Set<T>().RemoveRange(entities);
        }
    }


    //public class GeneralRepository<TEntity> where TEntity : class
    //{

    //        public UserManagementDbContext context;
    //        public DbSet<TEntity> dbSet;
    //        public GeneralRepository(UserManagementDbContext context)
    //        {
    //            this.context = context;
    //            this.dbSet = context.Set<TEntity>();
    //        }

    //        public virtual IEnumerable<TEntity> Get(
    //            Expression<Func<TEntity, bool>> filter = null,
    //            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
    //            string includeProperties = "")
    //        {
    //            IQueryable<TEntity> query = dbSet;
    //            if (filter != null)
    //            {
    //                query = query.Where(filter);
    //            }
    //            foreach (var includeProperty in includeProperties.Split
    //                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
    //            {
    //                query = query.Include(includeProperty);
    //            }
    //            if (orderBy != null)
    //            {
    //                return orderBy(query).ToList();
    //            }
    //            else
    //            {
    //                return query.ToList();
    //            }
    //        }
    //        public virtual TEntity GetByID(object id)
    //        {
    //            return dbSet.Find(id);
    //        }
    //        public virtual void Insert(TEntity entity)
    //        {
    //            dbSet.Add(entity);
    //        }
    //        public virtual void Delete(object id)
    //        {
    //            TEntity entityToDelete = dbSet.Find(id);
    //            Delete(entityToDelete);
    //        }
    //        public virtual void Delete(TEntity entityToDelete)
    //        {
    //            if (context.Entry(entityToDelete).State == EntityState.Detached)
    //            {
    //                dbSet.Attach(entityToDelete);
    //            }
    //            dbSet.Remove(entityToDelete);
    //        }
    //        public virtual void Update(TEntity entityToUpdate)
    //        {
    //            dbSet.Attach(entityToUpdate);
    //            context.Entry(entityToUpdate).State = EntityState.Modified;
    //        }

    //}
}


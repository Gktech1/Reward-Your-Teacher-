﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RYTUserManagementService.Domain.RepoInterfaces
{
    public interface IGeneralRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);



        //IEnumerable<TEntity> Get(
        //       Expression<Func<TEntity, bool>> filter = null,
        //       Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        //       string includeProperties = "");

        // TEntity GetByID(object id);
        // void Insert(TEntity entity);
        //void Delete(object id);
        //void Delete(TEntity entityToDelete);
        //void Update(TEntity entityToUpdate);
    }
}

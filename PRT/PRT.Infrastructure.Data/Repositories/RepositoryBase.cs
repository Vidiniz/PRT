using PRT.Domain.Interfaces;
using PRT.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PRT.Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected PRTContext DataBase = new PRTContext();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DataBase.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return DataBase.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            DataBase.Set<TEntity>().Remove(obj);
            DataBase.SaveChanges();
        }

        public void Save(TEntity obj)
        {
            DataBase.Set<TEntity>().Add(obj);
            DataBase.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            DataBase.Entry(obj).State = EntityState.Modified;
            DataBase.SaveChanges();
        }
    }
}

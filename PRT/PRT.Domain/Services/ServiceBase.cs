using PRT.Domain.Interfaces.Repositories;
using PRT.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace PRT.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _respository;

        public ServiceBase(IRepositoryBase<TEntity> respository)
        {
            _respository = respository;
        }

        public void Dispose()
        {
            _respository.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _respository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _respository.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _respository.Remove(obj);
        }

        public void Save(TEntity obj)
        {
            _respository.Save(obj);
        }

        public void Update(TEntity obj)
        {
            _respository.Update(obj);
        }
    }
}

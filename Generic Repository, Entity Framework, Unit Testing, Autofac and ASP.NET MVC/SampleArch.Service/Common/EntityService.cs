using SampleArch.Model;
using SampleArch.Repository;
using System;
using System.Collections.Generic;

namespace SampleArch.Service
{
    public abstract class EntityService<T> : IEntityService<T> where T : BaseEntity
    {
        private IGenericRepository<T> _repository;
        private IUnitOfWork _unitOfWork;

        protected EntityService(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public virtual void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _repository.Add(entity);
            _unitOfWork.Commit();
        }

        public virtual void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _repository.Delete(entity);
            _unitOfWork.Commit();
        }

        public virtual IEnumerable<T> GetAll() => _repository.GetAll();

        public virtual void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _repository.Edit(entity);
            _unitOfWork.Commit();
        }
    }
}
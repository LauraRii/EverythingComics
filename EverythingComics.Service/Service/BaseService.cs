using FluentValidation;
using EverythingComics.Domain.Base;
using EverythingComics.Repository.Repository;
using System;
using System.Collections.Generic;

namespace EverythingComics.Service.Base
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity<int>
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public TEntity Add<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>
        {
            Validate(obj, Activator.CreateInstance<TValidator>());
            _repository.Insert(obj);
            return obj;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IList<TEntity> Get()
        {
            return _repository.Select();
        }

        public TEntity GetById(int id)
        {
            return _repository.Select(id);
        }

        public TEntity Update<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>
        {
            Validate(obj, Activator.CreateInstance<TValidator>());
            _repository.Update(obj);
            return obj;
        }

        private void Validate(TEntity obj, AbstractValidator<TEntity> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
using FluentValidation;
using System.Collections.Generic;

namespace EverythingComics.Domain.Base
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity<int>
    {
        TEntity Add<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;
        TEntity Update<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;
        void Delete(int id);
        IList<TEntity> Get();
        TEntity GetById(int id);
    }
}
using EverythingComics.Domain.Base;

namespace EverythingComics.Repository.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity<int>
    {
        void AttachObject(object obj);
        void ClearChangeTracker();
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(object id);
        IList<TEntity> Select(IList<string>? includes = null);
        TEntity Select(object id, IList<string>? includes = null);
    }
}
namespace EverythingComics.Domain.Base
{
    public abstract class BaseEntity<T>
    {
        protected BaseEntity()
        {
        }
        protected BaseEntity(T id)
        {
            Id = id;
        }

        public virtual T Id { get; set; }
    }
}
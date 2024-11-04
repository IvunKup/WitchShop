namespace Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; protected set; }

        protected bool Equals(object? obj)
        {
            return true;
        }

    }
}

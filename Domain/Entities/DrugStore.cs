using Domain.ValueObjects;

namespace Domain.Entities
{
    public class DrugStore : BaseEntity
    {
        public int Number { get; set; }
        public Address Address { get; set; }
        public string DrugNetwork { get; set; }
    }
}
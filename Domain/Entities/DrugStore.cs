using Domain.Validations;
using Domain.ValueObjects;
using FluentValidation;

namespace Domain.Entities
{
    public class DrugStore : BaseEntity
    {
        public int Number { get; set; }
        public Address Address { get; set; }
        public string DrugNetwork { get; set; }

        public DrugStore(int number, string drugNetwork, Address address)
        {
            Number = number;
            DrugNetwork = drugNetwork;
            Address = address;
            var validator = new DrugStoreValidator(nameof(DrugStore));
            validator.ValidateAndThrow(this);
        }
    }
}
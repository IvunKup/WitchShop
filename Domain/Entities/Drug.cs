using Domain.Validations;
using FluentValidation;

namespace Domain.Entities
{
    public class Drug : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufactorer { get; set; }
        public string CountryCodeId { get; set; }
        public Country Country { get; set; }

        public Drug(string name, string description, string manufactorer, string countryCodeId)
        {
            Name = name;
            Description = description;
            Manufactorer = manufactorer;
            CountryCodeId = countryCodeId;
            var validator = new DrugValidator(nameof(Drug));
            validator.ValidateAndThrow(this);
        }
    }
}
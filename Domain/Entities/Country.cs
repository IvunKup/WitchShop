using Domain.Validations;
using FluentValidation;

namespace Domain.Entities
{
    public class Country
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public ICollection<Drug> Drugs { get; set; }

        public Country(string countryName, string countryCode)
        {
            CountryName = countryName;
            CountryCode = countryCode;
            var validator = new CountryValidator(nameof(Country));
            validator.ValidateAndThrow(this);
        }
    }
}
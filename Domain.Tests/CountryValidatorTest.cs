using Domain.Entities;
using Domain.Validations;
using FluentValidation;

namespace Domain.Tests;

public class CountryValidatorTest
{
    [Fact]
    public void ValidateCountry_ValidCountry_IsValid()
    {
        Country country = new Country("Мары", "MR");
        CountryValidator countryValidator = new CountryValidator(nameof(Country));
        countryValidator.ValidateAndThrow(country);
    }
}
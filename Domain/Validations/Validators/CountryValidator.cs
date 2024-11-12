using Domain.Entities;
using FluentValidation;

namespace Domain.Validations;

public class CountryValidator : AbstractValidator<Country>
{
    public CountryValidator(string paramName)
    {
        RuleFor(country => country.CountryName)
            .NotNullOrEmptyWithMessage(nameof(Country.CountryName))
            .Length(2, 100).WithMessage(ValidationMasages.InvalidLength(nameof(Country.CountryName)))
            .Matches(@"^[A-Za-z ]+$").WithMessage(ValidationMasages.InvalidSpelling(nameof(Country.CountryName)));
        RuleFor(country => country.CountryCode)
            .Matches(@"^[A-Z]{2}$").WithMessage(ValidationMasages.InvalidSpelling(nameof(Country.CountryCode)));
    }
}
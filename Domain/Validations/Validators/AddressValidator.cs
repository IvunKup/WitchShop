using Domain.ValueObjects;
using FluentValidation;

namespace Domain.Validations;

public class AddressValidator : AbstractValidator<Address>
{
    public AddressValidator(string paramName)
    {
        RuleFor(address => address.Street)
            .Length(3, 100).WithMessage(ValidationMasages.InvalidLength(nameof(Address.PostalCode)));
        RuleFor(address => address.City)
            .Length(3, 50).WithMessage(ValidationMasages.InvalidLength(nameof(Address.PostalCode)));
        RuleFor(address => address.PostalCode)
            .GreaterThan(9999).WithMessage(ValidationMasages.LessThenIntended(nameof(Address.PostalCode)))
            .LessThan(1000000).WithMessage(ValidationMasages.MoreThenIntended(nameof(Address.PostalCode)));
    }
}
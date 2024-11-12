using Domain.Validations;
using Domain.ValueObjects;
using FluentValidation;

namespace Domain.Tests;

public class AddressValidatorTest
{
    [Fact]
    public void ValidateAddress_ValidAddress_IsValid()
    {
        Address address = new Address("street", "city", "state", 99999);
        AddressValidator addressValidator = new AddressValidator(nameof(Address));
        addressValidator.ValidateAndThrow(address);
    }
}
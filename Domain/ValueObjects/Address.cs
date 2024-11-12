using Domain.Validations;
using FluentValidation;

namespace Domain.ValueObjects
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string House { get; set; }
        public int PostalCode { get; set; }

        public Address(string street, string city, string house, int postalCode)
        {
            Street = street;
            City = city;
            House = house;
            PostalCode = postalCode;
            var validator = new AddressValidator(nameof(Address));
            validator.ValidateAndThrow(this);
        }
    }
}
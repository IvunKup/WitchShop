using Domain.Entities;
using FluentValidation;

namespace Domain.Validations;

public class DrugValidator : AbstractValidator<Drug>
{
    
    public DrugValidator(string paramName)
    {
        RuleFor(drud => drud.Name)
            .NotNullOrEmptyWithMessage(nameof(Drug.Name))
            .Length(2, 150).WithMessage(ValidationMasages.InvalidLength(nameof(Drug.Name)));
        RuleFor(drud => drud.Manufactorer)
            .NotNullOrEmptyWithMessage(nameof(Drug.Manufactorer))
            .Length(2, 100).WithMessage(ValidationMasages.InvalidLength(nameof(Drug.Manufactorer)));
        RuleFor(drug => drug.CountryCodeId)
            .Matches(@"^[A-Z]{2}$").WithMessage(ValidationMasages.InvalidSpelling(nameof(Drug.CountryCodeId)));
    }
}
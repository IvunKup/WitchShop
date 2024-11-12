using Domain.Entities;
using FluentValidation;

namespace Domain.Validations;

public class DrugStoreValidator : AbstractValidator<DrugStore>
{
    public DrugStoreValidator(string paramName)
    {
        RuleFor(store => store.DrugNetwork)
            .NotNullOrEmptyWithMessage(nameof(DrugStore.DrugNetwork))
            .Length(2, 100).WithMessage(ValidationMasages.InvalidSpelling(nameof(DrugStore.DrugNetwork)));
        RuleFor(store => store.Number)
            .GreaterThanOrEqualTo(0).WithMessage(ValidationMasages.LessThenIntended(nameof(DrugStore.DrugNetwork)));
        RuleFor(store => store.Address)
            .NotNullOrEmptyWithMessage(nameof(DrugStore.Address))
            .SetValidator(new AddressValidator(nameof(DrugStore)));
    }
}
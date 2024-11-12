using Domain.Entities;
using FluentValidation;

namespace Domain.Validations;

public class DrugItemValidator : AbstractValidator<DrugItem>
{
    public DrugItemValidator(string paramName)
    {
        RuleFor(item => item.DrugPrice)
            .GreaterThan(0).WithMessage(ValidationMasages.LessThenIntended(nameof(DrugItem.DrugPrice)))
            .ScalePrecision(2, 18).WithMessage(ValidationMasages.InvalidSpelling(nameof(DrugItem.DrugPrice)));
        RuleFor(item => item.Quantity)
            .GreaterThanOrEqualTo(0).WithMessage(ValidationMasages.LessThenIntended(nameof(DrugItem.Quantity)))
            .LessThanOrEqualTo(10000).WithMessage(ValidationMasages.MoreThenIntended(nameof(DrugItem.Quantity)));
    }
}
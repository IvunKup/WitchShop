using Domain.DomainEvents;
using FluentValidation;

namespace Domain.Validations;

public class DrugItemUpdatedEventValidator : AbstractValidator<DrugItemUpdatedEvent>
{
    public DrugItemUpdatedEventValidator()
    {
        RuleFor(d => d.NewAmount)
            .NotNullOrEmptyWithMessage(nameof(DrugItemUpdatedEvent.NewAmount))
            .GreaterThanOrEqualTo(0).WithMessage(ValidationMasages.InvalidSpelling(nameof(DrugItemUpdatedEvent.NewAmount)))
            .LessThanOrEqualTo(10000).WithMessage(ValidationMasages.InvalidSpelling(nameof(DrugItemUpdatedEvent.NewAmount)));
    }
}
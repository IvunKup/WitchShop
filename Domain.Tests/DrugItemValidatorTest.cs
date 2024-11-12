using Domain.Entities;
using Domain.Validations;
using FluentValidation;

namespace Domain.Tests;

public class DrugItemValidatorTest
{
    [Fact]
    public void ValidateDrugItem_ValidDrugItem_IsValid()
    {
        DrugItem drugItem = new DrugItem(Guid.NewGuid(), Guid.NewGuid(), 5, 6);
        DrugItemValidator drugItemValidator = new DrugItemValidator(nameof(DrugItem));
        drugItemValidator.ValidateAndThrow(drugItem);
    }
}
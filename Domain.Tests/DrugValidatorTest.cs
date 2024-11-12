using Domain.Entities;
using Domain.Validations;
using FluentValidation;

namespace Domain.Tests;

public class DrugValidatorTest
{
    [Fact]
    public void ValidateDrug_ValidDrug_IsValid()
    {
        Drug drug = new Drug("УсоРост", "Повышает скорость роста волос", "Мары", "MR");
        DrugValidator drugValidator = new DrugValidator(nameof(Drug));
        drugValidator.ValidateAndThrow(drug);
    }
}
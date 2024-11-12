using Domain.Entities;
using Domain.Validations;
using Domain.ValueObjects;
using FluentValidation;

namespace Domain.Tests;

public class DrugStoreValidatorTest
{
    [Fact]
    public void ValidateDrugStore_ValidDrugStore_IsValid()
    {
        DrugStore drugStore = new DrugStore(150, "GurgenMed", new Address("ул. Розы Иосифовны", "Мары", "5", 99999));
        DrugStoreValidator drugStoreValidator = new DrugStoreValidator(nameof(DrugStore));
        drugStoreValidator.ValidateAndThrow(drugStore);
    }
}
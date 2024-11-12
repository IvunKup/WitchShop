using Domain.Validations;
using FluentValidation;

namespace Domain.Entities
{
    public class DrugItem : BaseEntity
    {
        public Guid DrugId { get; set; }
        public Guid DrugStoreId { get; set; }
        public decimal DrugPrice { get; set; }
        public int Quantity { get; set; }
        public Drug Drug { get; set; }
        public DrugStore DrugStore { get; set; }

        public DrugItem(Guid drugId, Guid drugStoreId, decimal drugPrice, int quantity)
        {
            DrugId = drugId;
            DrugStoreId = drugStoreId;
            DrugPrice = drugPrice;
            Quantity = quantity;
            var validator = new DrugItemValidator(nameof(DrugItem));
            validator.ValidateAndThrow(this);
        }
    }
}
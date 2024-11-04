namespace Domain.Entities
{
    public class DrugItem : BaseEntity
    {
        public Guid DrugId { get; set; }
        public Guid DrugStoreId { get; set; }
        public decimal DrugPrice { get; set; }
        public Drug Drug { get; set; }
        public DrugStore DrugStore { get; set; }
    }
}
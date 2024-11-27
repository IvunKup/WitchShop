namespace Domain.Entities;

public class FavoriteDrug : BaseEntity
{
    public Guid ProfileId { get; set; }
    
    public Guid UserId { get; set; }
    
    public Profile Profile { get; set; }
    
    public Guid DrugStoreId { get; set; }
    
    public DrugStore DrugStore { get; set; }
}
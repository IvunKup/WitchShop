using Domain.ValueObjects;

namespace Domain.Entities;

public class Profile : BaseEntity
{
    public string ExternalId { get; set; }
    
    public List<FavoriteDrug> FavoriteDrugs { get; set; }
    
    public Email Email { get; set; }
    
    public Profile(
        string externalId,
        Email email)
    {
        ExternalId = externalId;
        Email = email;
        
        //Validate();
    }
}
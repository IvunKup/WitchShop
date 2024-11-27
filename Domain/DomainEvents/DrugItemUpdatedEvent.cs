using Domain.Interfases;

namespace Domain.DomainEvents;

public class DrugItemUpdatedEvent : IDomainEvent
{
    public Guid DrugItemId { get; }
    
    public double NewAmount { get; }

    public DrugItemUpdatedEvent(Guid drugItemId, double newAmount)
    {
        DrugItemId = drugItemId;
        NewAmount = newAmount;
    }
}
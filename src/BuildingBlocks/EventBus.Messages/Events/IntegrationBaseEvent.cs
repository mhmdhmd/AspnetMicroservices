namespace EventBus.Messages.Events
{
    public class IntegrationBaseEvent
    {
        //add parameterless constructor
        public IntegrationBaseEvent()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }

        //add constructor with parameters
        public IntegrationBaseEvent(Guid id, DateTime creationDate)
        {
            Id = id;
            CreationDate = creationDate;
        }
        public Guid Id { get; private set; }
        public DateTime CreationDate { get; private set; }
    }
}

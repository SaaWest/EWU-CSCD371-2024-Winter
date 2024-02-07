namespace Logger;

public abstract class BaseEntity : IEntity
{
    public Guid ID { get; init; }
    public abstract string Name { get; set; }
}

namespace Logger;
public interface IEntity
{
    Guid ID { init; }
    string Name { get; }
}

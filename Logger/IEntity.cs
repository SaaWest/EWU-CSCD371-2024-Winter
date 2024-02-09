namespace Logger;
public interface IEntity
{
    //Both are implemented implicitly because we don't want the programmer to have to deal with implementation, unless it's an override
    Guid ID { init; }
    string Name { get; }
}

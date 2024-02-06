namespace Logger;
public interface IEntity
{
    Guid ID { set; }
    string Name { set; get; }
}

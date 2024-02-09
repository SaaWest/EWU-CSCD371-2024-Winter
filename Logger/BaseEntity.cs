

namespace Logger;

public abstract record class BaseEntity : IEntity
{
    // Both Name and ID are implicit as BaseEntity 'is a' relationship with IEntity. It would not hurt to make ID explicit but by convention of the relationship implicit is chosen but because name
    // presumably used in multiple record classes name is chosen as an abstract implicit. 
    public abstract string Name { get; }
    public Guid ID { init => throw new NotImplementedException(); }
}

namespace Logger;

public record StudentRecord : IEntity
{
    //implicit declaration because a student should have access to their name and student id
    public StudentRecord(string firstName, string lastName, string? middleName = null)
    {
        FirstName = string.IsNullOrEmpty(firstName) ? throw new ArgumentNullException(nameof(firstName)) : firstName;
        LastName = string.IsNullOrEmpty(lastName) ? throw new ArgumentNullException(nameof(lastName)) : lastName;
        MiddleName = middleName;

    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? MiddleName { get; set; }
    public string writeName { get { return FirstName + $"{(MiddleName != null ? " " + MiddleName + " " : " ")}" + LastName; } }
    public Guid ID { init => throw new NotImplementedException(); }
    public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

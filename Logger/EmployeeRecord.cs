namespace Logger;

public record EmployeeRecord : BaseEntity
{
    //implicit declaration because this is an 'is a' relationship and there is no conflict with the implementation
    public EmployeeRecord(string firstName, string lastName, string? middleName = null )
    {
        FirstName = string.IsNullOrEmpty(firstName) ? throw new ArgumentNullException(nameof(firstName)) : firstName;
        LastName = string.IsNullOrEmpty(lastName) ? throw new ArgumentNullException(nameof(lastName)) : lastName;
        MiddleName = middleName;

    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? MiddleName { get; set; }
    public override string Name { get { return FirstName + $"{(MiddleName != null ? " " + MiddleName + " " : " ")}" + LastName; } }
}

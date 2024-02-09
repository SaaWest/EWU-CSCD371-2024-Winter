namespace Logger;


public record  class FullName
{
    //Fullname encompasses three parts usually a first, middle and last name a constructor with 
    //these three/two requirements is what is need when instantiate a new person
    //Records are immutable and so FullName should reflect that as first, middle, and last names do
    //not change in real life unless some legal entity supercedes that.
    //FullName is a reference type since the object itself is refering to the data its pointing to
    public FullName(string firstName, string lastName, string? middleName = null)
    {
        FirstName = string.IsNullOrEmpty(firstName) ? throw new ArgumentNullException(nameof(firstName)) : firstName;
        LastName = string.IsNullOrEmpty(lastName) ? throw new ArgumentNullException(nameof(lastName)) : lastName;
        MiddleName = middleName;
    }

    public string FirstName { get; }
    public string LastName { get; }
    public string? MiddleName { get; }

    public string Name { get { return FirstName + $"{(MiddleName != null ? " " + MiddleName + " " : " ")}" + LastName; } }

}
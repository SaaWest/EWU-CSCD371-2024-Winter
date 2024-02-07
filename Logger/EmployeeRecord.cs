using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record EmployeeRecord : IEntity
{
    //implicit declaration because employees should have access to their name and employee id (GUID)
    public EmployeeRecord(string firstName, string lastName, string? middleName = null )
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

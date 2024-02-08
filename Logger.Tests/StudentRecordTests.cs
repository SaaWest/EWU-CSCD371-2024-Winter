using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Logger.Tests;
public class StudentRecordTests
    {
    [Fact]
    public void StudentRecord_Name_NotNull()
    {
        var student = new StudentRecord("Mike", "Soft", "Rowe");
        Assert.Equal("Mike Rowe Soft", student.writeName);

    }
    [Fact]
    public void EmployeeRecord_MiddleName_Null()
    {
        var student = new StudentRecord("Mike", "Soft", null!);
        Assert.Null(student.MiddleName);
        Assert.Equal("Mike Soft", student.writeName);

    }
    [Fact]
    public void FullName_FirstName_IsNull()
    {
        string firstName = "Steven";
        Assert.Throws<ArgumentNullException>(() => new EmployeeRecord(firstName, null!));


    }
    [Fact]
    public void FullName_LastName_IsNull()
    {
        string lastName = "Smith";
        Assert.Throws<ArgumentNullException>(() => new EmployeeRecord(null!, lastName));

    }
}


//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Logger.Tests;

public class EmployeeRecordTests
{
    [Fact]
    public void EmployeeRecord_Name_NotNull()
    {
        var employee = new EmployeeRecord("Mike", "Soft", "Rowe");
        Assert.Equal("Mike Rowe Soft", employee.writeName);
       
    }
    [Fact]
    public void EmployeeRecord_MiddleName_Null()
    {
        var employee = new EmployeeRecord("Mike", "Soft", null!);
        Assert.Null(employee.MiddleName);
        Assert.Equal("Mike Soft", employee.writeName);

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


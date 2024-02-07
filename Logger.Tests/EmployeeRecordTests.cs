using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

public class EmployeeRecordTests
{
    [TestMethod]
    [DataRow("John")]
    public void EmployeeRecord_Name_NotNull(string name)
    {
        EmployeeRecord record = new()
        {
            Name = name
        };
        Assert.IsNotNull(record.Name);
    }

}


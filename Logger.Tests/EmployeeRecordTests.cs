using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


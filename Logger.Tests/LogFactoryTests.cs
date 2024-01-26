using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests;

[TestClass]
public class LogFactoryTests
{
    [TestMethod]
    [DataRow("file", "class")]
    public void TryCreateNewFileLogger_NotNull_Success(string fileName, string className)
    {
        LogFactory logFactory = new();
        FileLogger? fileLog = (FileLogger?)logFactory.CreateLogger(className);
        Assert.IsNotNull(fileLog);
    }

    [TestMethod]
    [DataRow("file", null)]
    public void TryCreateNewLogger_NoClass_Fail(string fileName, string className)
    {
        LogFactory logFactory = new();
        FileLogger? fileLog = (FileLogger?)logFactory.CreateLogger(className);
        Assert.IsNull(fileLog);
    }

    [TestMethod]
    public void ConfigureFileLogger_LogFactory(string fileName)
    {
        
    }

}


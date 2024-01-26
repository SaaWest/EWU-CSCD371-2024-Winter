using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class LogFactoryTests
{
    [TestMethod]
    [DataRow("file", null)]
    public void TryCreateNewLogger_NoClass_Fail(string fileName, string className)
    {
        LogFactory logFactory = new();
        FileLogger? fileLog = (FileLogger?)logFactory.CreateLogger(className);
        Assert.IsNull(fileLog);
    }

    [TestMethod]
    [DataRow("file")]
    public void ConfigureFileLogger_LogFactory(string fileName)
    {
        LogFactory factory = new();
        factory.ConfigureFileLogger(fileName);
        Assert.IsNotNull(factory);
    }
}


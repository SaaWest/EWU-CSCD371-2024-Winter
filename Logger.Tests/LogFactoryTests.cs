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
        FileLogger? fileLog = logFactory.CreateLogger(fileName, className);
        Assert.IsNotNull(fileLog);
    }

    [TestMethod]
    [DataRow("file")]
    public void TryCreateNewLogger_NoClass_Fail(string fileName, string className)
    {
        LogFactory logFactory = new();
        FileLogger? fileLog = logFactory.CreateLogger(fileName, className);
        //Assert.Fail(fileLog.ClassName != null);
    }

    [TestMethod]
    public void ConfigureFileLogger_LogFactory(string fileName)
    {
        
    }

}


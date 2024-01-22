using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    [TestMethod]
    [InLineData()]
    public void Log_FileLogger(LogLevel logLevel, string message, string path)
    {

    }
    
}

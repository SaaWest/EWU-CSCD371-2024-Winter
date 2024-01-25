using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    [TestMethod]
    //[DataRow(,)]
    public void Log_FileLogger(/*LogLevel logLevel, string message, string path*/)
    {
        var logger = new TestLogger();
        
        string message = "Hello";

        logger.Log(LogLevel.Warning, message);



        //return;
    }

}


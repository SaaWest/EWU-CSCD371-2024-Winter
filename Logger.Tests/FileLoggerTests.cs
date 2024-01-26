using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    public string? FilePath { get; set; }
    public FileLogger? Logger { get; set; }
    [TestInitialize]
    //[DataRow(,)]
    public virtual void Log_FileLogger(/*LogLevel logLevel, string message, string path*/)
    {
        FilePath = Path.GetTempFileName();
        Logger = new FileLogger(nameof(FileLoggerTests), FilePath);
        
        var logger = new TestLogger();
        
        string message = "Hello";

        logger.Log(LogLevel.Warning, message);



        //return;
    }

}


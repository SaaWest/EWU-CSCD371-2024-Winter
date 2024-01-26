using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
namespace Logger.Tests;
    public class FileLoggerTestsBase
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public string FilePath { get; set; }

    public FileLogger Logger { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    [TestInitialize]
    public virtual void Log_FileLogger()
    {
        FilePath = Path.GetTempFileName();
        Logger = new FileLogger(nameof(FileLoggerTestsBase), FilePath);
     }
    [TestCleanup]
    public virtual void FileLoggerCleanup()
    {
        if (File.Exists(FilePath))
        {
        File.Delete(FilePath);
        }
    }
}
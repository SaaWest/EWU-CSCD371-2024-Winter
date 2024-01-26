using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests :FileLoggerTestsBase
{
    [TestMethod]
    public virtual void Create_ClassName_FileName_Success()
    {
        Assert.AreEqual(nameof(FileLoggerTestsBase), Logger.ClassName);
        Assert.AreEqual(FilePath, Logger.FilePath);
    }
    [TestMethod]
    public void Create_ClassName_FileName_Failure()
    {
        Assert.AreNotEqual(nameof(File), Logger.ClassName);
        Assert.AreNotEqual("FilePath", Logger.FilePath);
        
    }

}


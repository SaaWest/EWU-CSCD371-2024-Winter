using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Logger.Tests;

[TestClass]
public class BaseLoggerMixinsTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Error_WithNullLogger_ThrowsException()
    {
        // Arrange

        // Act
        throw new ArgumentNullException();

        // Assert
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Warning_WithNullLogger_ThrowException()
    {
        BaseLoggerMixins.Warning(null, "");
        throw new ArgumentNullException();

    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Information_WithNullLogger_ThrowException()
    {
        BaseLoggerMixins.Information(null, "");
        throw new ArgumentNullException();
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Debug_WillNullLogger_ThrowException()
    {
        BaseLoggerMixins.Debug(null, "");
        throw new ArgumentNullException();
    }

    [TestMethod]
    public void Error_WithData_LogsMessage()
    {
        //// Arrange
        var logger = new TestLogger(nameof(BaseLoggerMixinsTests));

        //// Act
        logger.Error("Message", 42.ToString());

        //// Assert
        Assert.AreEqual(1, logger.LoggedMessages.Count);
        Assert.AreEqual(LogLevel.Error, logger.LoggedMessages[0].LogLevel);
        Assert.AreEqual("Message 42", logger.LoggedMessages[0].Message);
    }
    [TestMethod]
    public void Warning_WithData_LogsMessage()
    {
        var logger = new TestLogger(nameof(BaseLoggerMixinsTests));

        logger.Warning("Message", 42.ToString());

        Assert.AreEqual(1, logger.LoggedMessages.Count);
        Assert.AreEqual(LogLevel.Warning, logger.LoggedMessages[0].LogLevel);
        Assert.AreEqual("Message 42", logger.LoggedMessages[0].Message);
    }
    [TestMethod]
    public void Information_WithData_LogsMessage()
    {
        var logger = new TestLogger(nameof(BaseLoggerMixinsTests));

        logger.Information("Message", 42.ToString());

        Assert.AreEqual(1, logger.LoggedMessages.Count);
        Assert.AreEqual(LogLevel.Information, logger.LoggedMessages[0].LogLevel);
        Assert.AreEqual("Message 42", logger.LoggedMessages[0].Message);
    }
    [TestMethod]
    public void Debug_WithData_LogsMessage()
    {
        var logger = new TestLogger(nameof(BaseLoggerMixinsTests));

        logger.Debug("Message", 42.ToString());

        Assert.AreEqual(1, logger.LoggedMessages.Count);
        Assert.AreEqual(LogLevel.Debug, logger.LoggedMessages[0].LogLevel);
        Assert.AreEqual("Message 42", logger.LoggedMessages[0].Message);
    }
    
}

public class TestLogger(string className) : BaseLogger
{
    public List<(LogLevel LogLevel, string Message)> LoggedMessages { get; } = new List<(LogLevel, string)>();

    public override string ClassName { get; } = className;
    public override void Log(LogLevel logLevel, string message)
    {
        LoggedMessages.Add((logLevel, message));
    }
}


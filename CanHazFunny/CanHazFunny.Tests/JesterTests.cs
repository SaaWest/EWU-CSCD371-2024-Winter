using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using Moq;
using Assert = NUnit.Framework.Assert;
using System.IO;
using System.Diagnostics.CodeAnalysis;

namespace CanHazFunny.Tests;
[TestClass]
public class JesterTests
{
    [Test]
    public void Constructor_JokerService_Null()
    {
        Assert.Throws<ArgumentNullException>(() => new Jester(null!, new OutputJoke()));

    }

    [Test]
    public void Constructor_TellJoke_Null()
    {
        Assert.Throws<ArgumentNullException>(() => new Jester(new JokeService(), null!));
    }

    [Test]
    public void SetIJokerJokes_Success()
    {
        // Arrange
        Jester jester = new(new JokeService(), new OutputJoke());
        Mock<IJokerJokes> jokerJokesMock = new();

        // Act
        jester.IJoker = jokerJokesMock.Object;

        // Assert
        Assert.That(jokerJokesMock.Object == jester.IJoker);
    }

    [Test]
    public void SetIJokeOutput_Success()
    {
        // Arrange
        Jester jester = new(new JokeService(), new OutputJoke());
        Mock<IJokeOutput> jokeOutputMock = new();

        // Act
        jester.IJokeOutput = jokeOutputMock.Object;

        // Assert
        Assert.That(jokeOutputMock.Object == jester.IJokeOutput);
    }

    [Test]
    public void TellJoke_JokeOutput()
    {
        Mock<IJokerJokes> jokeService = new();
        jokeService.Setup(s => s.GetJoke()).Returns("This is a joke");
        Mock<IJokeOutput> outPut = new();

        Jester jester = new(jokeService.Object, outPut.Object);
        jester.TellJoke();

        jokeService.Verify(s => s.GetJoke(), Times.Once);

        outPut.Verify(s => s.Output("This is a joke"), Times.Once);
    }

    [Test]
    public void TellTenJokes_NoChuckNorris_Success()
    {
        Mock<IJokerJokes> jokeService = new();
        jokeService.SetupSequence(s => s.GetJoke())
                .Returns("Chuck Norris")
                .Returns("Still Chuck Norris")
                .Returns("This is a joke");

        Mock<IJokeOutput> outPut = new();
        Jester jester = new(jokeService.Object, outPut.Object);
        using StringWriter stringWriter = new();
        Console.SetOut(stringWriter);
        jester.TellJoke();
        //First joke TellJoke() will see is "Chuck Norris", so your TellJoke() method will call GetJoke() again
        //The next joke GetJoke() Returns still contains Chuck so that while loop in TellJoke() will call GetJoke() again
        //The last joke GetJoke() will return is good, so TellJoke() will exit that while loop
        string consoleOutput = stringWriter.ToString();
        Assert.That(!consoleOutput.Contains("Chuck Norris"));
    }
}

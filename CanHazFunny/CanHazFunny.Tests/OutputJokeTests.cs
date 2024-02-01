using System;
using Assert = NUnit.Framework.Assert;
using System.IO;
using NUnit.Framework;

namespace CanHazFunny.Tests;
public class OutputJokeTests
{
    [Test]
    public void OutputJoke_toConsole()
    {
        OutputJoke outputJoke = new();
        string aJoke = "This is a joke";
        using StringWriter stringWriter = new();
        Console.SetOut(stringWriter);
        outputJoke.Output(aJoke);
        string writeJoke = stringWriter.ToString();
        Assert.That(aJoke + Environment.NewLine == writeJoke);
    }
}

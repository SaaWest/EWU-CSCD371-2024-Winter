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
        OutputJoke outputJoke = new OutputJoke();
        string aJoke = "This is a joke";
        using var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        outputJoke.Output(aJoke);
        var writeJoke = stringWriter.ToString();
        Assert.That(aJoke + Environment.NewLine == writeJoke);
    }
}

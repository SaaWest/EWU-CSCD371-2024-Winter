using System;
using Assert = NUnit.Framework.Assert;
using System.IO;
using NUnit.Framework;

namespace CanHazFunny.Tests;
    internal class OutputJokeTests
    {
        [Test]
        public void OutputJoke_toConsole() 
        {
            var outputJoke = new OutputJoke();
            var aJoke = "This is a joke";
        using var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        outputJoke.Output(aJoke);
        var writeJoke = stringWriter.ToString();
        Assert.That(aJoke + Environment.NewLine == writeJoke);

    }
}

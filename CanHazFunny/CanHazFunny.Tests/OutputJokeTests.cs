using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;
using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using Assert = NUnit.Framework.Assert;
using System.IO;

namespace CanHazFunny.Tests
{
    internal class OutputJokeTests
    {
        [Fact]
        public void OutputJoke_toConsole() 
        {
            var outputJoke = new OutputJoke();
            var aJoke = "This is a joke";
            using( var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                outputJoke.Output(aJoke);
                var writeJoke = stringWriter.ToString();
                Assert.Equals(aJoke + Environment.NewLine, writeJoke);
            }

        }
    }
}

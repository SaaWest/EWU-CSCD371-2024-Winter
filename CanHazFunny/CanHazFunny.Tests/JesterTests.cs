using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;
using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using Assert = NUnit.Framework.Assert;


namespace CanHazFunny.Tests
{
    [TestClass]
    public class JesterTests
    {
        [Test]
        //[DataRow(new JokeService(), new TellJoke())]
        public void Constructor_JokerService_Null() {
            Assert.Throws<ArgumentNullException>(() => new Jester(null!, new OutputJoke()));

        }
        [Test]
        public void Constructor_TellJoke_Null()
        {
            Assert.Throws<ArgumentNullException>(() => new Jester(new JokeService(), null!));
        }
        [Fact]
        public void TellJoke_JokeOutput()
        {
            var jokeService = new Mock<IJokerJokes>();
            jokeService.Setup(s => s.GetJoke()).Returns("This is a joke");
            var outPut = new Mock<IJokeOutput>();

            var jester = new Jester(jokeService.Object, outPut.Object);
            jester.TellJoke();

            jokeService.Verify(s => s.GetJoke(), Times.Once);
            
            outPut.Verify( s => s.Output("This is a joke"), Times.Once);
            
        }

    }
}

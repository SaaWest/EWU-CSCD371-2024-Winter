using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CanHazFunny.Tests
{
    internal class JokeServiceTests
    {
        [Fact]
        public void GtJoke_ReturnJoke()
        {
            JokeService jokeService = new JokeService();
            string joke = jokeService.GetJoke();
            Assert.IsNotNull(joke);

        }
    }
}

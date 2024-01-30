using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CanHazFunny.Tests;
public class JokeServiceTests
{
    [Test]
    public void GtJoke_ReturnJoke()
    {
        JokeService jokeService = new();
        string joke = jokeService.GetJoke();
        Assert.IsNotNull(joke);
    }
}


using NUnit.Framework;
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


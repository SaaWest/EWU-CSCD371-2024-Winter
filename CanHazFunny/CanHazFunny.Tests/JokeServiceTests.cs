using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CanHazFunny.Tests;
public class JokeServiceTests
{
    [Test]
    public void GetJoke_ReturnJoke_NotNull()
    {
        JokeService jokeService = new();
        string joke = jokeService.GetJoke();
        Assert.IsNotNull(joke);
    }
}


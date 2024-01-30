using System;

namespace CanHazFunny;
public class OutputJoke : IJokeOutput
{
    public void Output(string joke)
    {
        Console.WriteLine(joke);
    }
}

using System;

namespace CanHazFunny;
    public class Jester(IJokerJokes jokerJokes, IJokeOutput jokeOutput)
{
    //public IJokeOutput? iJokeOutput1;

    public IJokeOutput IJokeOutput { get; set; } = jokeOutput ?? throw new ArgumentNullException(nameof(jokeOutput));
    public IJokerJokes IJoker { get; set; } = jokerJokes ?? throw new ArgumentNullException(nameof(jokerJokes));

    public void TellJoke()
        {

            string joke = IJoker.GetJoke();

            while (joke.Contains("Chuck Norris"))
            { joke = IJoker.GetJoke(); }
            IJokeOutput.Output(joke);
        }
      
    }




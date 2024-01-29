using CanHazFunny;
using System;

namespace CanHazFunny
{
    public class Jester
    {
        public IJokeOutput? iJokeOutput1;

        public IJokeOutput? IJokeOutput { get; set; }
        public IJokerJokes IJoker { get; set;}

        public Jester(IJokerJokes jokerJokes, IJokeOutput jokeOutput) 
        {
            IJoker = jokerJokes;
            IJokeOutput = jokeOutput;

        
        }
        public void TellJoke()
        {
            string joke = IJoker.GetJoke();
            while(joke.Contains("Chuck Norris"))
            {
                joke = IJoker.GetJoke();
                IJokeOutput?.Output(joke);
            }
        }
      
    }
   
}



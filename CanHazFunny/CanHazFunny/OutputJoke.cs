using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public class OutputJoke : IJokeOutput
    {
        public void Output(string joke)
        {
            Console.WriteLine(joke);
        }
    }
}

namespace CanHazFunny;
public class Program
{
    public static void Main()
    {
        new Jester(new JokeService(), new OutputJoke()).TellJoke();
    }
}

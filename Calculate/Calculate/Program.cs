namespace CalculateTests
{
    public class Program
    {
        public static void Main()
        {

        }
        public Program()
        {

        }

        public Func<string> Reader { get;  init; } = Console.ReadLine;
        public Action<string> Writer { get; init; } = Console.WriteLine;
    }
}
using Calculate;

namespace Calculate;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        double response;
        string input;
        do
        {
            program.Writer("Enter your Math expression");
            input = program.Reader()!;


        } while (!Calculator.TryCalculate(input, out response));
        program.Writer($"Answer: {response}");

    }
    public Program()
    {


    }

    public Func<string?> Reader { get;  init; } = Console.ReadLine;
    public Action<string> Writer { get; init; } = Console.WriteLine;
}
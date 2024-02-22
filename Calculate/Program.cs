namespace Calculate;

public class Program
{
    public Func<string?> ReadLine { get; init; } = Console.ReadLine;
    public Action<string> WriteLine { get; init; } = Console.WriteLine;

    public Program()
    {
    }

    public static void Main()
    {
        Program program = new();
        Calculator calculator = new Calculator();
        int response;
        string input;
        do
        {
            program.WriteLine("Enter your Math expression");
            input = program.ReadLine()!;
        } while (!calculator.TryCalculate(input, out response));
        program.WriteLine($"Answer: {response}");
    }
}
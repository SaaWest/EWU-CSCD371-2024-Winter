namespace Calculate;

public class Calculator
{
    public Calculator()
    {
    }

    public static int Add(int x, int y) => x + y;

    public static int Subtract(int x, int y) => x-y;

    public static int Divide(int x, int y) => x/y;

    public static int Multiply(int x, int y) => x*y;

    public IReadOnlyDictionary<char, Func<int, int, int>> MathematicalOperations { get; } = new Dictionary<char, Func<int, int, int>>
    {
        {'+', Add },
        {'-', Subtract },
        {'/', Divide },
        {'*', Multiply }
    };

    public bool TryCalculate(string command, out int result)
    {
        result = 0;
        string[] input = command.Split(' ');

        if (input.Length != 3)
        {
            return false;
        }

        //char operation = input[1][0];
        if (!int.TryParse(input[0], out int operand1) || !int.TryParse(input[2], out int operand2)) 
        { 
            return false; 
        }
        if (!MathematicalOperations.ContainsKey(input[1][0]) ) 
        { 
            return false; 
        }
        result = MathematicalOperations[input[1][0]](operand1, operand2);
       
        return true;
    }
}

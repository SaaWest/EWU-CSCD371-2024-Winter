namespace Calculate;

public class Calculator
{
    public Calculator()
    {

    }

    public static double Add(double x, double y) => x + y;

    public static double Subtract(double x, double y) => x-y;

    public static double Divide(double x, double y) => x/y;

    public static double Multiply(double x, double y) => x*y;

    public static readonly IReadOnlyDictionary<char, Func<double, double, double>> MathematicalOperations = new Dictionary<char, Func<double, double, double>>
    {
        {'+', Add },
        {'-', Subtract },
        {'/', Divide },
        {'*', Multiply }
    };

    public static bool TryCalculate(string command, out double result)
    {
        result = 0;
        string[] input = command.Split(' ');
        double operand1, operand2;
        
        if (input.Length != 3)
        {
            return false;
        }

        //char operation = input[1][0];
        if (!double.TryParse(input[0], out operand1) || !double.TryParse(input[2], out operand2)) 
        { 
            return false; 
        }
        if (!MathematicalOperations.ContainsKey(input[1][0]) ) 
        { 
            return false; 
        }
        var op = MathematicalOperations[input[1][0]];
        result = op(operand1, operand2);
        return true;
    }
}

using System.Globalization;
using System.Numerics;

namespace Calculate;

public class Calculator<T> where T : INumber<T>
{
    public Calculator()
    {
    }

    public static T Add(T x, T y) => x + y;

    public static T Subtract(T x, T y) => x-y;

    public static T Divide(T x, T y) => x/y;

    public static T Multiply(T x, T y) => x*y;

    public IReadOnlyDictionary<char, Func<T, T, T>> MathematicalOperations { get; } = new Dictionary<char, Func<T, T, T>>
    {
        {'+', Add },
        {'-', Subtract },
        {'/', Divide },
        {'*', Multiply }
    };

    public bool TryCalculate(string command, out T result)
    {
        result = T.Zero;
        string[] input = command.Split(' ');

        if (input.Length != 3)
        {
            return false;
        }

        //char operation = input[1][0];
        if (!T.TryParse(input[0], CultureInfo.InvariantCulture, out T? operand1) || !T.TryParse(input[2], CultureInfo.InvariantCulture,out T? operand2)) 
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

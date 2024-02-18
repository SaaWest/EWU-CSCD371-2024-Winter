using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate;

public class Calculator
{
    public Calculator()
    {

    }
    public static int Add(int x, int y) => x+y;
    public static int Subtract(int x, int y) => x-y;
    public static double Divide(double x, double y) => x/y;

    public static double Multiply(double x, double y) => x*y;
    public readonly IReadOnlyDictionary<char, Func<double, double, double>> MathematicalOperations = new Dictionary<char, Func<double, double, double>>
    {
        {'+', (a,b) => a + b },
        {'-', (a,b) => a - b },
        {'/', (a,b) => a / b },
        {'*', (a,b) => a * b }
    };

}

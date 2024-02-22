using Xunit;
using Calculate;

namespace CalculateTests;

public class CalculatorTests
{
    [Theory]
    [InlineData(1, 1)]
    public void Calculator_Add_TestSuccess(int x, int y) 
    {
        var z = Calculator.Add(x, y);
        
        Assert.Equal(2, z);
    }

    [Theory]
    [InlineData(1, 1)]
    public void Calculator_Subtract_TestSuccess(int x, int y)
    {
        var z = Calculator.Subtract(x, y);
        
        Assert.Equal(0, z);
    }

    [Theory]
    [InlineData(2, 2)]
    public void Calculator_Divide_TestSuccess(int x, int y)
    {
        var z = Calculator.Divide(x, y);
        
        Assert.Equal(1, z);
    }

    [Theory]
    [InlineData(2, 2)]
    public void Calculator_Multiply_TestSuccess(int x, int y)
    {
        var z= Calculator.Multiply(x, y);
        
        Assert.Equal(4, z);

    }

    [Theory]
    [InlineData("2 + 2", 4)]
    public void Calculator_TryCalculateAddition_TestSuccess( string expression, int output )
    {
        Calculator calculator = new();
        calculator.TryCalculate(expression, out int expected);

        Assert.Equal(output, expected);
    }

    [Theory]
    [InlineData("2 - 2", 0)]
    public void Calculator_TryCalculateSubtraction_TestSuccess(string expression, int output)
    {
        Calculator calculator = new();
        calculator.TryCalculate(expression, out int expected);

        Assert.Equal(output, expected);
    }

    [Theory]
    [InlineData("3 * 3", 9)]
    public void Calculator_TryCalculateMultiplication_TestSuccess(string expression, int output)
    {
        Calculator calculator = new();
        calculator.TryCalculate(expression, out int expected);

        Assert.Equal(output, expected);
    }

    [Theory]
    [InlineData("10 / 2", 5)]
    public void Calculator_TryCalculateDivision_TestSuccess(string expression, int output)
    {
        Calculator calculator = new();
        calculator.TryCalculate(expression, out int expected);

        Assert.Equal(output, expected);
    }

    [Theory]
    [InlineData("2+2")]
    public void Calculator_TryCalculateInvalidAddition_TestFailure(string expression)
    {
        Calculator calculator = new();
        var tests = calculator.TryCalculate(expression, out _ );

        Assert.False(tests);
    }

    [Theory]
    [InlineData("2*  2")]
    public void Calculator_TryCalculateInvalidMultiplicationWithWhiteSpace_TestFailure(string expression)
    {
        Calculator calculator = new();
        var tests = calculator.TryCalculate(expression, out _);

        Assert.False(tests);
    }

    [Theory]
    [InlineData("2 # 2")]
    public void Calculator_TryCalculateInvalidOperation_TestFailure(string expression)
    {
        Calculator calculator = new();
        var tests = calculator.TryCalculate(expression, out _);

        Assert.False(tests);
    }
}

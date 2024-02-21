using Xunit;
using Calculate;

namespace CalculateTests;

public class CalculatorTests
{
    [Fact]
    public void Calculator_Constructor_TestSuccess()
    {
        Calculator calculator = new();
        Assert.NotNull(calculator);
    }

    [Theory]
    [InlineData(1, 1)]
    public void Calculator_Add_TestSuccess(double x, double y) 
    {
        var z = Calculator.Add(x, y);
        Assert.True(z.Equals(2));
    }

    [Theory]
    [InlineData(1, 1)]
    public void Calculator_Subtract_TestSuccess(double x, double y)
    {
        var z = Calculator.Subtract(x, y);
        Assert.True(z.Equals(0));
    }

    [Theory]
    [InlineData(2, 2)]
    public void Calculator_Divide_TestSuccess(double x, double y)
    {
        var z = Calculator.Divide(x, y);
        Assert.True(z.Equals(1));
    }

    [Theory]
    [InlineData(2, 2)]
    public void Calculator_Multiply_TestSuccess(double x, double y)
    {
        var z= Calculator.Multiply(x, y);
        Assert.True(z.Equals(4));
    }

    [Theory]
    [InlineData("2 + 2", 4)]
    public void Calculator_TryCalculateAddition_TestSuccess( string expression, double output )
    {
        Calculator.TryCalculate(expression, out double expected);
        Assert.Equal(output, expected);
    }

    [Theory]
    [InlineData("2 - 2", 0)]
    public void Calculator_TryCalculateSubtraction_TestSuccess(string expression, double output)
    {
        Calculator.TryCalculate(expression, out double expected);
        Assert.Equal(output, expected);
    }

    [Theory]
    [InlineData("3 * 3", 9)]
    public void Calculator_TryCalculateMultiplication_TestSuccess(string expression, double output)
    {
        Calculator.TryCalculate(expression, out double expected);
        Assert.Equal(output, expected);
    }

    [Theory]
    [InlineData("10 / 2", 5)]
    public void Calculator_TryCalculateDivision_TestSuccess(string expression, double output)
    {
        Calculator.TryCalculate(expression, out double expected);
        Assert.Equal(output, expected);
    }

    [Theory]
    [InlineData("2+2")]
    public void Calculator_TryCalculateInvalidAddition_TestFailure(string expression)
    {
        var tests = Calculator.TryCalculate(expression, out _ );
        Assert.False(tests);
    }

    [Theory]
    [InlineData("2*  2")]
    public void Calculator_TryCalculateInvalidMultiplicationWithWhiteSpace_TestFailure(string expression)
    {
        var tests = Calculator.TryCalculate(expression, out _);
        Assert.False(tests);
    }

    [Theory]
    [InlineData("2 # 2")]
    public void Calculator_TryCalculateInvalidOperation_TestFailure(string expression)
    {
        var tests = Calculator.TryCalculate(expression, out _);
        Assert.False(tests);
    }
}

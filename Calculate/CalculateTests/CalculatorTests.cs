using Calculate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTests;

public class CalculatorTests
{
    [Fact]
    public void Calculator_Constructor_Tests()
    {
        //int x = 1; int y = 2;
        Calculator calculator = new();
    }
    [Theory]
    [InlineData(1, 1)]
    public void Calculator_Add_Test(double x, double y) 
    {
        //Calculator calculator = new(int x, int y);
        var z = Calculator.Add(x, y);
        Assert.True(z.Equals(2));
    }
    [Theory]
    [InlineData(1, 1)]
    public void Calculator_Subtract_Test(double x, double y)
    {

        var z = Calculator.Subtract(x, y);
        Assert.True(z.Equals(0));

    }
    [Theory]
    [InlineData(2, 2)]
    public void Calculator_Divide_Test(double x, double y)
    {
        var z = Calculator.Divide(x, y);
        Assert.True(z.Equals(1));
    }
    [Theory]
    [InlineData(2, 2)]
    public void Calculator_Multiply_Tests(double x, double y)
    {
        var z= Calculator.Multiply(x, y);
        Assert.True(z.Equals(4));
    }
    [Theory]
    [InlineData("2 + 2", 4)]
    public void Calculator_TryCalculate_Addition_Tests( string expression, double output )
    {
        Calculator.TryCalculate(expression, out double expected);
        Assert.Equal(output, expected);
    }
    [Theory]
    [InlineData("2 - 2", 0)]
    public void Calculator_TryCalculate_Subtraction_Tests(string expression, double output)
    {
        Calculator.TryCalculate(expression, out double expected);
        Assert.Equal(output, expected);
    }
    [Theory]
    [InlineData("3 * 3", 9)]
    public void Calculator_TryCalculate_Multiplication_Tests(string expression, double output)
    {
        Calculator.TryCalculate(expression, out double expected);
        Assert.Equal(output, expected);
    }
    [Theory]
    [InlineData("10 / 2", 5)]
    public void Calculator_TryCalculate_Division_Tests(string expression, double output)
    {
        Calculator.TryCalculate(expression, out double expected);
        Assert.Equal(output, expected);
    }
    [Theory]
    [InlineData("2+2")]
    public void Calculator_TryCalculate_InvalidAddition_Tests(string expression)
    {
        var tests = Calculator.TryCalculate(expression, out _ );
        Assert.False( tests);
    }
    [Theory]
    [InlineData("2*  2")]
    public void Calculator_TryCalculate_InvalidMultiplication_WithWhiteSpace_Tests(string expression)
    {
        var tests = Calculator.TryCalculate(expression, out _);
        Assert.False(tests);
    }
    [Theory]
    [InlineData("2 # 2")]
    public void Calculator_TryCalculate_InvalidOperation_Tests(string expression)
    {
        var tests = Calculator.TryCalculate(expression, out _);
        Assert.False(tests);
    }
}

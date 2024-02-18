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
    public void Calculator_Add_Test(int x, int y) 
    {
        //Calculator calculator = new(int x, int y);
        var z = Calculator.Add(x, y);
        Assert.True(z.Equals(2));
    }
    [Theory]
    [InlineData(1, 1)]
    public void Calculator_Subtract_Test(int x, int y)
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
        Assert.True(z.Equals(2));
    }
    [Fact]
    public void Calculator_MathmaticalOperations_Addition_Tests()
    {
        //var z = Calculator.MathematicalOperations();
        //Assert.True(z.Equals(2));
    }
}

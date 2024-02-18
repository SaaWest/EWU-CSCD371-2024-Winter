using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTests;
public class ProgramTests
{
    [Fact]
    public void Program_Read_Tests()
    {

        Program program = new();
        program.Writer("Can you Write this?");
        Assert.Contains("Can you Write this?", program.ToString());
        
    }
    [Fact]
    public void Program_Write_Tests()
    {
        
        Program program = new();
        string input = program.Reader();
        program.Writer(input);

        
    }
}

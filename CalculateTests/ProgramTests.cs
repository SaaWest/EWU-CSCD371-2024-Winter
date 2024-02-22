using Xunit;
using Calculate;

namespace CalculateTests;

public class ProgramTests
{
    [Fact]
    public void Program_ReadWrite_ValidTestSuccess()
    {
        string line= "Can you Write this?";
        string output = "";

        Program program = new() { WriteLine = (writer) => output = writer };
        program.WriteLine(line);
        Assert.Equal(line, output);
    }

    [Fact]
    public void Program_ReadWrite_InvalidTestFailure()
    {
        string line = "Can you Write this?";
        string output = "";

        Program program = new() { WriteLine = (writer) => output = writer };
        program.WriteLine(line);
        Assert.NotEqual("Writer writing", output);
    }
}

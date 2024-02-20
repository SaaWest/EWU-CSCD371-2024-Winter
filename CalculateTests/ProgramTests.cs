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

        Program program = new() { Writer = (writer) => output = writer };
        program.Writer(line);
        Assert.Equal(line, output);
    }

    [Fact]
    public void Program_ReadWrite_InvalidTestFailure()
    {
        string line = "Can you Write this?";
        string output = "";

        Program program = new() { Writer = (writer) => output = writer };
        program.Writer(line);
        Assert.NotEqual("Writer writing", output);
    }
}

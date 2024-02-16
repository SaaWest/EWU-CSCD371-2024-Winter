using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework.Tests;
public  class VennDiagramTests
{
    [Fact]
    public void VennDiagram_InstaniationTest()
    {
        List<string> except = ["A", "B"];
        VennDiagram<string> vennDiagram = new(except);
        Assert.Equal(except, vennDiagram.Except);
    }
    [Fact]
    public void VennDiagram_Union_Test()
    {
        List<string> except = ["A", "B"];
        VennDiagram<string> vennDiagram = new(except);
        vennDiagram.AddUnion("A");
        Assert.Contains("A", vennDiagram.Except);
        Assert.Contains("B", vennDiagram.Except);
    }
    /*public void VennDiagram_InstantiationTests()
    {
        VennDiagram<string> vennDia = new("A");
        Assert.NotNull(vennDia);

    }
    [Fact]
    public void VennDiagram_Except_NotNull()
    {
        VennDiagram<string> vennDiagram = new("A");
        vennDiagram.AddExcept("B");
        Assert.NotNull(vennDiagram.Except);

    }
    [Fact]
    public void VennDiagram_Union_NotNull()
    {
        VennDiagram<string> vennDiagram = new("A");
        vennDiagram.AddUnion("A");
        Assert.NotNull(vennDiagram.Union);
    }*/
  
}


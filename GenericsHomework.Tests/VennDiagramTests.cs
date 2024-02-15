using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework.Tests;
public  class VennDiagramTests
{
    [Fact]
    public void VennDiagram_InstantiationTests()
    {
        List<string> nodeList = ["A", "B", "C"];
        VennDiagram<string> vennDia = new(nodeList);
        Assert.NotNull(nodeList);
        Assert.NotNull(vennDia);

    }
    [Fact]
    public void VennDiagram_AddList_ToDiagram()
    {
        List<int> nodeList = new(12);
        List<int> nodeList2 = new(4);
        VennDiagram<int> vennDiagram = new(nodeList);
        vennDiagram.Add(nodeList2);     

    }
    /*[Fact]
    public void */
}


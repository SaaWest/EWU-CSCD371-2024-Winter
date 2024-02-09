using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace GenericsHomework.Tests;
public class NodeTests
{
    [Fact]
    public void NodeTests_FirstNode_ValueNotNull_NullPrev_NullNext()
    {
        var myNode = new Node(12, null!, null!);

        Assert.NotNull(myNode.Value);
        //Assert.Null(myNode.Next);
        Assert.Null(myNode.Prev);
    }
    [Fact]
    public void NodeTests_FirstNode_ValueNotNull_Prev_Next()
    {
        var myNode = new Node(4, null!, null!);
        var myNode2 = new Node(12, myNode, null!);
        myNode.Next = myNode2;
        Assert.NotNull(myNode.Value);
        Assert.Null(myNode.Prev);
        //Assert.NotNull(myNode.Next);
        Assert.NotNull(myNode2.Prev);
    }
    [Fact]
    public void ToString_Override_Tests()
    {
        var myNode = new Node(12, null!, null!);
        Console.WriteLine(myNode);

    }
}


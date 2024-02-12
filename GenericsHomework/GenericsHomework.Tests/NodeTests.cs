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
        var myNode = new Node(12);

        Assert.NotNull(myNode.Value);
        Assert.Null(myNode.Next);
        //Assert.Null(myNode.Prev);
    }
    [Fact]
    public void NodeTests_FirstNode_Append_SecondNode()
    {
        var myNode = new Node(4);
        var myNode2 = new Node(12);
        //myNode2.Prev = myNode;
        myNode.Append(myNode2);
        Assert.NotNull(myNode.Value);
        //Assert.Null(myNode.Prev);
        Assert.NotNull(myNode2.Value);
        //Assert.NotNull(myNode2.Prev);
    }
    [Fact]
    public void ToString_Override_Tests()
    {
        var myNode = new Node(12);
        Console.WriteLine(myNode);

    }
    [Fact]
    public void NodeTests_ClearMethod_deleteAll()
    {
        var myNode = new Node(12);
        var myNode2 = new Node(4);
        //myNode2.Prev = myNode;
        myNode.Append(myNode2);
        myNode.Clear(myNode2);

    }
    [Fact]
    public void NodeTests_ExistMethod()
    {
        var myNode = new Node(12);
    }
}


namespace GenericsHomework.Tests;
public class NodeTests
{
    [Fact]
    public void NodeTests_NodeNotNull_Sucess()
    {
        Node<string> myNode = new("12");

        Assert.NotNull(myNode.Value);
    }

    [Fact]
    public void NodeTests_NodeNextNotNull_Success()
    {
        Node<string> myNode = new("12");

        Assert.NotNull(myNode.Next);
    }

    [Fact]
    public void NodeTests_AddMultipleUniqueNodesNodeNotNull_Success()
    {
        Node<string> myNode = new("4");
        
        myNode.Append("12");
        myNode.Append("23");
        myNode.Append("18");

        Assert.NotNull(myNode.Value);
    }

    [Fact]
    public void NodeTests_AddMultipleUniqueNodesNextValueNotNull_Success()
    {
        Node<string> myNode = new("9");

        myNode.Append("1");
        myNode.Append("2");
        myNode.Append("8");

        Assert.NotNull(myNode.Next.Value);
    }

    [Fact]
    public void NodeTests_FirstAndSecondNodeUniqueNotNull_Success()
    {
        Node<string> myNode = new("4");

        myNode.Append("8");

        Assert.NotNull(myNode.Value);
    }

    [Fact]
    public void NodeTests_FirstAndSecondNodeUniqueNextNotNull_Success()
    {
        Node<string> myNode = new("45");

        myNode.Append("98");

        Assert.NotNull(myNode.Next);
    }

    [Fact]
    public void NodeTests_ToStringOverride_Success()
    {
        Node<int> myNode = new(12);

        Assert.Equal("12", myNode.ToString());
    }

    [Fact]
    public void NodeTests_ClearMethodDeleteNextNode_Success()
    {
        Node<string> myNode = new("12");
        
        myNode.Append("4");
        myNode.Clear();

        Assert.Equal("12", myNode.Value);
    }

    [Fact]
    public void NodeTests_ExistMethod_Success()
    {
        Node<int> myNode = new(12);

        Assert.True(myNode.Exists(12));
    }

    [Fact]
    public void NodeTests_NullToString_Failure()
    {
        Node<string> myNode = new(null!);

        Assert.Throws<ArgumentException>(myNode.ToString);
    }

    [Fact]
    public void NodeTests_AppendSameValue_Failure()
    {
        Node<string> myNode = new("2");

        Assert.Throws<ArgumentException>(() => myNode.Append("2"));
    }
}


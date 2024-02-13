namespace GenericsHomework.Tests;
public class NodeTests
{
    [Fact]
    public void NodeTests_FirstNode_ValueNotNull_NullPrev_NullNext()
    {
        Node<string> myNode = new("12");

        Assert.NotNull(myNode.Value);
        Assert.NotNull(myNode.Next);
    }

    [Fact]
    public void NodeTests_FirstNode_Append_SecondNode_Unique()
    {
        Node<string> myNode = new("4");
        
        myNode.Append("12");
        myNode.Append("23");
        myNode.Append("18");
        Assert.NotNull(myNode.Value);
        Assert.NotNull(myNode.Next.Value);
    }

    [Fact]
    public void NodeTests_FirstNode_Append_SecondNode_NotUnique()
    {
        Node<string> myNode = new("4");

        myNode.Append("8");
        Assert.NotNull(myNode.Value);
        Assert.NotNull(myNode.Next);

    }

    [Fact]
    public void ToString_Override_Tests()
    {
        Node<int> myNode = new(12);

        Assert.Equal("12", myNode.ToString());
    }

    [Fact]
    public void NodeTests_ClearMethod_deleteAll()
    {
        Node<string> myNode = new("12");
        
        myNode.Append("4");
        Assert.NotNull(myNode.Next);
        myNode.Clear();
        Assert.Equal("12", myNode.Value);
    }

    [Fact]
    public void NodeTests_ExistMethod()
    {
        Node<int> myNode = new(12);

        Assert.True(myNode.Exists(12));
    }

    [Fact]
    public void NodeTests_NullToString_Failure()
    {
        Node<string> myNode = new(null!);
        Assert.Throws<System.ArgumentException>(myNode.ToString);
    }
}


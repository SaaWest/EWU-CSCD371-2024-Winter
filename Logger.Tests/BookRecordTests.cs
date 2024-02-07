using Xunit;

namespace Logger.Tests;
public class BookRecordTests
{
    [Fact]
    public void BookRecord_With_BookName_AuthorName_NotNull()
    {
        BookRecord book = new("Do Robots Dream of Electric Sheep", "Philip K. Dick");
        Assert.NotNull(book);
        Assert.Equal("Do Robots Dream of Electric Sheep", book.BookName);
        Assert.Equal("Philip K. Dick", book.AuthorName);
    }

    [Fact]
    public void BookRecord_With_BookName_Null()
    {
        Assert.Throws<ArgumentNullException>(() => new BookRecord(null!, "Philip k. Dick"));


    }
    [Fact]
    public void BookRecord_With_AuthorName_Null()
    {
        Assert.Throws<ArgumentNullException>(() => new BookRecord("Do Robots Dream of Electric Sheep", null!));

    }


}


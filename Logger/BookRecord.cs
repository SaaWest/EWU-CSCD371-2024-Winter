namespace Logger;

public record BookRecord : BaseEntity
{
    //implicit declaration because this is an 'is a' relationship and there is no conflict with the implementation
    public BookRecord(string bookName, string authorName)
    {
        BookName = bookName ?? throw new ArgumentNullException(nameof(bookName));
        AuthorName = authorName ?? throw new ArgumentNullException(nameof(authorName));
    }
    public string BookName { get; set; }
    public string AuthorName { get; set; }
    public override string Name { get { return BookName +" "+  AuthorName; } }
}

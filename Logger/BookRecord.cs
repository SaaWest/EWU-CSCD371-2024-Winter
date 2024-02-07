namespace Logger;

public record BookRecord : IEntity
{
    //implicit declaration because the reader should have access to the Name and Id
    public BookRecord(string bookName, string authorName)
    {
        BookName = bookName ?? throw new ArgumentNullException(nameof(bookName));
        AuthorName = authorName ?? throw new ArgumentNullException(nameof(authorName));
  
        
    }
    public string BookName { get; set; }
    public string AuthorName { get; set; }
    public Guid ID { init => throw new NotImplementedException(); }
    public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

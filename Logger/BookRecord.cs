using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record BookRecord : IEntity
{
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

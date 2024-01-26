namespace Logger;

public class LogFactory
{
    private string? File { get; set; }

    public BaseLogger? CreateLogger(string className)
    {
       return File is null ? null : new FileLogger(className, File);
    }

    public void ConfigureFileLogger(string? filePath) => File = filePath;
}


namespace Logger;

public class LogFactory
{
    private string? File;

    public FileLogger? CreateLogger(string? file, string? className)
    {
        if (file != null && className != null)
        {
            return new FileLogger(file) { ClassName = className };
        }
        else
        {
            return null;
        }
    }

    public string? ConfigureFileLogger(string? filePath)
    {
        File = filePath;
        return File;
    }
    
}


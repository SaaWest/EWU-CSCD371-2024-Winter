namespace Logger;

public class LogFactory
{
    private string? File { get; set; }

    public BaseLogger? CreateLogger(string className)
    {
       return File is null ? null : new FileLogger(className, File);
        /*if (file != null && className != null)
        {
            return new FileLogger(file) { ClassName = className };
        }
        else
        {
            return null;
        }*/
    }

    public void ConfigureFileLogger(string? filePath) => File = filePath;
    /*{
        File = filePath;
        return File;
    }*/
    
}


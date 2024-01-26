using System.IO;
using System;

namespace Logger;

public class FileLogger : BaseLogger
{
    public FileLogger(string className, string filePath)
    {
        FilePath = filePath;
        File = new FileInfo(filePath);
        ClassName = className;
    }
    public string FilePath { get; }

    private FileInfo File { get; }

    public override string ClassName { get;}

    public override void Log(LogLevel logLevel, string message)
    {
        using (StreamWriter writer = File.AppendText())
        {
            writer.WriteLine($"{DateTime.Now} {ClassName} {logLevel} {message}");
        }
    }
}
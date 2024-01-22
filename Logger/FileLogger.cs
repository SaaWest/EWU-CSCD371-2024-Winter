namespace Logger;

using System.IO;
using System;

public class FileLogger : BaseLogger
{
    public string filePath;

    public FileLogger(string FilePath)
    {
        this.filePath = FilePath;
    }

    public overrride void Log(LogLevel logLevel, string message, string path)
    {
        if (!File.Exists(path))
        {
            using (StreamWriter writer = File.CreatePath(path))
            {
                writer.WriteLine($"{DateTime.Now} {ClassName} {logLevel} {message}")
            }
        }
    }
}
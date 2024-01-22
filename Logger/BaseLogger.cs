//baseloger
namespace Logger;
using System.IO;
using System;
using System.Globalization;

public abstract class BaseLogger
{
    public string ClassName { get; set; }

    public abstract void Log(LogLevel logLevel, string message);


}
//this needs to be discussed: as the Log above is the same
public class FileLogger : BaseLogger
{
    public string filePath;

    public FileLogger(string FilePath)
    {
        this.filePath = FilePath;
    }

    public overrride void Log(LogLevel logLevel, string, message, string path)
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
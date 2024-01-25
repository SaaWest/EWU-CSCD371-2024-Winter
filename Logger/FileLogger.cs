using System.IO;
using System;

namespace Logger;

public class FileLogger : BaseLogger
{
    public string filePath;

    public FileLogger(string FilePath)
    {
        this.filePath = FilePath;
    }

    public override void Log(LogLevel logLevel, string message)
    {
        string path = filePath;

        if (!File.Exists(path))
        {
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{DateTime.Now} {ClassName} {logLevel} {message}");
            }
            using (StreamReader steamRead = File.OpenText(path))
            {
                string? messageWriter = "";
                while ((messageWriter = steamRead.ReadLine()) != null)
                {
                    Console.WriteLine(messageWriter);
                }
            }
        }

    }
}
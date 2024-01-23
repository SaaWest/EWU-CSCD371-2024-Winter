using System.IO;
using System;

namespace Logger
{
    public class FileLogger : BaseLogger
    {
        public string filePath;

        public FileLogger(string FilePath)
        {
            this.filePath = FilePath;
        }

        public void Log(LogLevel logLevel, string message, string path)
        {
            if (!File.Exists(path))
            {
                //using (StreamWriter writer = File.CreatePath(path)) 
                //{
                //    writer.WriteLine($"{DateTime.Now} {ClassName} {logLevel} {message}");
                //}
            }
        }
    }
}
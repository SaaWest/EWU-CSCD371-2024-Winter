namespace Logger
{
    public class LogFactory
    {
        //BaseLogger Logger = new BaseLogger() { ClassName = className };
        private string File;
        public BaseLogger CreateLogger(string? className)
        {
            if (File != null)
            {
                return new FileLogger(File) { ClassName = className };
            }
            else
            {
                return null;
            }

        }

        public string ConfigureFileLogger(string? filePath)
        {
            File = filePath;
            return File;
        }
    }
}

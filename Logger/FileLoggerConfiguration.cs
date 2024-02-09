namespace Logger;

public class FileLoggerConfiguration(string filePath, string logSource) : ILoggerConfiguration
{
    public string FilePath { get; } = string.IsNullOrWhiteSpace(filePath)
                ? throw new ArgumentException($"'{nameof(filePath)}' cannot be null or whitespace.", nameof(filePath))
                : filePath;
    public string LogSource { get; } = string.IsNullOrWhiteSpace(logSource)
                ? throw new ArgumentException($"'{nameof(logSource)}' cannot be null or whitespace.", nameof(logSource))
                : logSource;
}

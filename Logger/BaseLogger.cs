namespace Logger;

// We do not implement ILogger here because you can
// only have abstract static methods on interfaces.
public abstract class BaseLogger(string logSource)
{
    public string LogSource { get; } = string.IsNullOrWhiteSpace(logSource)
            ? throw new ArgumentException($"'{nameof(logSource)}' cannot be null or whitespace.", nameof(logSource))
            : logSource;

    public abstract void Log(LogLevel logLevel, string message);

    // You can only have abstract static methods on interfaces.
    // public abstract static ILogger CreateLogger(in ILoggerConfiguration configuration);
}

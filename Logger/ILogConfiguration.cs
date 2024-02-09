namespace Logger;

public interface ILoggerConfiguration
{
    //Implemented implicietly because it 'can do' log configuration
    string LogSource { get; }
}
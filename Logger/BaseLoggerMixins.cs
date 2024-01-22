//baseloggerMixins
namespace Logger;

public static class BaseLoggerMixins
{
    public static void Error(this BaseLogger? logger, string message, params arguement[])
    { 
        if (logger == null)
        {
            Console.WriteLine("object is null");
        }
        else
        {
            string formatedMessage = string.Format(message, arguement);
            logger.Log(LogLevel.Error, formatedMessage);
        }
    }
    public static void Warning(this BaseLogger? logger, string message, params arguement[])
    {
        if (logger == null)
        {
            Console.WriteLine("object is null");
        }
        else
        {
            string formatedMessage = string.Format(message, arguement);
            logger.Log(LogLevel.Warning, formatedMessage);
        }
    }
    public static void Information(this BaseLogger? logger, string message, params arguement[])
    {
        if (logger == null)
        {
            Console.WriteLine("object is null");
        }
        else
        {
            string formatedMessage = string.Format(message, arguement);
            logger.Log(LogLevel.Information, formatedMessage);
        }
    }
    public static void Debug(this BaseLogger? logger, string message, params arguement[])
    {
        if (logger == null)
        {
            Console.WriteLine("object is null");
        }
        else
        {
            string formatedMessage = string.Format(message, arguement);
            logger.Log(LogLevel.Debug, formatedMessage);
        }
    }

}

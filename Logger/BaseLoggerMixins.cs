//baseloggerMixins
using System;
namespace Logger;

public static class BaseLoggerMixins
{
    
    public static void Error(this BaseLogger? logger, string message, params string[] arguement)
    { 
        if (logger == null)
        {
            throw new ArgumentNullException(nameof(logger));
        }
        else
        {
            string formatedMessage = string.Format(message, arguement);
            logger.Log(LogLevel.Error, formatedMessage);
        }
    }
    public static void Warning(this BaseLogger? logger, string message, params string[] arguement)
    {
        if (logger == null)
        {
            throw new ArgumentNullException(nameof (logger));
        }
        else
        {
            string formatedMessage = string.Format(message, arguement);
            logger.Log(LogLevel.Warning, formatedMessage);
        }
    }
    public static void Information(this BaseLogger? logger, string message, params string[] arguement)
    {
        if (logger == null)
        {
            throw new ArgumentNullException(nameof (logger));
        }
        else
        {
            string formatedMessage = string.Format(message, arguement);
            logger.Log(LogLevel.Information, formatedMessage);
        }
    }
    public static void Debug(this BaseLogger? logger, string message, params string[] arguement)
    {
        if (logger == null)
        {
            throw new ArgumentNullException(nameof(logger));
        }
        else
        {
            string formatedMessage = string.Format(message, arguement);
            logger.Log(LogLevel.Debug, formatedMessage);
        }
    }
    

}


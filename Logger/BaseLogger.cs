//baseloger

using System.IO;
using System;
using System.Globalization;

namespace Logger;

public abstract class BaseLogger
{
    public required string ClassName { get; set; }

    public abstract void Log(LogLevel logLevel, string message);
}

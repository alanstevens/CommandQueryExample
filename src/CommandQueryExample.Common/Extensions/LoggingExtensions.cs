using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CommandQueryExample.Common.Extensions
{
    public static class LoggingExtensions
    {
        public static Action<object, Exception> ExceptionLogger =
            (loggingContext, ex) => Logger.Error(loggingContext, ex.Serialize());

        [DebuggerStepThrough]
        public static void LogDebug(this object loggingContext, string message)
        {
            Logger.Debug(loggingContext, message);
        }

        [DebuggerStepThrough]
        public static void LogException(this object loggingContext, string message, Exception ex)
        {
            loggingContext.LogException(new Exception(message, ex));
        }

        [DebuggerStepThrough]
        public static void LogException(this object loggingContext, Exception ex)
        {
            ExceptionLogger(loggingContext, ex);
        }

        [DebuggerStepThrough]
        public static void LogInfo(this object loggingContext, string message)
        {
            Logger.Info(loggingContext, message);
        }

        [DebuggerStepThrough]
        public static void LogWarn(this object loggingContext, string message)
        {
            Logger.Warn(loggingContext, message);
        }

        [DebuggerStepThrough]
        public static void LogFatal(this object loggingContext, string message)
        {
            Logger.Fatal(loggingContext, message);
        }

        [DebuggerStepThrough]
        public static void Trace(this object loggingContext, string message)
        {
            message = Regex.Replace(message, @"Password:(\w*)", "Password:***", RegexOptions.Multiline);

            Logger.Trace(message);
        }
    }
}
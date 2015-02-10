using System;
using System.Diagnostics;

namespace CommandQueryExample.Common.Extensions
{
    public static class ExceptionExtensions
    {
        [DebuggerStepThrough]
        public static string Serialize(this Exception ex)
        {
            return SerializeException(ex, "");
        }

        static string SerializeException(Exception e, string exceptionMessage)
        {
            if (e.IsNull()) return string.Empty;

            exceptionMessage = "{0}{1}{2}\n{3}".FormatWith(exceptionMessage, exceptionMessage.IsEmpty() ? "" : "\n\n",
                                                           e.Message, e.StackTrace);

            if (e.InnerException.IsNotNull()) exceptionMessage = SerializeException(e.InnerException, exceptionMessage);

            return exceptionMessage;
        }
    }
}
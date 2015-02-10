using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using log4net;
using log4net.Appender;
using log4net.Config;

namespace CommandQueryExample.Common
{
    public class Logger : IStartupTask
    {
        const string ConfigFileName = "Log4Net.config";

        static bool _logInitialized;
        static readonly Dictionary<Type, ILog> Loggers = new Dictionary<Type, ILog>();

        public static Action<object, object> Debug = (source, message) => { };
        public static Action<object, object> Error = (source, message) => { };
        public static Action<object, object> Fatal = (source, message) => { };
        public static Action<object, object> Info = (source, message) => { };
        public static Action<object, object> Warn = (source, message) => { };
        public static Action<object> Trace = message => { };

        ILog _traceLogger;

        ILog TraceLogger { get { return _traceLogger ?? (_traceLogger = LogManager.GetLogger("Trace")); } }

        public void OnStartup()
        {
            Debug = (source, message) => GetLogger(GetSourceType(source)).Debug(message);
            Error = (source, message) => GetLogger(GetSourceType(source)).Error(message);
            Fatal = (source, message) => GetLogger(GetSourceType(source)).Fatal(message);
            Info = (source, message) => GetLogger(GetSourceType(source)).Info(message);
            Warn = (source, message) => GetLogger(GetSourceType(source)).Warn(message);
            Trace = message => TraceLogger.Info(message);
        }

        static Type GetSourceType(object source)
        {
            var sourceType = source.GetType();
            if (sourceType == typeof (Type)) return source as Type;
            return sourceType;
        }

        static ILog GetLogger(Type source)
        {
            EnsureInitialized();

            if (Loggers.ContainsKey(source)) return Loggers[source];

            lock (Loggers)
            {
                if (!Loggers.ContainsKey(source)) Loggers.Add(source, LogManager.GetLogger(source));
            }

            return Loggers[source];
        }

        static void EnsureInitialized()
        {
            if (_logInitialized) return;

            Initialize();
            _logInitialized = true;
        }

        static void Initialize()
        {
            XmlConfigurator.ConfigureAndWatch(new FileInfo(GetConfigFilePath()));
        }

        static string GetConfigFilePath()
        {
            var basePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            var configPath = Path.Combine(basePath, ConfigFileName);

            if (File.Exists(configPath)) return configPath;

            configPath = Path.Combine(basePath, "bin");
            configPath = Path.Combine(configPath, ConfigFileName);

            if (!File.Exists(configPath)) configPath = Path.Combine(basePath, @"..\" + ConfigFileName);

            return configPath;
        }

        public static void LogCleanUp()
        {
            var repo = GetLogger(GetSourceType("Debug")).Logger.Repository;

            if (repo == null)
                throw new NotSupportedException("Log4Net has not been configured yet.");

            var rollingFileAppenders = repo.GetAppenders().Where(x => x.GetType() == typeof (RollingFileAppender)).ToList();
            foreach (var appender in rollingFileAppenders)
                CleanUp(appender);
        }

        static void CleanUp(IAppender app)
        {
            try
            {
                if (app == null) return;
                var appender = app as RollingFileAppender;

                if (appender == null) return;
                if (appender.MaxSizeRollBackups <= 0) return;

                var directory = Path.GetDirectoryName(appender.File);
                var fileName = Path.GetFileName(appender.File);
                var filePrefix = Path.GetFileName(appender.File);
                if (filePrefix != null)
                {
                    filePrefix = filePrefix.Substring(0, filePrefix.IndexOf(".", StringComparison.Ordinal));
                    filePrefix = filePrefix.Substring(0, filePrefix.IndexOfAny("0123456789".ToCharArray()));
                }

                var purgeDate = DateTime.Now.AddDays(appender.MaxSizeRollBackups*(-1));
                CleanUp(directory, filePrefix, purgeDate, fileName);
            }
            catch
            {
                throw new Exception("Invalid Log Type");
            }
        }

        static void CleanUp(string logDirectory, string logPrefix, DateTime date, string fileName)
        {
            if (string.IsNullOrEmpty(logDirectory))
                throw new ArgumentException("logDirectory is missing");

            if (string.IsNullOrEmpty(logPrefix))
                throw new ArgumentException("logPrefix is missing");

            var dirInfo = new DirectoryInfo(logDirectory);
            if (!dirInfo.Exists)
                return;

            var fileInfos = dirInfo.GetFiles(string.Format("{0}*.*", logPrefix));
            if (fileInfos.Length == 0)
                return;

            foreach (var info in fileInfos.Where(info => info.Name.ToUpper().StartsWith(logPrefix.ToUpper())
                                                         && String.Compare(info.Name, fileName, StringComparison.InvariantCultureIgnoreCase) != 0 && info.CreationTime < date))
                info.Delete();
        }
    }
}
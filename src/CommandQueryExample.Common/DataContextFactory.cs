using System;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common
{
    public static class DataContextFactory
    {
        // TODO: HAS 02/09/2015 Handle multiple data context classes.
        static Func<IDataContext> _createDataContext;

        static Lazy<IDataContext> _currentContext;

        static readonly object _lock = new object();

        public static IDataContext CurrentContext
        {
            get
            {
                lock (_lock)
                {
                    if (_currentContext.IsNull()) throw new NullReferenceException("CurrentContext is null.");
                    if (_currentContext.Value.IsNull()) throw new NullReferenceException("CurrentContext is null.");
                    if (_currentContext.Value.IsDisposed) throw new ObjectDisposedException("CurrentContext has been disposed.");
                    return _currentContext.Value;
                }
            }
            private set
            {
                lock (_lock)
                {
                    if (_currentContext.IsNotNull() &&_currentContext.Value.IsNotNull() && !_currentContext.Value.IsDisposed)
                        throw new InvalidOperationException("CurrentContext has not been disposed.");
                    _currentContext = new Lazy<IDataContext>(() => value);
                }
            }
        }

        public static Func<IDataContext> CreateDataContext
        {
            get
            {
                lock (_lock)
                {
                    if (_createDataContext.IsNull())
                        throw new NullReferenceException("DataContextFactory.CreateDataContext is not properly configured.");
                    if (_currentContext.IsNotNull() && !_currentContext.Value.IsDisposed)
                        throw new InvalidOperationException("CurrentContext has not been disposed.");
                    return _createDataContext;
                }
            }
            set
            {
                _createDataContext = () =>
                {
                    CurrentContext = value();
                    return CurrentContext;
                };
            }
        }
    }
}
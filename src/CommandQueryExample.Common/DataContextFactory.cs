using System;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common
{
    public static class DataContextFactory
    {
        // TODO: HAS 02/09/2015 Handle multiple data context classes.
        static Func<IDataContext> _createDataContext;

        static WeakReference<IDataContext> _currentContext;

        static readonly object _lock = new object();

        public static IDataContext CurrentContext
        {
            get
            {
                lock (_lock)
                {
                    if (_currentContext.IsNull()) throw new NullReferenceException("CurrentContext is null.");
                    IDataContext context;
                    _currentContext.TryGetTarget(out context);
                    if (context.IsNull()) throw new NullReferenceException("CurrentContext is null.");
                    if (context.IsDisposed) throw new ObjectDisposedException("CurrentContext has been disposed.");
                    return context;
                }
            }
            private set
            {
                lock (_lock)
                {
                    if(_currentContext.IsNotNull())
                    {
                        IDataContext context;
                        _currentContext.TryGetTarget(out context);
                        
                        if (_currentContext.IsNotNull() && context.IsNotNull() && !context.IsDisposed)
                            throw new InvalidOperationException("CurrentContext has not been disposed.");
                        
                    }
                    _currentContext = new WeakReference<IDataContext>(value);
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

                    if (_currentContext.IsNotNull())
                    {
                        IDataContext context;
                        _currentContext.TryGetTarget(out context);
                        
                        if (context.IsNotNull() && !context.IsDisposed)
                            throw new InvalidOperationException("CurrentContext has not been disposed.");
                        
                    }
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
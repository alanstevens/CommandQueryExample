using System;
using System.Diagnostics;

namespace CommandQueryExample.Common
{
    public abstract class DisposableBase : IDisposable
    {
        public bool IsDisposed { get; private set; }

        [DebuggerStepThrough]
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool disposing)
        {
            if (!IsDisposed) OnDisposing(disposing);
            IsDisposed = true;
        }

        protected abstract void OnDisposing(bool disposing);

        ~DisposableBase()
        {
            Dispose(false);
        }
    }
}
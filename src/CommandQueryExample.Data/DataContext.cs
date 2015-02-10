using System;
using System.Data.Entity;
using System.Threading.Tasks;
using CommandQueryExample.Common;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Data
{
    public class DataContext : DisposableBase, IDataContext
    {
        public DataContext(DbContext context)
        {
            Context = context;
        }

        public DbContext Context { get; private set; }

        public void SaveChanges()
        {
            if (IsDisposed) throw new Exception("DbContext has been disposed.");
            if (Context.IsNull()) throw new NullReferenceException("DbContext is null.");

            Context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            if (IsDisposed) throw new Exception("DbContext has been disposed.");
            if (Context.IsNull()) throw new NullReferenceException("DbContext is null.");

            return await Context.SaveChangesAsync();
        }

        protected override void OnDisposing(bool disposing)
        {
            if (!disposing) return;

            if (IsDisposed) throw new Exception("DbContext has been disposed.");
            if (Context.IsNull()) throw new NullReferenceException("DbContext is null.");

            Context.Dispose();
        }
    }
}
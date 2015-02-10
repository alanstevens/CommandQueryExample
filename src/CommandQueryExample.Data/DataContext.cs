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
            ValidateContext();

            Context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            ValidateContext();

            return await Context.SaveChangesAsync();
        }

        public void SaveChangesWithTransaction()
        {
            ValidateContext();

            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    Context.SaveChanges();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        protected override void OnDisposing(bool disposing)
        {
            if (!disposing) return;

            ValidateContext();

            Context.Dispose();
        }

        void ValidateContext()
        {
            if (IsDisposed) throw new Exception("DbContext has been disposed.");
            if (Context.IsNull()) throw new NullReferenceException("DbContext is null.");
        }
    }
}
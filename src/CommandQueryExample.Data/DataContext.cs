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

        public int SaveChanges()
        {
            ValidateContext();

            return Context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            ValidateContext();

            return await Context.SaveChangesAsync();
        }

        public int SaveChangesWithTransaction()
        {
            ValidateContext();

            using (var transaction = Context.Database.BeginTransaction())
            {
                int result;
                try
                {
                    result = Context.SaveChanges();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
                return result;
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
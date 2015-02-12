using System;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using CommandQueryExample.Common;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Data
{
    public class DataContext : DisposableBase, IDataContext
    {
        readonly WeakReference<DbContext> _context;

        public DataContext(DbContext context)
        {
            _context = new WeakReference<DbContext>(context); 
        }

        public DbContext Context
        {
            get
            {
                if (IsDisposed) throw new ObjectDisposedException("DbContext has been disposed.");
                if (_context.IsNull()) throw new NullReferenceException("dbContext is null.");

                DbContext dbContext;
                _context.TryGetTarget(out dbContext);

                if (dbContext.IsNull()) throw new NullReferenceException("dbContext is null.");

                return dbContext;
            }
        }

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

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            ValidateContext();

            return await Context.SaveChangesAsync(cancellationToken);
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

            if (_context.IsNull()) return;

            DbContext dbContext;
            _context.TryGetTarget(out dbContext);

            if(dbContext.IsNotNull()) 
                dbContext.Dispose();
        }

        void ValidateContext()
        {
            if (IsDisposed) throw new ObjectDisposedException("DbContext has been disposed.");
            if (_context.IsNull()) throw new NullReferenceException("DbContext is null.");
            DbContext dbContext;
            _context.TryGetTarget(out dbContext);
            if (dbContext.IsNull()) throw new NullReferenceException("DbContext is null.");
        }
    }
}
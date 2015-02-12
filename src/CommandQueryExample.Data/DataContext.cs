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
        public DataContext(DbContext context, bool useTransaction = false)
        {
            _context = new WeakReference<DbContext>(context);
            if (useTransaction) _transaction = new WeakReference<DbContextTransaction>(context.Database.BeginTransaction());
        }

        readonly WeakReference<DbContext> _context;
        readonly WeakReference<DbContextTransaction> _transaction;

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
            var dbContext = ValidateContext();

            return dbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            var dbContext = ValidateContext();

            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            var dbContext = ValidateContext();

            return await dbContext.SaveChangesAsync(cancellationToken);
        }

        protected override void OnDisposing(bool disposing)
        {
            if (!disposing) return;

            var dbContext = ValidateContext();

            DbContextTransaction transaction = null;

            if (_transaction.IsNotNull())
                _transaction.TryGetTarget(out transaction);

            if (transaction.IsNotNull())
            {
                try
                {
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
                transaction.Dispose();
            }

            dbContext.Dispose();
        }

        DbContext ValidateContext()
        {
            if (IsDisposed) throw new ObjectDisposedException("DbContext has been disposed.");
            if (_context.IsNull()) throw new NullReferenceException("DbContext is null.");
            DbContext dbContext;
            _context.TryGetTarget(out dbContext);
            if (dbContext.IsNull()) throw new NullReferenceException("DbContext is null.");
            return dbContext;
        }
    }
}
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CommandQueryExample.Common
{
    public interface IDataContext : IDisposable
    {
        bool IsDisposed { get; }

        int SaveChanges();

        Task<int> SaveChangesAsync();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
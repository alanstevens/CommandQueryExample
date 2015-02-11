using System;
using System.Threading.Tasks;

namespace CommandQueryExample.Common
{
    public interface IDataContext : IDisposable
    {
        bool IsDisposed { get; }

        int SaveChanges();

        Task<int> SaveChangesAsync();

        int SaveChangesWithTransaction();
    }
}
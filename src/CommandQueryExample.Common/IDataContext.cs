using System;
using System.Threading.Tasks;

namespace CommandQueryExample.Common
{
    public interface IDataContext : IDisposable
    {
        bool IsDisposed { get; }

        void SaveChanges();

        Task<int> SaveChangesAsync();

        void SaveChangesInTransaction();
    }
}
using System;
using System.Threading.Tasks;

namespace CommandQueryExample.Common
{
    public interface IDataContext : IDisposable
    {
        void SaveChanges();

        Task<int> SaveChangesAsync();

        bool IsDisposed { get; }
    }
}
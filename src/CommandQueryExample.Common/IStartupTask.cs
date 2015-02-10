namespace CommandQueryExample.Common
{
    /// <summary>
    ///     Implement this interface to execute code that must fire at application startup but after the IoC container is
    ///     configured.
    ///     Execution order is non-determinant.
    /// </summary>
    public interface IStartupTask
    {
        void OnStartup();
    }
}
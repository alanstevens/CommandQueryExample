using CommandQueryExample.Common;

namespace CommandQueryExample.Data
{
    public class DataContextFactoryStartupTask : IStartupTask
    {
        public void OnStartup()
        {
            DataContextFactory.DataContextInitializer = useTransaction => new DataContext(new SampleContext(), useTransaction);
        }
    }
}
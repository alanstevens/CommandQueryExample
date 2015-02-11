using CommandQueryExample.Common;

namespace CommandQueryExample.Data
{
    public class DataContextFactoryStartupTask : IStartupTask
    {
        public void OnStartup()
        {
            DataContextFactory.CreateDataContext = () => new DataContext(new SampleContext());
        }
    }
}
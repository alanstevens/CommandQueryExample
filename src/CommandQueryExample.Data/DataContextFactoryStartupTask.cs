using CommandQueryExample.Common;

namespace CommandQueryExample.Data
{
    public class DataContextFactoryStartupTask : IStartupTask
    {
        public void OnStartup()
        {
            DataContextFactory.DataContextInitializer = useTransaction => new DataContext(new SampleContext(), useTransaction);

            // If you use your DI container to manage your DbContext lifecycle,
            // you can do something like this to prevent the DataContextFactory
            // from disposing your DbContext.
            //DataContextFactory.DataContextInitializer = useTransaction =>
            //{
            //    var sampleContext = ServiceLocator.Current.GetInstance<SampleContext>();
            //    return new DataContext(sampleContext, useTransaction, false);
            //};
        }
    }
}
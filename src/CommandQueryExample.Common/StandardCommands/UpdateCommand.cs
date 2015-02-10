namespace CommandQueryExample.Common.Commands
{
    public class UpdateCommand<T> : CommandBase<T> where T : class
    {
        public UpdateCommand(T item)
        {
            _action = s => MarkAsModified(item);
        }
    }
}
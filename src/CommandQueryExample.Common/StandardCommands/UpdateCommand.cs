namespace CommandQueryExample.Common.StandardCommands
{
    public class UpdateCommand<T> : BaseCommand<T> where T : class
    {
        public UpdateCommand(T item)
        {
            _action = s => MarkAsModified(item);
        }
    }
}
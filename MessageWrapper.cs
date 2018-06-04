namespace graphdbtest
{
    public class MessageWrapper
    {
        private readonly IMessenger _messenger;

        public MessageWrapper(IMessenger messenger)
        {
            _messenger = messenger;
        }

        public void SendError(string message)
        {
            _messenger.Error(message);
        }

        public void SendMessage(string message)
        {
            _messenger.Info(message);
        }
    }
}

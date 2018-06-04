using System;
using Microsoft.Extensions.DependencyInjection;

namespace graphdbtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var provider = SetupDi();
            var messenger = provider.GetService<IMessenger>();
            messenger.Error("Did this work?");

        }

        private static IServiceProvider SetupDi() {
            var services = new ServiceCollection();
            services.AddScoped<IMessenger, Messenger>();
            return services.BuildServiceProvider();
        }
    }

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

using System;
using Microsoft.Extensions.DependencyInjection;
using Gremlin.Net.Driver;

namespace graphdbtest
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = SetupDi();
            var messenger = provider.GetService<IMessenger>();
        }

        private static IServiceProvider SetupDi() {
            var services = new ServiceCollection();
            services.Scan(s => s.FromAssemblyOf<IMessenger>().AddClasses(c => c.AssignableTo<IMessenger>()).AsImplementedInterfaces().WithTransientLifetime());
            return services.BuildServiceProvider();
        }
    }
}

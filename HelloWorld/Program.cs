using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paramore.Brighter;
using Paramore.Brighter.Logging;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var registry = new SubscriberRegistry();
            registry.Register<GreetingCommand, GreetingCommandHander>();

            var builder = CommandProcessorBuilder.With()
                .Handlers(new HandlerConfiguration(
                    subscriberRegistry: registry,
                    handlerFactory: new SimpleHandlerFactory()
                ))
                .DefaultPolicy()
                .NoTaskQueues()
                .RequestContextFactory(new InMemoryRequestContextFactory());

            var commandProcessor = builder.Build();

            commandProcessor.Send(new GreetingCommand("Jimmy"));

            Console.ReadLine();
        }
    }
}

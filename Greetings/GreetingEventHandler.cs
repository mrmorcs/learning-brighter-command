using System;
using Greetings.Ports.Commands;
using Paramore.Brighter;

namespace Greetings
{
    internal class GreetingEventHandler : RequestHandler<GreetingEvent>
    {
        public override GreetingEvent Handle(GreetingEvent command)
        {
            Console.WriteLine("Received Greeting. Message Follows");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(command.Greeting);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Message Ends");
            return base.Handle(command);
        }
    }
}
using System;
using Paramore.Brighter;

namespace HelloWorld
{
    class GreetingCommandHander : RequestHandler<GreetingCommand>
    {
        public override GreetingCommand Handle(GreetingCommand command)
        {
            Console.WriteLine("Hello {0}", command.Name);
            return base.Handle(command);
        }
    }
}
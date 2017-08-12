using System;
using Paramore.Brighter;

namespace HelloWorld
{
    internal class SimpleHandlerFactory : IAmAHandlerFactory
    {
        public IHandleRequests Create(Type handlerType)
        {
            if(handlerType != typeof(GreetingCommandHandler)) throw new Exception("Unknown handler type: " + handlerType.FullName);
            return new GreetingCommandHandler();
        }

        public void Release(IHandleRequests handler)
        {
        }
    }
}
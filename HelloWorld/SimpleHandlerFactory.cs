using System;
using Paramore.Brighter;

namespace HelloWorld
{
    internal class SimpleHandlerFactory : IAmAHandlerFactory
    {
        public IHandleRequests Create(Type handlerType)
        {
            return (IHandleRequests) Activator.CreateInstance(handlerType);
        }

        public void Release(IHandleRequests handler)
        {
        }
    }
}
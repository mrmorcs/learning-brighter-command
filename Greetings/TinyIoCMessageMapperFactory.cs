using System;
using Paramore.Brighter;
using TinyIoC;

namespace Greetings
{
    internal class TinyIoCMessageMapperFactory : IAmAMessageMapperFactory
    {
        private readonly TinyIoCContainer _container;

        public TinyIoCMessageMapperFactory(TinyIoCContainer container)
        {
            _container = container;
        }

        public IAmAMessageMapper Create(Type messageMapperType)
        {
            return (IAmAMessageMapper) _container.Resolve(messageMapperType);
        }
    }
}
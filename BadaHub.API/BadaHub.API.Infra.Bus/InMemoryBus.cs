﻿using BadaHub.API.Domain.Core.Bus;
using BadaHub.API.Domain.Core.Commands;
using BadaHub.API.Domain.Core.Events;
using MediatR;
using System.Threading.Tasks;

namespace BadaHub.API.Infra.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;
        private readonly IEventStore _eventStore;

        public InMemoryBus(IEventStore eventStore, IMediator mediator)
        {
            _eventStore = eventStore;
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return Publish(command);
        }

        public Task RaiseEvent<T>(T @event) where T : Event
        {
            if (!@event.MessageType.Equals("DomainNotification"))
                _eventStore?.Save(@event);

            return Publish(@event);
        }

        private Task Publish<T>(T message) where T : Message
        {
            return _mediator.Publish(message);
        }
    }
}

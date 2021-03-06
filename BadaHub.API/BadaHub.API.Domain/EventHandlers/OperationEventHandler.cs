﻿using BadaHub.API.Domain.Events;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BadaHub.API.Domain.EventHandlers
{
    public class OperationEventHandler :
        INotificationHandler<OperationDispatchedEvent>
    {
        //public void Handle(CustomerUpdatedEvent message)
        //{
        //    // Send some notification e-mail
        //}

        public void Handle(OperationDispatchedEvent message)
        {
            // Send some greetings e-mail
        }

        public Task Handle(OperationDispatchedEvent notification, CancellationToken cancellationToken)
        {
            return new Task(() => { });
        }

        //public void Handle(CustomerRemovedEvent message)
        //{
        //    // Send some see you soon e-mail
        //}
    }
}

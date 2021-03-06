﻿using BadaHub.API.Domain.Commands;
using BadaHub.API.Domain.Core.Models;
using System;

namespace BadaHub.API.Domain.Models
{
    public class Operation : Entity
    {
        public Operation(Guid id, OperationType type, string payload)
        {
            Id = id;
            Type = type;
            Payload = payload;
        }

        // Empty constructor for EF
        protected Operation() { }

        public Guid Id { get; private set; }

        public OperationType Type { get; private set; }

        public string Payload { get; private set; }
    }
}

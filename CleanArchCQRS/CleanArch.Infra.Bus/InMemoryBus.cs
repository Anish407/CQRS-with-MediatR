using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Bus
{
   public sealed class InMemoryBus:IMediatorHandler
    {
        public InMemoryBus(IMediator mediator)
        {
            Mediator = mediator;
        }

        public IMediator Mediator { get; }


        public Task SendCommand<T>(T command) where T: Command
        {
            return Mediator.Send(command);
        } 
    }
}

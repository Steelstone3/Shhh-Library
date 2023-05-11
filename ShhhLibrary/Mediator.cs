using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShhhLibrary.Handlers;
using ShhhLibrary.Notifications;
using ShhhLibrary.Publishers;

namespace ShhhLibrary
{
    public class Mediator : IMediator
    {
        private readonly IEnumerable<IHandler<INotification>> requestHandlers;

        public Mediator(IEnumerable<IHandler<INotification>> requestHandlers)
        {
            this.requestHandlers = requestHandlers;
        }

        public Task Publish(INotification request)
        {
            foreach (IHandler<INotification> requestHandler in requestHandlers)
            {
                if (!request.GetType().Equals(requestHandler.GetType()))
                {
                    throw new Exception($"Request type doesn't match request handler: {request} != {requestHandler}");
                }

                requestHandler.Handle(request);
            }

            return Task.CompletedTask;
        }
    }
}
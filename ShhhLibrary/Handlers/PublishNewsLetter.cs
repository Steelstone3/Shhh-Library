using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ShhhLibrary.Notifications;

namespace ShhhLibrary.Handlers
{
    public class PublishNewsLetter : INotificationHandler<BookRelease>
    {
        public Task Handle(BookRelease bookRelease, CancellationToken cancellationToken)
        {
            bookRelease.Library.PublishNewsLetter(bookRelease.Book);
            return Task.CompletedTask;
        }
    }
}
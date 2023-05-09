using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ShhhLibrary.Models;
using ShhhLibrary.Notifications;

namespace ShhhLibrary.Handlers
{
    public class PublishNewsLetter : INotificationHandler<BookRelease>
    {
        private readonly ILibrary library;

        public PublishNewsLetter(ILibrary library)
        {
            this.library = library;
        }

        public Task Handle(BookRelease bookRelease, CancellationToken cancellationToken)
        {
            library.PublishNewsLetter(bookRelease.Book);
            return Task.CompletedTask;
        }
    }
}
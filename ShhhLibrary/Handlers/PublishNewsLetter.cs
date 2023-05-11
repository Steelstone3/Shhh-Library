using System;
using System.Threading;
using System.Threading.Tasks;
using ShhhLibrary.Models;
using ShhhLibrary.Notifications;

namespace ShhhLibrary.Handlers
{
    public class PublishNewsLetter : IHandler<BookRelease, bool>
    {
        private readonly ILibrary library;

        public PublishNewsLetter(ILibrary library)
        {
            this.library = library;
        }

        public Task<bool> HandleAsync(BookRelease bookRelease)
        {
            library.PublishNewsLetter(bookRelease.Book);
            return Task.FromResult(true);
            // return Task.CompletedTask;
        }
    }
}
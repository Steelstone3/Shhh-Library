using System.Threading.Tasks;
using ShhhLibrary.Models;
using ShhhLibrary.Notifications;

namespace ShhhLibrary.Handlers
{
    public class PublishNewsLetter : IHandler<BookRelease>
    {
        private readonly ILibrary library;

        public PublishNewsLetter(ILibrary library)
        {
            this.library = library;
        }

        public Task Handle(BookRelease bookRelease)
        {
            library.PublishNewsLetter(bookRelease.Book);
            return Task.CompletedTask;
        }
    }
}
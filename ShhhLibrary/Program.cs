using System.Collections.Generic;
using System.Threading.Tasks;
using ShhhLibrary.Handlers;
using ShhhLibrary.Models;
using ShhhLibrary.Notifications;
using ShhhLibrary.Publishers;
using ShhhLibraryTests.Models;

namespace ShhhLibrary
{
    internal static class Program
    {
        internal static async Task Main()
        {
            // Request
            // Handler
            // Mediator
            // Request → Mediator → Handler → Response

            // Models
            IBook oldBook = new Book("Hogwarts", "Harry Potter");
            IBook book = new Book("Bob's Life", "Jeff");
            List<IBook> books = new() { oldBook };
            ILibrary library = new Library(books);

            // Request
            INotification bookRelease = new BookRelease(book);

            // Handlers
            IEnumerable<IHandler<BookRelease>> requestHandlers = new List<IHandler<BookRelease>>()
            {
                new OrderBook(library),
                new PublishNewsLetter(library),
            };

            // Mediator
            Mediator mediator = new((IEnumerable<IHandler<INotification>>)requestHandlers);

            // Request → Mediator → Handler → Response
            await mediator.Publish(bookRelease);
        }
    }
}

using System.Threading;
using System.Threading.Tasks;
using ShhhLibrary.Models;
using ShhhLibrary.Notifications;

namespace ShhhLibrary.Handlers
{
    public class OrderBook : IHandler<BookRelease>
    {
        private readonly ILibrary library;

        public OrderBook(ILibrary library)
        {
            this.library = library;
        }

        public Task Handle(BookRelease bookRelease)
        {
            library.PrintBookOnOrder(bookRelease.Book);
            library.AddBook(bookRelease.Book);
            return Task.CompletedTask;
        }
    }
}
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ShhhLibrary.Models;
using ShhhLibrary.Notifications;

namespace ShhhLibrary.Handlers
{
    public class OrderBook : INotificationHandler<BookRelease>
    {
        private ILibrary library;

        public OrderBook(ILibrary library)
        {
            this.library = library;
        }

        public Task Handle(BookRelease bookRelease, CancellationToken cancellationToken)
        {
            library.PrintBookOnOrder(bookRelease.Book);
            library.AddBook(bookRelease.Book);
            return Task.CompletedTask;
        }
    }
}
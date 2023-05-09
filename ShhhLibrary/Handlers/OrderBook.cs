using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ShhhLibrary.Notifications;

namespace ShhhLibrary.Handlers
{
    public class OrderBook : INotificationHandler<BookRelease>
    {
        public Task Handle(BookRelease bookRelease, CancellationToken cancellationToken)
        {
            bookRelease.Library.PrintBookOnOrder(bookRelease.Book);
            bookRelease.Library.AddBook(bookRelease.Book);
            return Task.CompletedTask;
        }
    }
}
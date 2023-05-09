using MediatR;
using ShhhLibrary.Models;

namespace ShhhLibrary.Notifications
{
    public class BookRelease : INotification
    {
        public BookRelease(IBook book)
        {
            Book = book;
        }

        public IBook Book { get; }
    }
}
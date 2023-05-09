using MediatR;
using ShhhLibrary.Models;

namespace ShhhLibrary.Notifications
{
    public class BookRelease : INotification
    {
        public BookRelease(IBook book, ILibrary library)
        {
            Book = book;
            Library = library;
        }

        public IBook Book { get; }
        public ILibrary Library { get; }
    }
}
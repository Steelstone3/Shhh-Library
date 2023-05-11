using ShhhLibrary.Models;
using ShhhLibrary.Publishers;

namespace ShhhLibrary.Notifications
{
    public class BookRelease : IRequest<bool>
    {
        public BookRelease(IBook book)
        {
            Book = book;
        }

        public IBook Book { get; }
    }
}
using System.Threading.Tasks;
using Moq;
using ShhhLibrary.Handlers;
using ShhhLibrary.Models;
using ShhhLibrary.Notifications;
using Xunit;

namespace ShhhLibraryTests.Handlers
{
    public class OrderBookShould
    {
        [Fact]
        public async Task OrderTheNewBook()
        {
            // Given
            Mock<IBook> book = new();
            Mock<ILibrary> library = new();
            library.Setup(lib => lib.PrintBookOnOrder(book.Object));
            library.Setup(lib => lib.AddBook(book.Object));
            BookRelease bookRelease = new(book.Object);
            OrderBook orderBook = new(library.Object);

            // When
            await orderBook.Handle(bookRelease, default);

            // Then
            book.VerifyAll();
            library.VerifyAll();
        }
    }
}
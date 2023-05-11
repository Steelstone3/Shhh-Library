using System.Threading.Tasks;
using Moq;
using ShhhLibrary.Handlers;
using ShhhLibrary.Models;
using ShhhLibrary.Notifications;
using Xunit;

namespace ShhhLibraryTests.Handlers
{
    public class PublishNewsLetterShould
    {
        [Fact]
        public async Task PrintNewsLetter()
        {
            // Given
            Mock<IBook> book = new();
            Mock<ILibrary> library = new();
            library.Setup(lib => lib.PublishNewsLetter(book.Object));
            BookRelease bookRelease = new(book.Object);
            PublishNewsLetter publishNewsLetter = new(library.Object);

            // When
            await publishNewsLetter.Handle(bookRelease);

            // Then
            book.VerifyAll();
            library.VerifyAll();
        }
    }
}
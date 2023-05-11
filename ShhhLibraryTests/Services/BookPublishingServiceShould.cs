using System.Threading.Tasks;
using Moq;
using ShhhLibrary;
using ShhhLibrary.Models;
using ShhhLibrary.Notifications;
using ShhhLibrary.Services;
using Xunit;

namespace ShhhLibraryTests.Services
{
    public class BookPublishingServiceShould
    {
        private readonly Mock<IMediator> mediator = new();
        private readonly BookPublishingService bookPublishingService;

        public BookPublishingServiceShould()
        {
            bookPublishingService = new BookPublishingService(mediator.Object);
        }

        [Fact]
        public async Task NotifyABookRelease()
        {
            // Given
            Mock<IBook> book = new();
            BookRelease bookRelease = new(book.Object);
            mediator.Setup(m => m.Publish(bookRelease));

            // When
            await bookPublishingService.Execute(bookRelease);

            // Then
            mediator.VerifyAll();
        }
    }
}
using System.Threading.Tasks;
using MediatR;
using Moq;
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
            Book book = new("Bob The Frog", "James Corden");
            BookRelease bookRelease = new(book);
            mediator.Setup(m => m.Publish(bookRelease, default));

            // When
            await bookPublishingService.ExecuteAsync(bookRelease);

            // Then
            mediator.VerifyAll();
        }
    }
}
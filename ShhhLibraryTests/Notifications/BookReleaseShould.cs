using Moq;
using ShhhLibrary.Models;
using ShhhLibrary.Notifications;
using Xunit;

namespace ShhhLibraryTests.Notifications
{
    public class BookReleaseShould
    {
        [Fact]
        public void Construct()
        {
            // Given
            Mock<IBook> book = new();
            Mock<ILibrary> library = new();
            BookRelease bookRelease = new(book.Object, library.Object);

            // Then
            Assert.NotNull(bookRelease.Book);
        }
    }
}
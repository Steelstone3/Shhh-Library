using ShhhLibrary.Models;
using Xunit;

namespace ShhhLibraryTests.Models
{
    public class BookShould
    {
        [Fact]
        public void Construct()
        {
            // Given
            const string title = "You're a wizard 'arry";
            const string author = "Hagrid";
            IBook book = new Book(title, author);

            // Then
            Assert.Equal(title, book.Title);
            Assert.Equal(author, book.Author);
        }
    }
}
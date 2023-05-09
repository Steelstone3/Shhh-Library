using System.Collections.Generic;
using Moq;
using ShhhLibrary.Models;
using Xunit;

namespace ShhhLibraryTests.Models
{
    public class LibraryShould
    {
        private ILibrary library;

        [Fact]
        public void Construct()
        {
            // Given
            IList<IBook> books = new List<IBook>();
            library = new Library(books);

            // Then
            Assert.Equal(books, library.Books);
        }

        [Fact]
        public void AddBook()
        {
            // Given
            IList<IBook> books = new List<IBook>();
            ILibrary library = new Library(books);
            Mock<IBook> book = new();

            // When
            library.AddBook(book.Object);

            // Then
            Assert.NotEmpty(library.Books);
        }
    }
}
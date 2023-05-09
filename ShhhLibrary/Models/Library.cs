using System;
using System.Collections.Generic;
using ShhhLibrary.Models;

namespace ShhhLibraryTests.Models
{
    public class Library : ILibrary
    {
        public Library(IList<IBook> books)
        {
            this.Books = books;
        }

        public IList<IBook> Books { get; }

        public void AddBook(IBook book)
        {
            Books.Add(book);
        }

        public void PrintBookOnOrder(IBook book)
        {
            Console.WriteLine($"Library: {book.Title} by {book.Author} is on order");
            Console.WriteLine($"Library: Order of {book.Title} by {book.Author} is complete");
        }

        public void PublishNewsLetter(IBook book)
        {
            Console.WriteLine($"NewsLetter: {book.Title} by {book.Author} is on order and will be ready shortly stay tuned library folks, Shhh Library Newsletter");
        }
    }
}
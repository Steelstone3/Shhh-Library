namespace ShhhLibrary.Models
{
    public class Book : IBook
    {
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public string Title { get; }
        public string Author { get; }
    }
}
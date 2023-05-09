using System.Collections.Generic;

namespace ShhhLibrary.Models
{
    public interface ILibrary
    {
        IList<IBook> Books { get; }
        void AddBook(IBook book);
        void PrintBookOnOrder(IBook book);
        void PublishNewsLetter(IBook book);
    }
}
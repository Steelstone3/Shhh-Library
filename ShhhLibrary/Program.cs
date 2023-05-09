using System.Threading.Tasks;
using MediatR;
using ShhhLibrary.Models;
using ShhhLibrary.Notifications;
using ShhhLibrary.Services;

namespace BubblesDivePlanner
{
    internal static class Program
    {
        internal static async Task Main()
        {
            // Mediator mediator = new();
            BookPublishingService bookPublishingService = new(default);

            Book book = new("Hogwarts", "Harry Potter");
            BookRelease bookRelease = new(book);
            await bookPublishingService.ExecuteAsync(bookRelease);
        }
    }
}

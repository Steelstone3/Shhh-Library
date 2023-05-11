using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ShhhLibrary.Models;
using ShhhLibrary.Notifications;
using ShhhLibrary.Services;

namespace BubblesDivePlanner
{
    internal static class Program
    {
        internal static async Task Main()
        {
            // Create a new ServiceCollection instance
            // var services = new ServiceCollection();

            // Register the necessary dependencies
            // services.AddMediatR(typeof(Program).Assembly);

            // Build the service provider and get an instance of Mediator
            // var serviceProvider = services.BuildServiceProvider();
            // var mediator = serviceProvider.GetService<IMediator>();

            // Create the publishing service and execute the request
            var bookPublishingService = new BookPublishingService(default);
            var book = new Book("Hogwarts", "Harry Potter");
            var bookRelease = new BookRelease(book);
            await bookPublishingService.ExecuteAsync(bookRelease);
        }
    }
}

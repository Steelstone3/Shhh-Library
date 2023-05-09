using System.Threading.Tasks;
using MediatR;
using ShhhLibrary.Notifications;

namespace ShhhLibrary.Services
{
    public class BookPublishingService
    {
        private readonly IMediator mediator;

        public BookPublishingService(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task ExecuteAsync(BookRelease bookRelease)
        {
            await mediator.Publish(bookRelease);
        }
    }
}
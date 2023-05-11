using System.Threading.Tasks;
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

        public async Task Execute(BookRelease bookRelease)
        {
            await mediator.Publish(bookRelease);
        }
    }
}
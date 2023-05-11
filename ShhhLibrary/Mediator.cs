using System.Threading.Tasks;
using ShhhLibrary.Publishers;

namespace ShhhLibrary
{
    public class Mediator : IMediator
    {
        public Task<TResponse> Publish<TResponse>(IRequest<TResponse> request)
        {
            throw new System.NotImplementedException();
        }
    }
}
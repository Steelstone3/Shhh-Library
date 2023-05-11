using System.Threading.Tasks;
using ShhhLibrary.Publishers;

namespace ShhhLibrary.Handlers
{
    public interface IHandler<in TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        Task<TResponse> HandleAsync(TRequest request);
    }
}
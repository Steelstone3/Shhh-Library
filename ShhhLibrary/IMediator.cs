using System;
using System.Threading.Tasks;
using ShhhLibrary.Publishers;

namespace ShhhLibrary
{
    public interface IMediator
    {
        Task<TResponse> Publish<TResponse>(IRequest<TResponse> request);
    }
}
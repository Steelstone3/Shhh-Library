using System;
using System.Threading.Tasks;
using ShhhLibrary.Publishers;

namespace ShhhLibrary
{
    public interface IMediator
    {
        Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request);
    }
}
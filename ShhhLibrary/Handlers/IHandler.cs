using System.Threading.Tasks;

namespace ShhhLibrary.Handlers
{
    public interface IHandler<TRequest>
    {
        Task Handle(TRequest request);
    }
}
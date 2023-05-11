using System.Threading.Tasks;
using ShhhLibrary.Publishers;

namespace ShhhLibrary
{
    public interface IMediator
    {
        Task Publish(INotification request);
    }
}
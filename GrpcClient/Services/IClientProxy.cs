using System.Threading.Tasks;

namespace GrpcClient.Services
{
    public interface IClientProxy
    {
       Task<HelloReply> InvokeAsync();
    }
}
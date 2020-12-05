using System.Dynamic;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace GrpcClient.Services
{
    public class ClientProxy : IClientProxy
    {
        public ClientProxy()
        {
        }

        public async Task<HelloReply> InvokeAsync()
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client =  new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                new HelloRequest { Name = "GreeterClient" });
            return reply;
        }
    }
}
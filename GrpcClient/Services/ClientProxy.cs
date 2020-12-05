using System.Dynamic;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace GrpcClient.Services
{
    public class ClientProxy : IClientProxy
    {
        private Greeter.GreeterClient _client;
        
        public ClientProxy()
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            _client =  new Greeter.GreeterClient(channel);
        }

        public async Task<HelloReply> InvokeAsync()
        {
            var reply = await this._client.SayHelloAsync(
                new HelloRequest { Name = "GreeterClient" });
            return reply;
        }
    }
}
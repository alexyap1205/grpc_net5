using System.Threading.Tasks;
using GrpcClient.Services;
using Microsoft.AspNetCore.Mvc;

namespace GrpcClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GrpcController : Controller
    {
        private readonly IClientProxy _proxy;

        public GrpcController(IClientProxy proxy)
        {
            _proxy = proxy;
        }
        
        // GET
        [HttpGet]
        public async Task<HelloReply> Index()
        {
            return await this._proxy.InvokeAsync();
        }
    }
}
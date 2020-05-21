using Grpc.Core;
using GrpcGreeter;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;

    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }
    
    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        _logger.LogInformation($"Request: {@request}");
        var reply = new HelloReply { Message = $"Hello from gRPC, {request.Name}!" };
        _logger.LogInformation($"Reply: {@reply}");
        return Task.FromResult(reply);
    }
}
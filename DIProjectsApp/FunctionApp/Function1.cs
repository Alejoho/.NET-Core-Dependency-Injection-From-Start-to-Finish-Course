using DIDemoLib;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;

namespace FunctionApp
{
    public class Function1
    {
        //private readonly ILogger<Function1> _logger;
        private readonly IMessages _messages;

        public Function1(IMessages messages)
        {
            //_logger = logger;
            _messages = messages;
        }

        [Function("Function1")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            //_logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult(new string[] { _messages.SayHello(), _messages.SayGoodBye() });
        }
    }
}

using DIDemoLib;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class MessagesController : Controller
{
    private readonly IMessages _messages;

    public MessagesController(IMessages messages)
    {
        _messages = messages;
    }

    [HttpGet]
    public IEnumerable<string> Get()
    {
        return [_messages.SayHello(), _messages.SayGoodBye()];
    }
}
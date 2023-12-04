using Microsoft.AspNetCore.Mvc;

namespace CommandsService;

[Route("api/c/[controller]")]
[ApiController]
public class PlatformsController : ControllerBase
{
    public PlatformsController()
    {

    }

    [HttpPost]
    public ActionResult testInboundConnection()
    {
        Console.WriteLine("==> Inbound POST # Command Service");

        return Ok("Inbound test ok from Platforms Controller");
    }
}


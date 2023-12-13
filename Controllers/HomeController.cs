using BlogASPNET.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace BlogASPNET.Controllers;

[ApiController]
[Route("")]
public class HomeController: ControllerBase
{
    [HttpGet("")]
    [ApiKey]
    public IActionResult Get()
    {
        return Ok();
    }
}

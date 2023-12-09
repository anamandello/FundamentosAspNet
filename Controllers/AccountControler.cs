using BlogASPNET.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogASPNET.Controllers;

[ApiController]
public class AccountControler : ControllerBase
{
    private readonly TokenService _tokenService;
    public AccountControler(TokenService tokenService)
    {
        _tokenService = tokenService;
    }
    [HttpPost("v1/login")]
    public IActionResult Login()
    {
        var token = _tokenService.GenerateToken(null);

        return Ok(token);
    }
}

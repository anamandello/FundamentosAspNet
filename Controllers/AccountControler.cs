using BlogASPNET.Data;
using BlogASPNET.Extensions;
using BlogASPNET.Models;
using BlogASPNET.Services;
using BlogASPNET.ViewModels;
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

    [HttpPost("v1/accounts/")]
    public async Task<IActionResult> Post([FromBody] RegisterViewModel model, [FromServices] DataContext context)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var user = new User()
        {
            Name = model.Name,
            Email = model.Email,
            Slug = model.Email.Replace("@", "-").Replace(".", "-")
        };

        return Ok(user);
    }

    [HttpPost("v1/accounts/login")]
    public IActionResult Login()
    {
        var token = _tokenService.GenerateToken(null);

        return Ok(token);
    }

}

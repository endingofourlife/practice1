using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services;

namespace WebApplication2.Controllers;

[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public IActionResult Login(string username, string password)
    {
        // it returns OK in any case. To change behavior, some logic in auth service should be implemented
        if (_authService.AuthenticateUser(username, password))
            return Ok();
        return Unauthorized();
    }
}
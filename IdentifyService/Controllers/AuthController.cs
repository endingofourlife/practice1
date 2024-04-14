using IdentifyService.Services;
using Microsoft.AspNetCore.Mvc;

namespace IdentifyService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }
    [HttpPost("authenticate")]
    public IActionResult Authenticate(string username, string password)
    {
        if (_authService.AuthenticateUser(username, password))
        {
            // Перевірка доступу до сервісів
            var paymentResult = CallPaymentsService();
            var subscriptionResult = CallSubscriptionsService();

            // Генерація JWT токена та його повернення
            var token = GenerateToken();
            return Ok(new { Token = token });
        }

        return Ok();
        //return Unauthorized();
    }

    [HttpPost("verify")]
    public IActionResult Verify(string token)
    {
        return Ok();
    }
    private bool CallPaymentsService()
    {
        // Виклик сервісу оплати для перевірки доступу
        return true; // Повертаємо true для прикладу
    }

    private bool CallSubscriptionsService()
    {
        // Виклик сервісу підписок для перевірки доступу
        return true; // Повертаємо true для прикладу
    }

    private string GenerateToken()
    {
        // Генерація JWT токена
        return "MegaSecretJWTToken_=)";
    }

}
using Microsoft.AspNetCore.Mvc;

namespace PaymentsService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PaymentsController : ControllerBase
{
    private readonly Services.PaymentsService _paymentsService;

    public PaymentsController(Services.PaymentsService paymentsService)
    {
        _paymentsService = paymentsService;
    }
    
    [HttpPost("process")]
    public IActionResult ProcessPayment(int userId, decimal amount)
    {
        // does user have a subscription ? 
        var subscriptionResult = CallSubscriptionsService();

        // some logic to handle a payment

        return Ok();
    }

    private bool CallSubscriptionsService()
    {
        // Виклик сервісу підписок для перевірки доступу
        return true; // Повертаємо true для прикладу
    }
}
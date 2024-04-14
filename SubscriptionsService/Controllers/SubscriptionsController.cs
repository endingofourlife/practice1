using Microsoft.AspNetCore.Mvc;

namespace SubscriptionsService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubscriptionsController : ControllerBase
{
   private readonly Services.SubscriptionsService _subscriptionsService;

   public SubscriptionsController(Services.SubscriptionsService subscriptionsService)
   {
      _subscriptionsService = subscriptionsService;
   }
   [HttpPost("subscribe")]
   public async Task<IActionResult> Subscribe(int userId, string plan, string token)
   {
      if (await _subscriptionsService.SubscribeUser(userId, plan, token))
      {
         return Ok();   
      }

      return Unauthorized();
   }
}
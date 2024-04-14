using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionsController : ControllerBase
    {
        private readonly SubscriptionsService _subscriptionsService;

        public SubscriptionsController(SubscriptionsService subscriptionsService)
        {
            _subscriptionsService = subscriptionsService;
        }
        
        [HttpPost]
        public IActionResult Subscribe(int userId, string plan)
        {
            // it returns OK in any case. To change behavior, some logic in auth service should be implemented
            if (_subscriptionsService.SubscribeUser(userId, plan))
                return Ok();
            return BadRequest();
        }
    }
}

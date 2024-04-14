using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly PaymentsService _paymentsService;

        public PaymentsController(PaymentsService paymentsService)
        {
            _paymentsService = paymentsService;
        }

        [HttpPost("process")]
        public IActionResult ProcessPayment(int userId, decimal amount)
        {
            if (_paymentsService.ProcessPayment(userId, amount))
                return Ok();
            return BadRequest();
        }
    }
}

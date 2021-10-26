using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApi.Controllers
{
    public class OrdersController : ControllerBase
    {
        [HttpPost("/orders")]
        public async Task<ActionResult> PlaceOrder([FromBody] OrderPostRequest request)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            return StatusCode(201, new { });
        }

    }
}

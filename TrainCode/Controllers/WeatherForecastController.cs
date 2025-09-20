using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using TrainCode.Models;
using TrainCode.Services;

namespace TrainCode.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase

    {
        private OrderManager _orderManager;
        public WeatherForecastController(OrderManager orderManager )
        {
            _orderManager = orderManager;
            
        }

    

        [HttpPost(Name = "PostOrder")]
        public ActionResult<List<Order>> PostOrder(int userId, int productId, int quantity, decimal totalPrice)
        {
            try
            {
                var results = _orderManager.CreateOrder(userId, productId, quantity, totalPrice);
                return Ok(results); // Tr? v? List<Order>
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

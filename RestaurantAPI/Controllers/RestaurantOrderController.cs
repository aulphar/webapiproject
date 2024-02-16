using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Models;

namespace RestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantOrderController : ControllerBase
    {
        [HttpGet]
        public IActionResult DisplayOrder()
        {
            var receipt = new
            {
                FullOrder.AllOrders,
                FullOrder.AmountBeforeTax,
                FullOrder.Tax,
                FullOrder.TotalAfterTax
            };

            string filepath = @"\order.txt";

            using (StreamWriter writer = new StreamWriter(filepath))
            {
                writer.WriteLine(receipt);
            }

            return Ok(receipt);
        }

    }
}

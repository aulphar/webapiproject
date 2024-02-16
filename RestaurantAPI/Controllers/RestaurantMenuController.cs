using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Data;
using RestaurantAPI.Models;

namespace RestaurantAPI.Controllers
{
    
    [ApiController]
    [Route("api/restaurantmenu")]
    public class RestaurantMenuController : ControllerBase
    {
        private Restaurant mamaskitchen = new Restaurant()
        {
            RestaurantName = "Mama's Kitchen",
            CuisineType = "English Cuisine"
        };

        [HttpGet(Name = "DisplayMenu")]
        public IActionResult DisplayMenu()
        {
            return Ok(mamaskitchen.Menu);
           
        }

        [HttpPost]
        public IActionResult TakeOrder([FromBody] string selecteditem)
        {
            
            foreach (var pair in mamaskitchen.Menu)
            {
                if (pair.Value.MenuItems.ContainsKey(selecteditem))
                {
                    Order.CartItems[selecteditem] = pair.Value.MenuItems[selecteditem]; 
                }
               
            }
            return Ok(Order.CartItems);
        }
    } 




}

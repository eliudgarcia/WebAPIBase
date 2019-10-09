using System;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIBase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantsController: ControllerBase
    {
        string[] restaurantsArray = new string[4] {"Pizzeria Perro Negro", "Casa de toño", "7Eleven", "El Moro"};


        [HttpGet]
        public string GetRestaurants()
        {
            return restaurantsArray[new Random().Next(0,4)];
        }
    }
}
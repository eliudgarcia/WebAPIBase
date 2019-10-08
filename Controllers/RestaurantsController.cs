using Microsoft.AspNetCore.Mvc;

namespace WebAPIBase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantsController: ControllerBase
    {
        [HttpGet]
        public string GetRestaurants()
        {
            return "Pizzeria Perro Negro";
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {
        [HttpGet]
        public string GetShirts()
        {
            return "Reading All Shirts";
        }

        [HttpGet("{id}/{color}")]
        public string GetShirtById(int id, [FromRoute] string color)
        {
            return $"Reading shirt: {id}, color: {color}";
        }

        [HttpPost]
        public string CreateShirt([FromBody]Shirt shirt)
        {
            return $"Creating a shirt";
        }

        [HttpPut("{id}")]
        public string UpdateShirt(int id) 
        {
            return $"Updating Shirt: {id}";
        }

        [HttpDelete("{id}")]
        public string DeleteShirt(int id)
        {
            return $"Deleting Shirt: {id}";
        }
    }
}

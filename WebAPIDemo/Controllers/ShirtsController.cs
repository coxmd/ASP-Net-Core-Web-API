using Microsoft.AspNetCore.Mvc;

namespace WebAPIDemo.Controllers
{
    [ApiController]
    public class ShirtsController : ControllerBase
    {
        public string GetShirts()
        {
            return "Reading All Shirts";
        }

        public string GetShirtById(int id)
        {
            return $"Reading shirt: {id}";
        }

        public string CreateShirt()
        {
            return $"Creating a shirt";
        }

        public string UpdateShirt(int id) 
        {
            return $"Updating Shirt: {id}";
        }
    }
}

using API_MobileTEST.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;

namespace API_MobileTEST.Controllers
{
    [Route("api/[Action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [Route("/")]
        [HttpGet]
        public IActionResult runing()
        {

            return Ok("Rining.... API Mobile [TEST]");
        }


        [HttpGet]
        public IActionResult run()
        {

            var items = new List<Item>
        {
            new Item { Id = 1, Title = "Item 1", Subtitle = "Subtitle 1" },
            new Item { Id = 2, Title = "Item 2", Subtitle = "Subtitle 2" },
            new Item { Id = 3, Title = "Item 3", Subtitle = "Subtitle 3" }
            // Add more items as needed
        };

            return Ok(items);
        }
    }
}

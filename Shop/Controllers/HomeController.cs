using Microsoft.AspNetCore.Mvc;
using Shop.Domain;

namespace Shop.Controllers
{
    [ApiController]
    [Route("api")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        [Route("orders")]
        public Order Get()
        {
            var order = new Order(25);
            return order;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Shop.Domain;

namespace Shop.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        [Route("")]
        public Order Get()
        {
            var order = new Order(25);
            return order;
        }
    }
}

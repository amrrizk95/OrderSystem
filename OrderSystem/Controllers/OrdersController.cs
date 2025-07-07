using Microsoft.AspNetCore.Mvc;
using Orders.Application.UseCases;
using Orders.Domain.Entities;

namespace OrderSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly CreateOrder _createOrder;
        private readonly GetOrder _getOrder;

        public OrderController(CreateOrder createOrder, GetOrder getOrder)
        {
            _createOrder = createOrder;
            _getOrder = getOrder;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] string product)
        {
            var id = await _createOrder.ExecuteAsync(product);
            return Ok(id);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> Get(Guid id)
        {
            var order = await _getOrder.ExecuteAsync(id);
            if (order is null)
                return NotFound();
            return Ok(order);
        }
    }
}
